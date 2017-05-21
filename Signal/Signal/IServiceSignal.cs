using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace WCF
{
    [ServiceContract]
    public interface IServiceSignal
    {
        [OperationContract]
        void valeurSignal(string path);
    }
}
