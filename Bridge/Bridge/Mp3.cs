namespace Bridge.Example1
{
    using System;

    public class Mp3 : IFormat
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing MP3 file {filePath}");
        }
    }
}
