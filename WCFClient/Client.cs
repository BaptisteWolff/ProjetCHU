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
        bool _picoscopeMod = false;
        string _folderPath = "";

        public FormClient()
        {
            InitializeComponent();
            picoChannel = new ChannelFactory<WCF.IServicePicoscope>(new NetTcpBinding(), "net.tcp://localhost:8002");
            pico = picoChannel.CreateChannel();

            x = 0;
            y = 0;
            z = 0;

            buttonPicoCaptureBlock.Enabled = false;
            labelPicoFolder.Text = _folderPath;
            buttonPicoSetPicoscopeMod.Enabled = false;
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

        private void buttonPicoFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            //fbd.Description = "";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _folderPath = fbd.SelectedPath;
                buttonPicoSetPicoscopeMod.Enabled = true;
                labelPicoFolder.Text = _folderPath;
                changeFileName();
            }
        }

        private void buttonPicoCaptureBlock_Click(object sender, EventArgs e)
        {
            pico.collectBlock();
            listBox1.Items.Add("Data saved");
        }

        private void changeFileName()
        {
            if (!System.IO.Directory.Exists(_folderPath + "\\" + z.ToString()))
            {
                System.IO.Directory.CreateDirectory(_folderPath + "\\" + z.ToString());
            }
            pico.setFileName(_folderPath + "\\" + z.ToString() + "\\" + x.ToString() + y.ToString() + ".csv");
        }

        private void buttonPicoSetMod_Click_1(object sender, EventArgs e)
        {
            if (pico.picoChangeMod())
            {
                if (_picoscopeMod)
                {
                    _picoscopeMod = false;
                    listBox1.Items.Add("You can now adjust the settings of the picoscope");
                }
                else
                {
                    _picoscopeMod = true;
                    listBox1.Items.Add("Picoscope is ready to capture Data");
                    buttonPicoCaptureBlock.Enabled = true;
                }
            }
            else
            {
                listBox1.Items.Add("Failed to set picoscope : please check the settings on the server.");
                buttonPicoCaptureBlock.Enabled = false;
            }
        }
    }
}

