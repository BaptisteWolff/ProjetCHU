using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace WCF
{
    [ServiceContract]
    public interface IServiceGenerateur
    {
        [OperationContract]
        bool getStatus();
        [OperationContract]
        void pulse();
        [OperationContract]
        bool ready();
        [OperationContract]
        bool success();
        [OperationContract]
        void preparation();
    }
}
