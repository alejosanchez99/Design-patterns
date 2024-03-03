namespace Mediator.Example2
{
    using System.Collections.Generic;

    public class Tower : IAirTrafficControl
    {
        private List<Aircraft> aircrafts = new List<Aircraft>(0);

        public void RegisterAircraft(Aircraft aircraft)
        {
            if (!this.aircrafts.Contains(aircraft))
            {
                this.aircrafts.Add(aircraft);
            }
        }

        public void SendMessage(Aircraft sender, string message)
        {
            foreach (Aircraft aircraft in this.aircrafts)
            {
                if (aircraft != sender)
                {
                    aircraft.ReceiveMessage(message);
                }
            }
        }
    }
}
