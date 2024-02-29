namespace Adapter.Example1
{
    public class Translator : ICommunication
    {
        private readonly SpanishSpeaker spanishSpeaker;

        public Translator(SpanishSpeaker spanishSpeaker)
        {
            this.spanishSpeaker = spanishSpeaker;
        }

        public string Ask(string question)
        {
            return this.spanishSpeaker.Pregunta(question);
        }

        public string Reply(string answer)
        {
            return this.spanishSpeaker.Respuesta(answer);
        }
    }
}
