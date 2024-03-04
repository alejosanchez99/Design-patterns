namespace Memento.Example1
{
    using System.Collections.Generic;

    public class GameSaveManager
    {
        private readonly List<GameMemento> saves = new List<GameMemento>(0);

        public void SaveGame(Game game)
        {
            this.saves.Add(game.SaveGame());
        }

        public void LoadGame(Game game, int saveSlot)
        {
            game.LoadGame(this.saves[saveSlot]);
        }
    }
}
