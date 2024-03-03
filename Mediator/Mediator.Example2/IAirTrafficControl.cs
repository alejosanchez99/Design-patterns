namespace Mediator.Example2
{
    public interface IAirTrafficControl
    {
        void SendMessage(Aircraft sender, string message);
    }
}
