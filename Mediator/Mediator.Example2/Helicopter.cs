namespace Mediator.Example2
{
    public class Helicopter : Aircraft
    {
        public Helicopter(IAirTrafficControl tower, string name) : base(tower, name) { }
    }
}
