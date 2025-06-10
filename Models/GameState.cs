namespace TextAdventureGame;

public class GameState
{
    public Player Player { get; set; }

    public List<Room> AllRooms { get; set; }

    public int Score { get; set; } = 0;

    public bool IsGameOver { get; set; } = false;

    public GameState(Player player)
    {
        Player = player;
        AllRooms = new List<Room>();
    }

    public bool IsRunning()
    {
        if (IsGameOver)
        {
            EndGame();
            return false;
        }
        return true;
    }

    public void EndGame()
    {
        IsGameOver = true;
    }

    // Save/Load will be completed at the end

    public void SaveGame() {}
    public void LoadGame() {}

    public void InitializeGame(Room room, Item item, NPC nPC)
    {
        AllRooms.Add(room);
        room.AddItem(item);
        room.AddNPC(nPC);
    }
}