namespace Adapter.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Translator : ICommunication
    {
        private readonly SpanishSpeaker spanishSpeaker;

        public Translator(SpanishSpeaker spanishSpeaker)
        {
            this.spanishSpeaker = spanishSpeaker;
        }

        public string Ask(string question)
        {
            return spanishSpeaker.Pregunta(question);
        }

        public string Reply(string answer)
        {
            return spanishSpeaker.Respuesta(answer);
        }
    }
}
