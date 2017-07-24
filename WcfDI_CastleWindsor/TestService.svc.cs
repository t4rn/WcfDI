using WcfDI.Infrastructure;
using WcfDI.Infrastructure.WcfContracts;

namespace WcfDI_CastleWindsor
{
    public class TestService : ITestService
    {
        private readonly IValueService _valueSrv;

        public TestService(IValueService valueSrv)
        {
            _valueSrv = valueSrv;
        }

        public string GetData()
        {
            return _valueSrv.GetValue("Castle Windsor");
        }
    }
}
