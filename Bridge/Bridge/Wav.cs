namespace Bridge.Example1
{
    using System;

    public class Wav : IFormat
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing WAV file {filePath}");
        }
    }
}