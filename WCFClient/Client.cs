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

        ChannelFactory<WCF.IServicePicoscope> picoChannel;
        WCF.IServicePicoscope pico;
        double x, y, z;

        public FormClient()
        {
            InitializeComponent();
            picoChannel = new ChannelFactory<WCF.IServicePicoscope>(new NetTcpBinding(), "net.tcp://localhost:8002");
            pico = picoChannel.CreateChannel();

            x = 0;
            y = 0;
            z = 0;

            buttonPicoCaptureBlock.Enabled = false;
        }

        private void buttonPicoPing_Click(object sender, EventArgs e)
        {
            bool response;
            try
            {
                response = pico.Ping();
            } catch
            {
                response = false;
            }
            listBox1.Items.Add(response);
        }

        private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            (pico as ICommunicationObject).Close();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPicoCaptureBlock_Click(object sender, EventArgs e)
        {
            pico.collectBlock();
            listBox1.Items.Add("Data saved");
            buttonPicoCaptureBlock.Enabled = false;
        }

        private void buttonPicoGetStatus_Click_1(object sender, EventArgs e)
        {
            pico.setFileName(textBoxPicoFolder.Text + z.ToString() + x.ToString() + y.ToString() + ".csv");
            if (pico.picoGetStatus())
            {
                listBox1.Items.Add("Picoscope is ready");
                buttonPicoCaptureBlock.Enabled = true;
            }
            else
            {
                listBox1.Items.Add("Failed : please check the settings on the server.");
                buttonPicoCaptureBlock.Enabled = false;
            }
        }
        
        private void textBoxPicoFolder_TextChanged(object sender, EventArgs e)
        {
            buttonPicoCaptureBlock.Enabled = false;
        }
    }
}

