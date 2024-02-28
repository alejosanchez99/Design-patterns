namespace Adapter.Example2
{
    public interface IDatabase
    {
        void Add(string data);

        string Retrieve();
    }
}
