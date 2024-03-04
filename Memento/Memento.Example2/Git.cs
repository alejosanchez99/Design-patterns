namespace Memento.Example2
{
    public class Git
    {
        private readonly List<Commit> savedStates = new List<Commit>(0);

        public void Commit(Repository repository)
        {
            this.savedStates.Add(repository.SaveState());
        }

        public void Revert(Repository repository)
        {
            if (this.savedStates.Any())
            {
                Commit lastState = this.savedStates[this.savedStates.Count - 2];

                repository.RestoreState(lastState);

                this.savedStates.Remove(lastState);
            }
        }
    }
}
