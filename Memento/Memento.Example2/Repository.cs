namespace Memento.Example2
{
    public class Repository
    {
        public string Code { get; set; }

        public Commit SaveState()
        {
            return new Commit(this.Code);
        }

        public void RestoreState(Commit memento)
        {
            this.Code = memento.Code;
        }
    }
}
