namespace Adapter.Example1
{
    using System;

    public class CommunicationSystem
    {
        public void StartConversation(ICommunication communication, string question, string answer)
        {
            Console.WriteLine(communication.Ask(question));
            Console.WriteLine(communication.Reply(answer));
        }
    }
}
