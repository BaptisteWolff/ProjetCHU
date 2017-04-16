using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Net;

namespace WCFClient
{
    public partial class FormClient : Form
    {

        ChannelFactory<WCF.IService> scf;
        WCF.IService s;

        public FormClient()
        {
            InitializeComponent();
            scf = new ChannelFactory<WCF.IService>(new NetTcpBinding(), "net.tcp://localhost:8002");
            s = scf.CreateChannel();
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            bool response;
            try
            {
                response = s.Ping();
            } catch
            {
                response = false;
            }
            listBox1.Items.Add(response);
        }

        private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            (s as ICommunicationObject).Close();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPing_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPicoCommand_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Picoscope is capturing the data ... ...");
            bool success = s.picoCommand(textBoxPicoCommand.Text);
            if (success) { listBox1.Items.Add("Done."); }
            else { listBox1.Items.Add("Failed."); }
        }
    }
}

