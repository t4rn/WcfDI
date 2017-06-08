using WcfDI.Infrastructure;
using WcfDI.Infrastructure.WcfContracts;

namespace WcfDI_Ninject
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
            return _repo.GetValue("Ninject");
        }
    }
}
