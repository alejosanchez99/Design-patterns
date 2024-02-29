namespace Adapter.Example1
{
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
