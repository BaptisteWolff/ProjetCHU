using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace WCF
{
    [ServiceContract]
    public interface IServicePilotageBras
    {
        [OperationContract]
        float getXPos();
        [OperationContract]
        float getYPos();
        [OperationContract]
        float getZPos();
        [OperationContract]
        bool setPos(int nPos);
        [OperationContract]
        int getNbPos();
        [OperationContract]
        void readFile(System.String fileName);
        [OperationContract]
        int getCurrentNPos();
        [OperationContract]
        bool getStatus();
        [OperationContract]
        bool ready();
    }
}
