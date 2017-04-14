using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


namespace TestWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class ServiceImplementation2 : IService
    {
        #region IService Members
        static int number=0;
        int mynumber;

        public ServiceImplementation2() { mynumber =   ++number; }
        public string Ping(string name)
        {
            return "Hello, " + mynumber.ToString() + "  : "+ name;
        }

        #endregion
    }
}
