namespace TextAdventureGame;

public class Item
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsUsable { get; set; }

    public bool IsWeapon { get; set; }

    // Damage

    public Item() { }

    public void Use()
    {
        
    }
}