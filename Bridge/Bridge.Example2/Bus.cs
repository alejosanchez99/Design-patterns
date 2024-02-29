namespace Bridge.Example2
{
    public class Bus : Vehicle
    {
        public Bus(IEngine engine) : base(engine) { }

        public override void Drive()
        {
            Console.WriteLine("Driving the bus");
            this.engine.Start();
        }
    }
}
