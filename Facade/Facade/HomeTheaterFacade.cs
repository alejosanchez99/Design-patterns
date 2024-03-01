namespace Facade.Example1
{
    using System;

    public class HomeTheaterFacade
    {
        private readonly DvdPlayer dvdPlayer;
        private readonly Projector projector;
        private readonly Speaker speaker;

        public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, Speaker speaker)
        {
            this.dvdPlayer = dvdPlayer;
            this.projector = projector;
            this.speaker = speaker;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie..");

            this.projector.On();
            this.speaker.On();
            this.dvdPlayer.On();
            this.dvdPlayer.PlayMovie(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");

            this.projector.Off();
            this.speaker.Off();
            this.dvdPlayer.Off();
        }
    }
}
