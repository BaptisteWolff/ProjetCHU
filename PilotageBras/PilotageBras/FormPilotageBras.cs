using System;
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

                        //float taille = coord[i].Length;
                        //string trame = "254" + "1001" + taille.ToString() + coord[i];             

                        var posx = coord[i].Split(',');
                        var posy = posx[1].Split(';');
                        var posz = posy[1];

                        float[] pos = new float[3];
                        pos[0] = float.Parse(posx[0], CultureInfo.InvariantCulture);
                        pos[1] = float.Parse(posy[0], CultureInfo.InvariantCulture);
                        pos[2] = float.Parse(posz, CultureInfo.InvariantCulture);
                        Pos_.Add(pos);

                        //port_.WriteLine(trame);


                    }


                }
            }

            setPos(0);
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
            if (nPos > Pos_.Count)
            {
                nPos_ = -1;
                return false;
            }
            else
            {
                nPos_ = nPos;
                string coord = Pos_[nPos][0].ToString() + ',' + Pos_[nPos][1].ToString() + ';' + Pos_[nPos][2].ToString();
                float taille = coord.Length;
                string trame = "FE" + "1001" + taille.ToString() + coord;
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
            float x = float.Parse(positionX.Text);
            //float tailleX = x.size(); ;

            float y = float.Parse(positionY.Text);
            //float tailleY = sizeof(y);

            float z = float.Parse(positionZ.Text);
            //float tailleZ = sizeof(z);


            //float taille = tailleX + tailleY + tailleZ;

            //string trame = "254" + "1001" + taille.ToString() + float.Parse(positionX.Text) + "," + float.Parse(positionY.Text) + ";" + float.Parse(positionZ.Text);
            //port.WriteLine(trame);
        }

        private void selectCOM(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                chooseCOM.Items.Add(port);
            }
        }

        private void choosenCom(object sender, EventArgs e)
        {
            port_ = new SerialPort(chooseCOM.SelectedIndex.ToString());

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
        }
    }
}
  
           