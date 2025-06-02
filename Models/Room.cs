namespace TextAdventureGame;

public class Room
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Dictionary<string, Room> Exits { get; set; }

    public List<Item> Items { get; set; }

    public List<NPC> NPCs { get; set; }

    public Room ()
    {

    }
    
    public void AddExit() { }

    public void RemoveItem() { }

    public void AddItem() { }

    public void GetAvailableExits() { }

}