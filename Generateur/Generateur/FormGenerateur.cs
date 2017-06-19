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
using System.Threading;

namespace Generateur
{
    public partial class Generateur : Form
    {
        ServiceHost svh;
        SerialPort port_;
        bool ready_ = false;
        bool success_ = false;

        public Generateur()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(typeof(WCF.IServiceGenerateur), new NetTcpBinding(), "net.tcp://localhost:8000");
            svh.Open();
        }
  
        public bool ready()
        {
            return ready_;
        }

        public bool success()
        {
            return success_;
        }

        private void ports_click(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            selectionCOM.DataSource = ports;
        }

        private void pulse_click(object sender, EventArgs e)
        {
            if (port_ == null)
            {
                StatutsBox.AppendText("Pulse failed \n");
                
            }
            else
            {
                preparation();
                //while (!ready_){  };
                pulse();
                StatutsBox.AppendText("Pulse sent \n");               
            }

        }

        public bool preparation()
        {
            ready_ = false;
            success_ = false;
            if (port_ == null)
            {
                return false;

            }
            else
            {
                byte[] trame = new byte[3];

                trame[0] = 254;
                trame[1] = 6;
                trame[2] = 255;

                port_.Write(trame, 0, 3);
                return true;
            }
        }

        public bool pulse()
        {
            if (port_ == null)
            {
                return false;

            }
            else
            {
                while (!ready_) { };
                byte[] trame = new byte[3];

                trame[0] = 254;
                trame[1] = 5;
                trame[2] = 255;

                port_.Write(trame, 0, 3);
                return true;
            }

        }

        private void choosenCom(object sender, EventArgs e)
        {
            //port_ = new SerialPort(selectionCOM.SelectedIndex.ToString());
        }

        private void statuts_click(object sender, EventArgs e)
        {
            /*
            if (port_ == null)
            {
                StatutsBox.AppendText("Statut request failed \n");
                
            }
            else
            {
                StatutsBox.AppendText("Statut request sent \n");
                
            }*/
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
            // Attach a method to be called when there
            // is data waiting in the port's buffer
            port_.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
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

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            int bytes = 1;
            byte[] buffer = new byte[bytes];
            port_.Read(buffer, 0, bytes);
            //string sBuffer = ByteArrayToHexString(buffer);
            Console.Write(buffer[0]);
            if (buffer[0] == 67) // C
            {
                ready_ = true;
            }
            if(buffer[0] == 68) // D
            {
                success_ = true;
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

        public bool ready()
        {
            return ihm.ready();
        }

        public bool success()
        {
            return ihm.success();
        }

        public void preparation()
        {
            ihm.preparation();
        }
    }
}
