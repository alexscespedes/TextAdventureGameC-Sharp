namespace TextAdventureGame;

public class GameState
{
    public Player Player { get; set; }

    public List<Room> AllRooms { get; set; }

    public Dictionary<string, bool> GameFlags { get; set; }

    public int Score { get; set; }

    public List<string> Inventory { get; set; }

    public GameState()
    {

    }

    public void SaveGame()
    {

    }

    public void LoadGame()
    {

    }
    
    public void CheckWinCondition()
    {
        
    }
}