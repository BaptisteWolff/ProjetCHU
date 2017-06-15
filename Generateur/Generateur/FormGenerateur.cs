using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class Generateur : Form
    {
        ServiceHost svh;
        SerialPort port_;

        public Generateur()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(typeof(WCF.IServiceGenerateur), new NetTcpBinding(), "net.tcp://localhost:8000");
            svh.Open();
        }

  

        private void ports_click(object sender, EventArgs e)
        {
            /*string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            selectionCOM.Items.Clear();
            foreach (string port in ports)
            {
                selectionCOM.Items.Add(port);
            }*/
            var ports = SerialPort.GetPortNames();
            selectionCOM.DataSource = ports;
        }

        private void pulse_click(object sender, EventArgs e)
        {
            string temp = "FE0303010020FF";// + "1100";
            float taille = temp.Length;
            string trame = temp + taille.ToString();
            if (port_ == null)
            {
                StatutsBox.AppendText("Pulse failed \n");
                
            }
            else
            {
                port_.WriteLine(trame);
                StatutsBox.AppendText("Pulse sent \n");
               
            }

        }

        public bool pulse()
        {
            string temp = "FE0303010020FF";// +"1100";
            float taille = temp.Length;
            string trame = temp + taille.ToString();
            if (port_ == null)
            {
                return false;

            }
            else
            {
                port_.WriteLine(trame);
                return true;
            }

        }

        private void choosenCom(object sender, EventArgs e)
        {
            //port_ = new SerialPort(selectionCOM.SelectedIndex.ToString());
        }

        private void statuts_click(object sender, EventArgs e)
        {
            string temp = "FE010000FF";//1010";
            float taille = temp.Length;
            string trame = temp + taille.ToString();
            if (port_ == null)
            {
                StatutsBox.AppendText("Statut request failed \n");
                
            }
            else
            {
                StatutsBox.AppendText("Statut request sent \n");
                port_.WriteLine(trame);
                
            }
        }

        public bool getStatus()
        {
            if (port_ == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void selectionCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Connect(string portName)
        {
            port_ = new SerialPort(portName);
            if (!port_.IsOpen)
            {
                port_.BaudRate = 9600;
                port_.Open();
                //Continue here....
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectionCOM.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("You selected port '{0}'", selectionCOM.SelectedItem));
                Connect(selectionCOM.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class ServiceImplementation : WCF.IServiceGenerateur
    {
        Generateur ihm;
        public ServiceImplementation(Generateur f)
        {
            ihm = f;
        }

        public bool getStatus()
        {
            return ihm.getStatus();
        }

        public void pulse()
        {
            ihm.pulse() ;
        }
    }
}
