namespace WcfDI.Infrastructure
{
    public class ValueService : IValueService
    {
        private readonly IRepository _repo;

        public ValueService(IRepository repo)
        {
            _repo = repo;
        }

        public string GetValue(string input)
        {
            string repoResult = _repo.GetValue();
            return $"{input} is the best! {repoResult}";
        }
    }
}
