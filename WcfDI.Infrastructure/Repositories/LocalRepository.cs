namespace WcfDI.Infrastructure
{
    public class LocalRepository : IRepository
    {
        private readonly string _connStr;

        public LocalRepository(string connectionString)
        {
            _connStr = connectionString;
        }

        public string GetValue()
        {
            return $"ConnectionString: {_connStr}.";
        }
    }
}