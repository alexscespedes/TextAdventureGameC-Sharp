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

    public Player(string name, Room currentRoom)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Inventory = new List<Item>();
        CurrentRoom = currentRoom;
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

    public void RemoveFromInventory(Item item)
    {
        var itemRemove = Inventory.SingleOrDefault(i => i.Id == item.Id);

        if (itemRemove != null)
        {
            Inventory.Remove(itemRemove);
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

        var itemMatched = Inventory.SingleOrDefault(item => item.Name.Contains(itemName.Trim(), StringComparison.InvariantCultureIgnoreCase))!;

        if (itemMatched != null)
        {
            Console.WriteLine(itemMatched.Name);
            return;
        }
        Console.WriteLine($"Player {Name} doesn't have {itemName} associated.");
        
    }

    public Item GetItem(string itemName)
    {
        var item = Inventory.SingleOrDefault(item => item.Name == itemName);

        if (item == null)
        {
            Console.WriteLine("No item has been found.");
            return null!;
        }
        return item;
        
    }

    public void ShowInventory()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine($"{Name}'s Inventory is empty ");
        }    

        foreach (var item in Inventory)
        {
            string usable = item.IsUsable ? "Yes" : "No";
            string weapon = item.IsWeapon ? "Yes" : "No";
            Console.WriteLine($"Item Name: {item.Name} | Item Description: {item.Description} | IsUsable: {usable} | Is a Weapon: {weapon}");
        }
    }

    public override string ToString()
    {
        string status = IsAlive ? "Alive" : "Dead";
        return $"[Player #{Id}] | {Name} | {Health} | {CurrentRoom.Name} | {Inventory.Count} | {status}";
    }
}