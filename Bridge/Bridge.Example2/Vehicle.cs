namespace Bridge.Example2
{
    public abstract class Vehicle
    {
        protected IEngine engine;

        protected Vehicle(IEngine engine)
        {
            this.engine = engine;
        }

        public abstract void Drive();
    }
}
