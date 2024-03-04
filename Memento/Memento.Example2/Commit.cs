namespace Memento.Example2
{
    public class Commit
    {
        public string Code { get; private set; }

        public Commit(string code)
        {
            this.Code = code;
        }
    }
}
