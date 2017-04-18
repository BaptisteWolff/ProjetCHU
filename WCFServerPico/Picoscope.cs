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
using PS3000ACSConsole;

namespace WCFServer
{
    public partial class FormServeurPicoscope : Form
    {
        

        [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
        class ServiceImplementation : WCF.IServicePicoscope
        {
            FormServeurPicoscope ihm;
            public ServiceImplementation(FormServeurPicoscope f)
            {
                ihm = f;
            }

            public bool Ping()
            {
                return true;
            }

            public bool picoGetStatus()
            {
                return ihm.getSettingsStatus();
            }

            public void setFileName(string fileName)
            {
                ihm.setFileName(fileName);
            }

            public void collectBlock()
            {
                ihm.collectBlock();
            }
        }

        ServiceHost svh;
        PS3000ACSConsole.PS3000ACSConsole _pico;

        uint[] _range;
        /*
        3 . 100 mV
        4 . 200 mV
        5 . 500 mV
        6 . 1000 mV
        7 . 2000 mV
        8 . 5000 mV
        9 . 10000 mV
        10 . 20000 mV
        99 - switches channel off
        */
        String[] _trackbarValues;

        public FormServeurPicoscope()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(typeof(WCF.IServicePicoscope), new NetTcpBinding(), "net.tcp://localhost:8002");
            svh.Open();
            _pico = new PS3000ACSConsole.PS3000ACSConsole();
            _range = new uint[4];

            _trackbarValues = new String[]{ " Off  ", "100 mV", "200 mV", "500 mV", "  1  V", "  2  V", "  5  V", " 10  V", " 20  V"};
            _range[0] = trackBarToRange(trackBarChA.Value);
            _range[1] = trackBarToRange(trackBarChB.Value);
            _range[2] = trackBarToRange(trackBarChC.Value);
            _range[3] = trackBarToRange(trackBarChD.Value);
            labelChA.Text = _trackbarValues[trackBarChA.Value];
            labelChB.Text = _trackbarValues[trackBarChB.Value];
            labelChC.Text = _trackbarValues[trackBarChC.Value];
            labelChD.Text = _trackbarValues[trackBarChD.Value];

            setPico();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonImmediateBlock_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Immediate Block ...");
            collectBlock();
            listBox1.Items.Add("Done.");
        }

        /* Set PicoScope */
        private bool setPico()
        {
            /* Set sample count */
            int sampleCount = 0;
            try
            {
                sampleCount = 2 * Convert.ToInt32(textBoxSampleCount.Text);

            }
            catch (Exception e)
            {
            }
            if (sampleCount <= 0)
            {
                listBox1.Items.Add("Error : invalid number of samples");
                return false;
            }

            /* Set timebase */
            string period = textBoxSetPeriod.Text;
            uint timebase;
            // T(ns) = (timebase-2) * 8 for timebase > 2
            // T(ns) = 4 for timebase = 2
            try
            {
                timebase = toTimeBase(Convert.ToUInt32(period));
            }
            catch (Exception f)
            {
                listBox1.Items.Add("Error : invalid period.");
                return false;
            }
            // Display the information of the new timebase to the user
            period = toPeriod(timebase).ToString();
            textBoxSetPeriod.Text = period;

            /* Set filename */
            string filename = textBoxFileName.Text;

            _pico.setPico(timebase, sampleCount, filename, _range);
            buttonSetPico.Enabled = false;
            return true;
        }

        public void setFileName(string fileName)
        {
            _pico.SetFilename(fileName);
        }

        /* Capture data from PicoScope */
        public void collectBlock()
        {
            _pico.CollectBlockImmediate();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormServeur_Load(object sender, EventArgs e)
        {

        }


        /* Convert the period in ns to the timebase */
        private uint toTimeBase(uint period)
        {
            // Round down
            uint timebase = (uint)Math.Floor((decimal)period / 8) + 2;
            return timebase;
        }

        /* Convert the timebase to the period in ns */
        private uint toPeriod(uint timeBase)
        {
            uint period = (timeBase - 2) * 8;
            if (period == 0) { period = 4; }
            return (period);
        }

        private void buttonSetPico_Click(object sender, EventArgs e)
        {
            if(setPico())
            {
                buttonImediateBlock.Enabled = true;
            }
        }

        private uint trackBarToRange(int tValue)
        {
            if (tValue != 0) { return (uint)tValue + 2; }
            else { return 99; } // switches channel off
            
        }

        private void trackBarChA_Scroll(object sender, EventArgs e)
        {
            int tValue = trackBarChA.Value;
            _range[0] = trackBarToRange(tValue);
            labelChA.Text = _trackbarValues[tValue];
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        private void trackBarChB_Scroll(object sender, EventArgs e)
        {
            int tValue = trackBarChB.Value;
            _range[1] = trackBarToRange(tValue);
            labelChB.Text = _trackbarValues[tValue];
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        private void trackBarChC_Scroll(object sender, EventArgs e)
        {
            int tValue = trackBarChC.Value;
            _range[2] = trackBarToRange(tValue);
            labelChC.Text = _trackbarValues[tValue];
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        private void trackBarChD_Scroll(object sender, EventArgs e)
        {
            int tValue = trackBarChD.Value;
            _range[3] = trackBarToRange(tValue);
            labelChD.Text = _trackbarValues[tValue];
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        private void textBoxSetPeriod_TextChanged(object sender, EventArgs e)
        {
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        private void textBoxSampleCount_TextChanged(object sender, EventArgs e)
        {
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            buttonImediateBlock.Enabled = false;
            buttonSetPico.Enabled = true;
        }

        public bool getSettingsStatus()
        {
            return buttonImediateBlock.Enabled;
        }
    }
}
