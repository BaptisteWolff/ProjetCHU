using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace TestWCFClient
{
    public partial class FormClient : Form
    {
        ChannelFactory<TestWCF.IService> scf;
        TestWCF.IService s;

        public FormClient()
        {
            InitializeComponent();
            scf = new ChannelFactory<TestWCF.IService>(new NetTcpBinding(), "net.tcp://localhost:8000");
            s = scf.CreateChannel();
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            string name = textBoxPing.Text;
            string response = s.Ping(name);
            listBox1.Items.Add(response);
        }

        private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            (s as ICommunicationObject).Close();
        }
    }
}
