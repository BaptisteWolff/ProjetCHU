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
using System.Threading;

namespace WCFClient
{
    public partial class FormClient : Form
    {
        string folderPath_ = "";

        /* Picoscope */
        ChannelFactory<WCF.IServicePicoscope> picoChannel;
        WCF.IServicePicoscope pico;
        bool picoscopeModClient_ = false;
        string filePath_ = "";

        /* Generateur */
        ChannelFactory<WCF.IServiceGenerateur> generateurChannel;
        WCF.IServiceGenerateur generateur;

        /* Pilotage bras */
        ChannelFactory<WCF.IServicePilotageBras> pilotageBrasChannel;
        WCF.IServicePilotageBras pilotageBras;
        float x_, y_, z_;
        int nPos_, nbPos_;

        /* Signal */
        ChannelFactory<WCF.IServiceSignal> signalChannel;
        WCF.IServiceSignal signal;

        /* Client */
        PicoscopeThread picoscopeThread_;
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void addListBoxCallback(string text);
        delegate void setListBoxCallback(string text);
        RoutineThread routineThread_;
        bool pulseDone;

        public FormClient()
        {
            /* Picoscope */
            InitializeComponent();
            picoChannel = new ChannelFactory<WCF.IServicePicoscope>(new NetTcpBinding(), "net.tcp://localhost:8002");
            pico = picoChannel.CreateChannel();

            buttonPicoCaptureBlock.Enabled = false;
            labelPicoFolder.Text = folderPath_;
            buttonPicoLock.Enabled = false;            

            /* Generateur */
            generateurChannel = new ChannelFactory<WCF.IServiceGenerateur>(new NetTcpBinding(), "net.tcp://localhost:8000");
            generateur = generateurChannel.CreateChannel();

            /* PilotageBras */
            pilotageBrasChannel = new ChannelFactory<WCF.IServicePilotageBras>(new NetTcpBinding(), "net.tcp://localhost:8001");
            pilotageBras = pilotageBrasChannel.CreateChannel();

            x_ = 0;
            y_ = 0;
            z_ = 0;

            /* Signal */
            signalChannel = new ChannelFactory<WCF.IServiceSignal>(new NetTcpBinding(), "net.tcp://localhost:8003");
            signal = signalChannel.CreateChannel();

            /* Client */
            listBox1.Items.Add("Please enter a storage location before capturing any Data");
            picoscopeThread_ = new PicoscopeThread(this);
            routineThread_ = new RoutineThread(this);
            button_stop.Enabled = false;
        }

        private void buttonPicoPing_Click(object sender, EventArgs e)
        {
            bool response;
            try
            {
                response = pico.getStatus();
            }
            catch
            {
                response = false;
            }
            if (response)
            {
                listBox1.Items.Add("Picoscope is ready");
            }
            else
            {
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
                folderPath_ = fbd.SelectedPath;
                buttonPicoLock.Enabled = true;
                labelPicoFolder.Text = folderPath_;
                changeSavedFileName();

                signal.setPath(folderPath_);
            }
        }

        private void buttonPicoCaptureBlock_Click(object sender, EventArgs e)
        {
            pico.collectBlock();
            listBox1.Items.Add("Data saved");
        }

        public void captureBlock()
        {
            pico.collectBlock();
        }

