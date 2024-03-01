namespace Facade.Example1
{
    using System;

    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player turned on");
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine($"Playing movie '{movie}'");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player turned off");
        }
    }
}
