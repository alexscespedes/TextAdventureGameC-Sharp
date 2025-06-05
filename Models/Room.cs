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

    public Room(string name, string description)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Description = description;
        Exits = new Dictionary<string, Room>();
        Items = new List<Item>();
        NPCs = new List<NPC>();
    }

    public void AddExit(string direction, Room room)
    {
        Exits.Add(direction, room);
    }

    public void RemoveExit(string direction)
    {
        Exits.Remove(direction);
    }

    public Room? GetExit(string direction)
    {
        return Exits.ContainsKey(direction) ? Exits[direction] : null;
    }

    public void GetAvailableExits()
    {
        foreach (var e in Exits)
        {
            Console.WriteLine($"Direction: {e.Key}, Room: {e.Value.Name}");
        }
    }

    public void HasExit(string direction)
    {
        if (!Exits.ContainsKey(direction))
        {
            Console.WriteLine($"The direction: {direction} is not valid");
            return;
        }
        Console.WriteLine($"Direction: {direction} exits!");
    }

    public void RemoveItem() { }

    public void AddItem() { }


}