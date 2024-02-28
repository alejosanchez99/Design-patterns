namespace Adapter.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SpanishSpeaker
    {
        public string Pregunta(string question)
        {
            return "Pregunta en español" + question;
        }

        public string Respuesta(string answer)
        {
            return "Respuesta en español" + answer;
        }
    }
}
