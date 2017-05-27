using System;
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

        List<double> posX_ = new List<double>();
        List<double> posY_ = new List<double>();
        List<double> posZ_ = new List<double>();
        List<double> results_ = new List<double>();
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
            // Call the funtion with the path
            matlab.Feval("valeur_signal", 1, out result, path);

            // Display result
            object[] res = result as object[];
            // res[0] is the value

            results_.Add((double)res[0]);
            //listBox1.Items.Add((double)res[0]);
        }

        public void clearResults()
        {
            results_.Clear();
            posX_.Clear();
            posY_.Clear();
            posZ_.Clear();
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
                    posX_.Add(double.Parse(textBox_posX.Text));
                    posY_.Add(double.Parse(textBox_posY.Text));
                    posZ_.Add(double.Parse(textBox_posZ.Text));
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
                    listBox1.Items.Add("result = " + results_[results_.Count - 1].ToString());
                }
            }

            else
            {
                listBox1.Items.Add("Please select a file first");
            }
        }

        public void addPos(float x, float y, float z)
        {
            posX_.Add(x);
            posY_.Add(y);
            posZ_.Add(z);
        }

        public void setPath(String path)
        {
            path1_ = path;
            labelPath.Text = path1_;
        }

        private void buttonFileOut_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            //fbd.Description = "";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path1_ = fbd.SelectedPath;
                labelPath.Text = path1_;
            }
        }

        public void mapping()
        {
            // Define the output 
            object result = null;
            double[] results = results_.ToArray();
            double[] posX = posX_.ToArray();
            double[] posY = posY_.ToArray();
            double[] posZ = posZ_.ToArray();

            listBox1.Items.Add(posX.ToString());

            // Call the funtion with the path
            String path = path1_ + "\\" + textBox_savedFile.Text;
            matlab.Feval("mapping", 2, out result, results, posX, posY, posZ, path);

            // Display result
            object[] res = result as object[];
            // res[0] is the value

            //result_ = (float)res[0];
            listBox1.Items.Add(res[0]);
            listBox1.Items.Add(res[1]);
        }

        private void button_clearResults_Click(object sender, EventArgs e)
        {
            clearResults();
            listBox1.Items.Add("sucessfully cleared all results");
        }

        private void buttonMapping_Click(object sender, EventArgs e)
        {
            if (results_.Count == 0)
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
