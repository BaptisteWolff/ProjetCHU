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



namespace PilotageBras
{
    public partial class Form1 : Form
    {
        SerialPort port;
        float[] trame = new float[3];

        public Form1()
        {
            InitializeComponent();
           // port.Open();
              
        }
     

        public void readFile(String fileName){
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);

            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((line = file.ReadLine()) != null)
                {
                 
                    itineraire.Items.Add(line);

                    var coord = line.Split('\t');

                    int i = 0;
                    for (i = 0; i < coord.Length; i++)
                    {

                        float taille = coord[i].Length;
                        string trame = "254" + "1001" + taille.ToString() + coord[i];

                        var posx= coord[i].Split(',');
                        var posy= posx[2].Split(';');
                        var posz= posy[1];

                        trame[1]=float.Parse(posx[0]);

                        port.WriteLine(trame);


                    }


                }
            }

     } 
          

        

        public float[] getPos()
        {
            
            return trame;
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
            port = new SerialPort(chooseCOM.SelectedIndex.ToString());

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

            }

            readFile(fileName);


        }

    
                
    }
}
  
           