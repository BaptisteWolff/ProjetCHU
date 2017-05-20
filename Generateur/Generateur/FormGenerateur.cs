using System;
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

        public Generateur()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(typeof(WCF.IServiceGenerateur), new NetTcpBinding(), "net.tcp://localhost:8000");
            svh.Open();
        }

  
        private void choiceCOM(object sender, EventArgs e)
        {

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

        }

        private void statuts_click(object sender, EventArgs e)
        {

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
