using WcfDI.Infrastructure;
using WcfDI.Infrastructure.WcfContracts;

namespace WcfDI_CastleWindsor
{
    public class TestService : ITestService
    {
        private readonly IRepository _repo;

        public TestService(IRepository repo)
        {
            _repo = repo;
        }

        public string GetData()
        {
            return _repo.GetValue("Castle Windsor");
        }
    }
}
