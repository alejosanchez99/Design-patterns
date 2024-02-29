namespace Bridge.Example1
{
    using System;

    public class MobilePlayer : MusicPlayer
    {
        public MobilePlayer(IFormat format) : base(format) { }

        public override void Play(string filePath)
        {
            Console.WriteLine($"Using Mobile Player");

            this.format.Play(filePath);
        }
    }
}
