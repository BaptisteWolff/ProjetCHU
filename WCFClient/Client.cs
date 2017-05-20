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
        string _folderPath = "";

        /* Picoscope */
        ChannelFactory<WCF.IServicePicoscope> picoChannel;
        WCF.IServicePicoscope pico;
        bool picoscopeModClient_ = false;

        /* Generateur */
        ChannelFactory<WCF.IServiceGenerateur> generateurChannel;
        WCF.IServiceGenerateur generateur;

        /* Pilotage bras */
        ChannelFactory<WCF.IServicePilotageBras> pilotageBrasChannel;
        WCF.IServicePilotageBras pilotageBras;
        float x, y, z;

        public FormClient()
        {
            /* Picoscope */
            InitializeComponent();
            picoChannel = new ChannelFactory<WCF.IServicePicoscope>(new NetTcpBinding(), "net.tcp://localhost:8002");
            pico = picoChannel.CreateChannel();

            buttonPicoCaptureBlock.Enabled = false;
            labelPicoFolder.Text = _folderPath;
            buttonPicoLock.Enabled = false;

            /* Generateur */
            generateurChannel = new ChannelFactory<WCF.IServiceGenerateur>(new NetTcpBinding(), "net.tcp://localhost:8000");
            generateur = generateurChannel.CreateChannel();

            /* PilotageBras */
            pilotageBrasChannel = new ChannelFactory<WCF.IServicePilotageBras>(new NetTcpBinding(), "net.tcp://localhost:8001");
            pilotageBras = pilotageBrasChannel.CreateChannel();

            x = 0;
            y = 0;
            z = 0;

            /* Client */
            listBox1.Items.Add("Please enter a storage location before capturing any Data");
            button_stop.Enabled = false;
            button_pause.Enabled = false;
        }

        private void buttonPicoPing_Click(object sender, EventArgs e)
        {
            bool response;
            try
            {
                response = pico.getStatus();
            } catch
            {
                response = false;
            }
            if (response)
            {
                listBox1.Items.Add("Picoscope is ready");
            } else {
                listBox1.Items.Add("Unable to detect the PicoScope");
            }
        }

        private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            (pico as ICommunicationObject).Close();
        }


        private void buttonPicoFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            //fbd.Description = "";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _folderPath = fbd.SelectedPath;
                buttonPicoLock.Enabled = true;
                labelPicoFolder.Text = _folderPath;
                changeSavedFileName();
            }
        }

        private void buttonPicoCaptureBlock_Click(object sender, EventArgs e)
        {
            pico.collectBlock();
            listBox1.Items.Add("Data saved");
        }

        private void changeSavedFileName()
        {
            if (pilotageBras.getNbPos() > 0)
            {
                x = pilotageBras.getXPos();
                y = pilotageBras.getYPos();
                z = pilotageBras.getZPos();
            }
            else
            {
                x = 0;
                y = 0;
                z = 0;
            }
            if (!System.IO.Directory.Exists(_folderPath + "\\" + z.ToString()))
            {
                System.IO.Directory.CreateDirectory(_folderPath + "\\" + z.ToString());
            }
            pico.setFileName(_folderPath + "\\" + z.ToString() + "\\" + x.ToString() + "_" + y.ToString() + ".csv");
        }

        private void buttonPicoSetMod_Click_1(object sender, EventArgs e)
        {
            if (pico.picoChangeMod())
            {
                if (picoscopeModClient_)
                {
                    picoscopeModClient_ = false;
                    listBox1.Items.Add("You can now adjust the settings of the picoscope");
                    buttonPicoCaptureBlock.Enabled = false;
                    buttonPicoLock.Text = "Lock server";
                }
                else
                {
                    picoscopeModClient_ = true;
                    listBox1.Items.Add("Picoscope is ready to capture Data");
                    buttonPicoCaptureBlock.Enabled = true;
                    buttonPicoLock.Text = "Unlock server";
                }
            }
            else
            {
                listBox1.Items.Add("Failed to set picoscope : please check the settings on the server.");
                buttonPicoCaptureBlock.Enabled = false;
            }
        }

        private void buttonPilotageBrasReadFile_Click(object sender, EventArgs e)
        {
            String fileName = " ";

            OpenFileDialog fbd = new OpenFileDialog();
            //fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            //fbd.Description = "";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = fbd.FileName;
                pilotageBras.readFile(fileName);
                textBoxPilotageBrasNPos.Text = "1";
                labelPilotageBrasReadFile.Text = fileName;
                if (setPos(0))
                {
                    changeSavedFileName();
                }
            }
        }

        private void buttonPilotageBrasGo_Click(object sender, EventArgs e)
        {
            int nPos = -1;
            try
            {
                nPos = Convert.ToInt32(textBoxPilotageBrasNPos.Text) - 1;
            }
            catch (Exception f)
            {
                listBox1.Items.Add("Error : Please enter an integer");
            }
            if (!setPos(nPos))
            {
                listBox1.Items.Add("Error : Invalid number.");
                textBoxPilotageBrasNPos.Text = pilotageBras.getCurrentNPos().ToString();
            }
            else
            {
                changeSavedFileName();
            }
        }

        private bool setPos(int nPos)
        {
            if (pilotageBras.getNbPos() > nPos && nPos >= 0)
            {
                pilotageBras.setPos(nPos);
                labelPilotageBrasNbPos.Text = "/ " + pilotageBras.getNbPos().ToString();
                labelPilotageBrasPosX.Text = "X = " + pilotageBras.getXPos().ToString();
                labelPilotageBrasPosY.Text = "Y = " + pilotageBras.getYPos().ToString();
                labelPilotageBrasPosZ.Text = "Z = " + pilotageBras.getZPos().ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Checking PicoScope");
            if (pico.getStatus() && setPico())
            {
                listBox1.Items.Add("Ready");
            } else
            {
                listBox1.Items.Add("! Not Ready");
            }
            listBox1.Items.Add("Checking Generateur");
            if (generateur.getStatus())
            {
                listBox1.Items.Add("Ready");
            }
            else
            {
                listBox1.Items.Add("! Not Ready");
            }
            listBox1.Items.Add("Checking PilotageBras");
            if (pilotageBras.getNbPos() > 0)
            {
                listBox1.Items.Add("Ready");
            }
            else
            {
                listBox1.Items.Add("! Not Ready");
            }
        }

        private bool setPico()
        {
            if (!picoscopeModClient_)
            {
                if (pico.picoChangeMod())
                {                    
                    picoscopeModClient_ = true;
                    buttonPicoCaptureBlock.Enabled = false;
                    buttonPicoLock.Enabled = true;
                    buttonPicoLock.Text = "Unlock server";
                    return true;
                }
                else
                {
                    listBox1.Items.Add("Failed to set picoscope : please check the settings on the server.");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

