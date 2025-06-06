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

    // Connection/Exit Methods
    public void AddExit(string direction, Room room)
    {
        if (Exits.ContainsKey(direction) && Exits.ContainsValue(room))
        {
            Console.WriteLine($"The connection: [{direction} - {room.Name}] is already in the Connection/Exit Dictionary");
            return;
        }
        Exits.Add(direction, room);
        Console.WriteLine($"Connection added successfully");
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

    // Item Management Methods

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        var itemRemove = Items.SingleOrDefault(i => i.Id == item.Id);

        if (itemRemove != null)
        {
            Items.Remove(itemRemove);
            return;
        }
        Console.WriteLine("No item to delete has been found.");
    }

    public void RemoveItemByName(string itemName)
    {
        var itemRemove = Items.SingleOrDefault(i => i.Name == itemName);

        if (itemRemove != null)
        {
            Items.Remove(itemRemove);
            return;
        }
        Console.WriteLine("No item to delete has been found.");
    }

    public void HasItem(string itemName)
    {
        if (string.IsNullOrEmpty(itemName))
        {
            Console.WriteLine("Name cannot be empty");
            return;
        }

        var itemMatched = Items.SingleOrDefault(item => item.Name.Contains(itemName.Trim(), StringComparison.InvariantCultureIgnoreCase))!;

        if (itemMatched != null)
        {
            Console.WriteLine(itemMatched.Name);
            return;
        }
        Console.WriteLine($"Item not found in Room: {Name}");

    }

    public Item GetItem(string itemName)
    {
        var item = Items.SingleOrDefault(item => item.Name == itemName);

        if (item == null)
        {
            Console.WriteLine("No item has been found.");
            return null!;
        }
        return item;

    }

    // NPC Management Methods

    public void AddNPC(NPC npc)
    {
        NPCs.Add(npc);
    }

    public void RemoveNPC(NPC npc)
    {
        var npcRemove = NPCs.SingleOrDefault(i => i.Id == npc.Id);

        if (npcRemove != null)
        {
            NPCs.Remove(npcRemove);
            return;
        }
        Console.WriteLine("No NPC to delete has been found.");
    }

    public void HasNPC(string npcName)
    {
        if (string.IsNullOrEmpty(npcName))
        {
            Console.WriteLine("Name cannot be empty");
            return;
        }

        var npcMatched = NPCs.SingleOrDefault(npc => npc.Name.Contains(npcName.Trim(), StringComparison.InvariantCultureIgnoreCase))!;

        if (npcMatched != null)
        {
            Console.WriteLine(npcMatched.Name);
            return;
        }
        Console.WriteLine($"NPC not found in Room: {Name}");

    }

    public NPC GetNPC(string npcName)
    {
        var npc = NPCs.SingleOrDefault(npc => npc.Name == npcName);

        if (npc == null)
        {
            Console.WriteLine("No item has been found.");
            return null!;
        }
        return npc;

    }

    // Display Methods

    public void GetFullDescription()
    {
        if (Exits.Count == 0 || Items.Count == 0 || NPCs.Count == 0)
        {
            Console.WriteLine($"Room: has any of the lists empty.");
            return;
        }

        Console.WriteLine($"Room Description: {Description}");

        foreach (var e in Exits)
        {
            Console.WriteLine($"Exit direction: {e.Key} | Exit Room: {e.Value.Name}");
        }

        foreach (var i in Items)
        {
            Console.WriteLine($"Item Name: {i.Name} | Item Description: {i.Description}");
        }
        
        foreach (var npc in NPCs)
        {
            Console.WriteLine($"Item Name: {npc.Name} | Item Description: {npc.Description}");
        }
       
    }
}