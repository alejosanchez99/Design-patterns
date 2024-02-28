namespace Adapter.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommunicationSystem
    {
        public void StartConversation(ICommunication communication, string question, string answer)
        {
            Console.WriteLine(communication.Ask(question));
            Console.WriteLine(communication.Reply(answer));
        }
    }
}
