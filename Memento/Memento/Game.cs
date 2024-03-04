namespace Memento.Example1
{
    public class Game
    {
        public GameState CurrentState { get; set; }

        public GameMemento SaveGame()
        {
            return new GameMemento(this.CurrentState);
        }

        public void LoadGame(GameMemento gameMemento)
        {
            this.CurrentState = gameMemento.GameState;
        }
    }
}
