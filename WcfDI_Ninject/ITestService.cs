using System.ServiceModel;

namespace WcfDI_Ninject
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        string GetData();
    }
}
