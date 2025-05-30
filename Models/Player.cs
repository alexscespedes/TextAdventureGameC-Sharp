namespace TextAdventureGame;

public class Player
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string CurrentRoom { get; set; }

    public int Health { get; set; }

    public List<string> Inventory { get; set; }
}