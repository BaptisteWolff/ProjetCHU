using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace WCF
{
    [ServiceContract]
    public interface IServicePicoscope
    {
        [OperationContract]
        bool Ping();
        [OperationContract]
        bool picoGetStatus();
        [OperationContract]
        void setFileName(string filename);
        [OperationContract]
        void collectBlock();
    }

}
