using Facade.Example1;

DvdPlayer dvdPlayer = new DvdPlayer();
Projector projector = new Projector();
Speaker speaker = new Speaker();

HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(dvdPlayer, projector, speaker);
homeTheaterFacade.WatchMovie("Inception");

Console.WriteLine("Wait two hours");

homeTheaterFacade.EndMovie();
