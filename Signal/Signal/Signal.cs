﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal
{
    // To get the value from the signal
    public partial class Signal : Form
    {
        ServiceHost svh;

        // Create the MATLAB instance 
        MLApp.MLApp matlab = new MLApp.MLApp();

        List<float[]> pos_ = new List<float[]>();
        List<float[]> results_ = new List<float[]>();
        String path1_ = "";

        public Signal()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(typeof(WCF.IServiceSignal), new NetTcpBinding(), "net.tcp://localhost:8003");
            svh.Open();
            // Change to the directory where the function is located 
            // !!!!! Warning !!!!!
            // The path must not contain any space
            string functionPath = "cd " + System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Matlab";
            matlab.Execute(@functionPath);

            listBox1.Items.Add("The following path must not contain any space : ");
            listBox1.Items.Add(functionPath);
        }

        public void valeurSignal(string path)
        {

            // Define the output 
            object result = null;

            /*try
            {
            }
            catch (Exception f)
            {

            }*/
                // Call the funtion with the path
                matlab.Feval("valeur_signal", 1, out result, path);

            // Display result
            object[] res = result as object[];
            // res[0] is the value

            results_.Add(new float[] { (float)res[0] });
            listBox1.Items.Add((float)res[0]);
        }

        public void clearResults()
        {
            results_.Clear();
            pos_.Clear();
        }

        private void buttonFileIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LabelFileIn.Text = fbd.FileName;
            }
        }

        private void buttonValeurSignal_Click(object sender, EventArgs e)
        {
            string path = LabelFileIn.Text;
            if (path != "" && path != null && path != "File name")
            {
                bool valid = false;
                try
                {
                    pos_.Add(new float[] { float.Parse(textBox_posX.Text), float.Parse(textBox_posY.Text), float.Parse(textBox_posZ.Text) });
                    valid = true;
                }
                catch (Exception f)
                {
                    listBox1.Items.Add("Enter a valid position");
                    valid = false;
                }
                if (valid)
                {
                    valeurSignal(LabelFileIn.Text);
                }
            }

            else
            {
                listBox1.Items.Add("Please select a file first");
            }
        }

        public void addPos(float x, float y, float z)
        {
            pos_.Add(new float[] { x, y, z });
        }

        public void setPath(String path)
        {
            path1_ = path;
        }

        private void buttonFileOut_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            //fbd.Description = "";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelPath.Text = fbd.SelectedPath;
            }
        }

        public void mapping()
        {
            // Define the output 
            object result = null;

            // Call the funtion with the path
            matlab.Feval("mapping", 1, out result, results_, pos_, path1_);

            // Display result
            object[] res = result as object[];
            // res[0] is the value

            //result_ = (float)res[0];
            listBox1.Items.Add(res[0]);
        }

        private void button_clearResults_Click(object sender, EventArgs e)
        {
            clearResults();
            listBox1.Items.Add("sucessfully cleared all results");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pos_.Count == 0)
            {
                listBox1.Items.Add("No results to save");
            }
            else
            {
                if (path1_ == "" || path1_ == null)
                {
                    listBox1.Items.Add("Please select a path");
                }
                else
                {
                    mapping();
                }
            }
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class ServiceImplementation : WCF.IServiceSignal
    {
        Signal ihm;
        public ServiceImplementation(Signal f)
        {
            ihm = f;
        }

        public void valeurSignal(string path)
        {
            ihm.valeurSignal(path);
        }

        public void addPos(float x, float y, float z)
        {
            ihm.addPos(x, y, z);
        }

        public void setPath(string path)
        {
            ihm.setPath(path);
        }

        public void clearResults()
        {
            ihm.clearResults();
        }
    }
}
