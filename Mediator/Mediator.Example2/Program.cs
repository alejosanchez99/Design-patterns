using Mediator.Example2;

IAirTrafficControl tower = new Tower();
Aircraft airplane1 = new Airplane(tower, "Airplane1");
Aircraft airplane2 = new Airplane(tower, "Airplane2");
Aircraft Helicopter1 = new Helicopter(tower, "Helicopter1");

airplane1.SendMessage("Hi everyone, i'm airplane number one");
airplane2.SendMessage("Hi everyone, i'm airplane number two");
Helicopter1.SendMessage("Hi everyone, i'm helicopter number one");