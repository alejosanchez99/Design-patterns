namespace Bridge.Example2
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the petrol engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping the petrol engine");
        }
    }
}
