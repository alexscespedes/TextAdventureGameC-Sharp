namespace TextAdventureGame;

public class Player
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Health { get; set; }

    public Room CurrentRoom { get; set; }

    public List<Item> Inventory { get; set; }

    public Player() { }

    public void TakeDamage() { }

    public void Heal() { }

    public void AddToInventory() { }

    public void RemoveFromInventory() { }
    
    public void HasItem() {}
}