namespace Bridge.Example2
{
    public class Car : Vehicle
    {
        public Car(IEngine engine) : base(engine) { }

        public override void Drive()
        {
            Console.WriteLine("Driving the car");
            this.engine.Start();
        }
    }
}
