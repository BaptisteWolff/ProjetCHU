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
        [OperationContract]
        void addPos(float x, float y, float z);
        [OperationContract]
        void setPath(string path);
        [OperationContract]
        void clearResults();
        [OperationContract]
        void mapping();
    }
}
