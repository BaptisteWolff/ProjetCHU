﻿using System;
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
        bool getStatus();
        [OperationContract]
        bool picoChangeMod();
        [OperationContract]
        void setFileName(string filename);
        [OperationContract]
        void collectBlock();
    }
}
