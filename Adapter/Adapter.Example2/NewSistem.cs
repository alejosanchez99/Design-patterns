namespace Adapter.Example2
{
    public class NewSistem
    {
        private readonly IDatabase database;

        public NewSistem(IDatabase database)
        {
            this.database = database;
        }

        public void SaveDate(string data)
        {
            this.database.Add(data);
            Console.WriteLine("Data saved in the new system.");
        }

        public void LoadData()
        {
            string data = this.database.Retrieve();
            Console.WriteLine("Data loaded in the new system: " + data);
        }
    }
}
