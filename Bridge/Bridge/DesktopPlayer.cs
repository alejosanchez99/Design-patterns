namespace Bridge.Example1
{
    using System;

    public class DesktopPlayer : MusicPlayer
    {
        public DesktopPlayer(IFormat format) : base(format) { }

        public override void Play(string filePath)
        {
            Console.WriteLine($"Using Desktop Player");

            this.format.Play(filePath);
        }
    }
}
