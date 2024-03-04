namespace Memento.Example1
{
    public class GameMemento
    {
        public GameState GameState { get; private set; }

        public GameMemento(GameState gameState)
        {
            this.GameState = gameState;
        }
    }
}
