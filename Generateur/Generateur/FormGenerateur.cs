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
             string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                selectionCOM.Items.Add(port);
            }

        }

        private void pulse_click(object sender, EventArgs e)
        {
            string temp = "FE0303010020FF" + "1100";
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

        private void choosenCom(object sender, EventArgs e)
        {
            port_ = new SerialPort(selectionCOM.SelectedIndex.ToString());

        }

        private void statuts_click(object sender, EventArgs e)
        {
            string temp = "FE010000FF" + "1010";
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
            //return ihm. ... ;
            return true;
        }

        public void pulse()
        {
            //ihm.  ... ;
        }
    }
}
