using Memento.Example1;

Game game = new Game();
GameSaveManager gameSaveManager = new GameSaveManager();

game.CurrentState = new GameState
{
    Level = 3,
    Health = 100,
    Weapon = "Sword"
};

Console.WriteLine($"Player reached level: {game.CurrentState.Level}");

gameSaveManager.SaveGame(game);

Console.WriteLine("Game saved.");

game.CurrentState = new GameState { Level = 5, Health = 80, Weapon = "Sword" };
Console.WriteLine($"Player reached level: {game.CurrentState.Level}");

gameSaveManager.LoadGame(game, 0);
Console.WriteLine($"Game loaded. Player is back at level: {game.CurrentState.Level}");