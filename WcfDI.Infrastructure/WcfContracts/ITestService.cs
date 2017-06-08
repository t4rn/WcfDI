using System.ServiceModel;

namespace WcfDI.Infrastructure.WcfContracts
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        string GetData();
    }
}
