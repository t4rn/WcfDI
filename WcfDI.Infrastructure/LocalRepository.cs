namespace WcfDI.Infrastructure
{
    public class LocalRepository : IRepository
    {
        public string GetValue(string input)
        {
            return $"{input} rulez!";
        }
    }
}