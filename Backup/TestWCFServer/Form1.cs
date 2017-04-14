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

namespace TestWCFServer
{
    public partial class FormServeur : Form
    {
        [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
        class ServiceImplementation : TestWCF.IService
        {
            FormServeur ihm;
            public ServiceImplementation(FormServeur f)
            {
                ihm = f;
            }

            public string Ping(string name)
            {
                string ip = (OperationContext.Current.IncomingMessageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty).Address;
                ihm.listBox1.Items.Add(name + " is calling from " + ip);
                return "Hello, " + name;
            }
        }

        ServiceHost svh; 

        public FormServeur()
        {
            InitializeComponent();
            svh = new ServiceHost(new ServiceImplementation(this));
            svh.AddServiceEndpoint(
                typeof(TestWCF.IService),
                new NetTcpBinding(),
                "net.tcp://localhost:8000");
            svh.Open();
            

        }
    }
}
