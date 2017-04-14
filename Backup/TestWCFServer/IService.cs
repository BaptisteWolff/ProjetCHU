using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace TestWCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Ping(string name);
    }

}
