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
            listBox1.Items.Add(res[0]);
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LabelPath.Text = fbd.FileName;
            }
        }

        private void buttonValeurSignal_Click(object sender, EventArgs e)
        {
            string path = LabelPath.Text;
            if (path != "" && path != null && path != "Path")
            {
                valeurSignal(LabelPath.Text);
            }
            else
            {
                listBox1.Items.Add("Please select a path first");
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
    }
}
