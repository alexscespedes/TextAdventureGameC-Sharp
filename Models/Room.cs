namespace TextAdventureGame;

public class Room
{
    static int nextId;
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Dictionary<string, Room> Exits { get; set; }

    public List<Item> Items { get; set; }

    public List<NPC> NPCs { get; set; }

    public Room (string name, string description)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Description = description;
        Exits = new Dictionary<string, Room>();
        Items = new List<Item>();
        NPCs = new List<NPC>();
    }
    
    public void AddExit() { }

    public void RemoveItem() { }

    public void AddItem() { }

    public void GetAvailableExits() { }

}