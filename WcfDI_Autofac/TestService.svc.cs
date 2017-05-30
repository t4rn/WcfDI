using WcfDI.Infrastructure;

namespace WcfDI_Autofac
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
            return _repo.GetValue("Autofac");
        }
    }
}
