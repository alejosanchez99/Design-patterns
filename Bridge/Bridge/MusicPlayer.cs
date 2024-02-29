namespace Bridge.Example1
{
    public abstract class MusicPlayer
    {
        protected IFormat format;

        protected MusicPlayer(IFormat format)
        {
            this.format = format;
        }

        public abstract void Play(string filePath);
    }
}
