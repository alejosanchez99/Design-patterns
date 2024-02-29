namespace Adapter.Example2
{
    public class DatabaseAdapter : IDatabase
    {
        private readonly LegacyDatabase legacyDatabase;

        public DatabaseAdapter(LegacyDatabase legacyDatabase)
        {
            this.legacyDatabase = legacyDatabase;
        }

        public void Add(string data)
        {
            this.legacyDatabase.InsertData(data);
        }

        public string Retrieve()
        {
            return this.legacyDatabase.GetData();
        }
    }
}
