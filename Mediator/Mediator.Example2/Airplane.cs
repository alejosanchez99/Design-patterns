namespace Mediator.Example2
{
    public class Airplane : Aircraft
    {
        public Airplane(IAirTrafficControl tower, string name) : base(tower, name) { }
    }
}
