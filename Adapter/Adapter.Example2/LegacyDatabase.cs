namespace Adapter.Example2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LegacyDatabase
    {
        public void InsertData(string data)
        {
            Console.WriteLine("Inserted data into legacy database: " + data);
        }

        public string GetData()
        {
            return "Data from legacy database";
        }
    }
}
