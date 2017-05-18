using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
