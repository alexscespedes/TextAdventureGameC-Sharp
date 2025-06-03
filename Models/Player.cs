namespace TextAdventureGame;

public class Player
{
    static int nextId;
    public int Id { get; private set; }
    public string Name { get; }
    public int Health { get; set; } = 100;
    public Room CurrentRoom { get; set; }
    public List<Item> Inventory { get; set; }
    public bool IsAlive { get; set; } = true;



    public Player(string name)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Inventory = new List<Item>();
        // CurrentRoom = currentRoom;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
            IsAlive = false;
        }
    }

    public void Heal(int amount)
    {
        Health += amount;

        if (Health >= 100)
        {
            Console.WriteLine($" Player: [{Id}] - {Name} already has maximum health (100)");
            return;
        }
    }

    public void AddToInventory(Item item)
    {
        if (Inventory.Count > 25)
        {
            Console.WriteLine($"The  inventory of player {Name} is full of capacity");
            return;
        }

        var itemDuplicate = Inventory.GroupBy(x => x.Id).Any(g => g.Count() > 1);
        if (itemDuplicate)
        {
            Console.WriteLine($"The item [{item.Name}] is already in the inventory of player {Name}");
            return;
        }
        Inventory.Add(item);
        Console.WriteLine("All godd!");
    }

    public void RemoveFromInventory() { }

    public void HasItem() { }

    public Item GetItem(string itemName)
    {
        return Inventory.SingleOrDefault(item => item.Name == itemName)!;
        
    }

    public void ShowInventory() { }

    // public override string ToString()
    // {
    //     return $"[Player #{Id}] | {Name} {Health} {CurrentRoom} {Inventory.Count} {Health}";
    // }
}