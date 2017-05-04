using System;
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
        public Form1()
        {
            InitializeComponent();
          
            
        }

        public void readFile(String fileName){

          

        }

        public float[, ,] getPos()
        {
            float[, ,] trame = new float[0,0,0];
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

        }

        private void selectCOM(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                chooseCOM.Items.Add(port);
            }
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
  
           