namespace Adapter.Example2
{
    using System;

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
