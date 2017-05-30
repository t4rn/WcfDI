using System.ServiceModel;

namespace WcfDI_Autofac
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        string GetData();
    }
}
