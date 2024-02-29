namespace Adapter.Example1
{
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
