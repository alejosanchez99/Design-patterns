namespace Adapter.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnglishSpeaker : ICommunication
    {
        public string Ask(string question)
        {
            return "Question in English: " + question;
        }

        public string Reply(string answer)
        {
            return "Answer in English" + answer;
        }
    }
}
