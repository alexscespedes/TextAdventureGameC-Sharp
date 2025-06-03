namespace TextAdventureGame;

public class Item
{
    static int nextId;
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsUsable { get; set; }

    public bool IsWeapon { get; set; }

    // Damage

    public Item(string name, string description, bool isUsable, bool isWeapon)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Description = description;
        IsUsable = isUsable;
        IsWeapon = isWeapon;
    }

    public void Use()
    {
        
    }
}