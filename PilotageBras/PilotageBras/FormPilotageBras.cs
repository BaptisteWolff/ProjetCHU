﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.ServiceModel;
using System.Globalization;

namespace PilotageBras
{
    public partial class PilotageBras : Form
    {
        ServiceHost svh;
        SerialPort port_;
        List<float[]> Pos_ = new List<float[]>();
        int nPos_ = -1;
        bool ready_ = false;

        public PilotageBras()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(typeof(WCF.IServicePilotageBras), new NetTcpBinding(), "net.tcp://localhost:8001");
            svh.Open();
        }

        public void readFile(String fileName)
        {
            string line;
            StreamReader file = new System.IO.StreamReader(fileName);
            Pos_.Clear();

            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((line = file.ReadLine()) != null)
                {
                    itineraire.Items.Add(line);

                    var coord = line.Split('\t');

                    int i = 0;
                    for (i = 0; i < coord.Length - 1; i++)
                    {
                        var posx = coord[i].Split(',');
                        var posy = posx[1].Split(';');
                        var posz = posy[1];

                        float[] pos = new float[3];

                        pos[0] = float.Parse(posx[0], CultureInfo.InvariantCulture);
                        pos[1] = float.Parse(posy[0], CultureInfo.InvariantCulture);
                        pos[2] = float.Parse(posz, CultureInfo.InvariantCulture);

                        Pos_.Add(pos);
                    }
                }
            }            
        }

        public float[] getPos()
        {   
            if (nPos_ == -1)
            {
                return null;
            }
            else
            {
                return Pos_[nPos_];
            }
        }
        
        public bool setPos(int nPos)
        {
            ready_ = false;
            if (nPos > Pos_.Count)
            {
                nPos_ = -1;
                return false;
            }
            else
            {                
                nPos_ = nPos;
                byte[] trame = new byte[8];
                /* status
                trame[0] = (char)254;
                trame[1] = (char)0;
                trame[2] = (char)255;
                */
                
                int x = (int)(Pos_[nPos][0]);
                int y = (int)(Pos_[nPos][1]);
                int z = (int)(Pos_[nPos][2]);

                trame[0] = 254;
                trame[1] = 2;
                trame[2] = (byte)x;
                trame[3] = (byte)',';
                trame[4] = (byte)y;
                trame[5] = (byte)';';
                trame[6] = (byte)z;
                trame[7] = 255;

                if (port_ == null)
                {
                    return false;
                }
                else
                {
                    port_.Write(trame,0,8);
                    return true;
                }
            }
        }
        
        public int getNbPos()
        {
            return Pos_.Count;
        }      

        private void Xdec_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(positionX.Text) - float.Parse(interval.Text);
            string newX = temp.ToString();
            positionX.Text = newX;
        }

        private void Xinc_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(positionX.Text) + float.Parse(interval.Text);
            string newX = temp.ToString();
            positionX.Text = newX;
        }

        private void Ydec_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(positionY.Text) - float.Parse(interval.Text);
            string newY = temp.ToString();
            positionY.Text = newY;
        }

        private void Yinc_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(positionY.Text) + float.Parse(interval.Text);
            string newY = temp.ToString();
            positionY.Text = newY;
        }

        private void Zdec_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(positionZ.Text) - float.Parse(interval.Text);
            string newZ = temp.ToString();
            positionZ.Text = newZ;
        }

        private void Zinc_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(positionZ.Text) + float.Parse(interval.Text);
            string newZ = temp.ToString();
            positionZ.Text = newZ;
        }

        private void go_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int z = 0;

            bool validPos = false;
            ready_ = false;

            try
            {
                x = (int)(float.Parse(positionX.Text));
                y = (int)(float.Parse(positionY.Text));
                z = (int)(float.Parse(positionZ.Text));
                validPos = true;
            }
            catch
            {
                itineraire.Items.Add("Invalid position");
            }
            
            if (port_ != null && validPos)
            {
                byte[] trame = new byte[8];

                trame[0] = 254;
                trame[1] = 2;
                trame[2] = (byte)x;
                trame[3] = (byte)',';
                trame[4] = (byte)y;
                trame[5] = (byte)';';
                trame[6] = (byte)z;
                trame[7] = 255;

                port_.Write(trame, 0, 8);
            }
        }

        private void selectCOM(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            chooseCOM.DataSource = ports;
        }

        private void Connect(string portName)
        {
            port_ = new SerialPort(portName);

            // Attach a method to be called when there
            // is data waiting in the port's buffer
            port_.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //port_.DataBits

            if (!port_.IsOpen)
            {
                port_.BaudRate = 9600;
                port_.Open();
                //Continue here....
            }
        }

        private void choosenCom(object sender, EventArgs e)
        {
            //port_ = new SerialPort(chooseCOM.SelectedIndex.ToString());

        }

        private void readFileButton_click(object sender, EventArgs e)
        {
            String fileName = " ";

            OpenFileDialog fbd = new OpenFileDialog();
            //fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            //fbd.Description = "";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = fbd.FileName;
                readFile(fileName);
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

        public bool ready()
        {
            return ready_;
        }

        private void buttonSelectCom_Click(object sender, EventArgs e)
        {
            if (chooseCOM.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("You selected port '{0}'", chooseCOM.SelectedItem));
                Connect(chooseCOM.SelectedItem.ToString());
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
            if (buffer[0] == 80) // P
            {
                ready_ = true;
            }
        }

        [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
        class ServiceImplementation : WCF.IServicePilotageBras
        {
            PilotageBras ihm;
            public ServiceImplementation(PilotageBras f)
            {
                ihm = f;
            }

            public float getXPos()
            {
                return ihm.getPos()[0];
            }

            public float getYPos()
            {
                return ihm.getPos()[1];
            }

            public float getZPos()
            {
                return ihm.getPos()[2];
            }

            public bool setPos(int nPos)
            {
                return ihm.setPos(nPos);
            }

            public int getNbPos()
            {
                return ihm.getNbPos();
            }

            public void readFile(String fileName)
            {
                ihm.readFile(fileName);
            }

            public int getCurrentNPos()
            {
                return ihm.nPos_;
            }

            public bool getStatus()
            {
                return ihm.getStatus();
            }

            public bool ready()
            {
                return ihm.ready();
            }
        }

       
    }
}
  
           