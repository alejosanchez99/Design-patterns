namespace Adapter.Example2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DatabaseAdapter : IDatabase
    {
        private readonly LegacyDatabase legacyDatabase;

        public DatabaseAdapter(LegacyDatabase legacyDatabase)
        {
            this.legacyDatabase = legacyDatabase;
        }

        public void Add(string data)
        {
            legacyDatabase.InsertData(data);
        }

        public string Retrieve()
        {
            return legacyDatabase.GetData();
        }
    }
}
