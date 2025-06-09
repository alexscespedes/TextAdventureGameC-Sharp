namespace TextAdventureGame;

public class Item
{
    static int nextId;
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Item(string name, string description)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Description = description;
    }

    public void Use()
    {
        Console.WriteLine($"Item {Name} is used");
    }

    public override string ToString()
    {
        return $"[Item #{Id}] | Item Name: {Name} | Item Description: {Description}";
    }
}