        private void changeSavedFileName()
        {
            if (pilotageBras.getNbPos() > 0)
            {
                x_ = pilotageBras.getXPos();
                y_ = pilotageBras.getYPos();
                z_ = pilotageBras.getZPos();
            }
            else
            {
                x_ = 0;
                y_ = 0;
                z_ = 0;
            }
            if (!System.IO.Directory.Exists(folderPath_ + "\\" + z_.ToString()))
            {
                System.IO.Directory.CreateDirectory(folderPath_ + "\\" + z_.ToString());
            }
            filePath_ = folderPath_ + "\\" + z_.ToString() + "\\" + x_.ToString() + "_" + y_.ToString() + ".csv";
            pico.setFileName(filePath_);
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

        private bool setPosThreadSafe(int nPos)
        {
            if (pilotageBras.getNbPos() > nPos && nPos >= 0)
            {
                pilotageBras.setPos(nPos);
                return true;
            }
            else
            {
                return false;
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

        private void button_start_Click(object sender, EventArgs e)
        {
            bool ready = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("Checking PicoScope");
            if (pico.getStatus() && setPico())
            {
                listBox1.Items.Add("Ready");
            } else
            {
                listBox1.Items.Add("! Not Ready");
                ready = false;
            }
            listBox1.Items.Add("Checking Generateur");
            if (generateur.getStatus())
            {
                listBox1.Items.Add("Ready");
            }
            else
            {
                listBox1.Items.Add("! Not Ready");
                ready = false;
            }
            listBox1.Items.Add("Checking PilotageBras");
            if (pilotageBras.getNbPos() > 0 && pilotageBras.getStatus())
            {
                listBox1.Items.Add("Ready");
            }
            else
            {
                listBox1.Items.Add("! Not Ready");
                ready = false;
            }
            if (folderPath_ == null || folderPath_ == "")
            {
                listBox1.Items.Add("Please select the storage location");
                ready = false;
            }

            if (ready)
            {
                button_start.Enabled = false;
                button_stop.Enabled = true;
                routine();
            }
        }

        private void routine()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Starting...");
            listBox1.Items.Add("0/0");
            // Initialise to the first position (entered by the user)
            nPos_ = -1;
            try
            {
                nPos_ = Convert.ToInt32(textBoxPilotageBrasNPos.Text) - 1;
            }
            catch (Exception f)
            {
                nPos_ = 1;
                textBoxPilotageBrasNPos.Text = "1";
            }
            if (!setPos(nPos_))
            {
                nPos_ = 1;
                textBoxPilotageBrasNPos.Text = "1";
            }
            changeSavedFileName();
            pilotageBras.setPos(nPos_);
            nbPos_ = pilotageBras.getNbPos();

            // Main loop
            routineThread_.setStop(false);
            Thread t = new Thread(new ThreadStart(routineThread_.ThreadLoop));
            t.Start();
        }

        public void routineLoop()
        {            
            // PilotageBras
            if (!setPosThreadSafe(nPos_))
            {
                routineThread_.setStop(true);
                addListBoxThreadSafe("End ...");
            }
            else
            {
                setListBoxThreadSafe((nPos_ + 1) + "/" + nbPos_);

                // Picoscope               
                changeSavedFileName();
                picoscopeThread_.setEnd(false);
                Thread t = new Thread(new ThreadStart(picoscopeThread_.ThreadLoop));
                t.Start();

                pulseDone = false;

                // Générateur
                while (!picoscopeThread_.getEnd() || !pulseDone)
                {
                    // send pulse, while picoscope as not yet captured data
                    generateur.pulse();
                    pulseDone = true;
                    Thread.Sleep(100);
                    if (!picoscopeThread_.getEnd())
                    {
                        pulseDone = false;
                    }
                }

                // Signal
                signal.addPos(x_, y_, z_);
                signal.valeurSignal(filePath_);

                nPos_++;
            }
        }

        public bool getPulseDone()
        {
            return pulseDone;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            routineThread_.setStop(true);
            while(routineThread_.getStop())
            {
                Thread.Sleep(100);
            }
            listBox1.Items.Add("Stopped by the user.");
            button_stop.Enabled = false;
            button_start.Enabled = true;
            setPos(nPos_);
        }

        public void addListBoxThreadSafe(string text)
        {
            addListBox(text);
        }


        private void addListBox(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBox1.InvokeRequired)
            {
                addListBoxCallback d = new addListBoxCallback(addListBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                listBox1.Items.Add(text);
            }
        }

        public void setListBoxThreadSafe(string text)
        {
            setListBox(text);
        }


        private void setListBox(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBox1.InvokeRequired)
            {
                setListBoxCallback d = new setListBoxCallback(setListBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                listBox1.Items.Add(text);
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

