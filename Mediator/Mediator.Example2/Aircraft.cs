namespace Mediator.Example2
{
    using System;

    public abstract class Aircraft
    {
        protected IAirTrafficControl tower;
        protected string name;

        protected Aircraft(IAirTrafficControl tower, string name)
        {
            this.tower = tower;
            this.name = name;

            if (tower is Tower concreteTower)
            {
                concreteTower.RegisterAircraft(this);
            }
        }

        public void SendMessage(string message)
        {
            this.tower.SendMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{this.name} received message: {message}");
        }
    }
}
