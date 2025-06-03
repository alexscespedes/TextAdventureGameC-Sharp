namespace TextAdventureGame;

class Program
{
    static void Main(string[] args)
    {
        var item1 = new Item(1, "Ruby");
        var player1 = new Player("Alex");
        Console.WriteLine(item1);
        Console.WriteLine(player1);
        player1.AddToInventory(item1);
        Console.WriteLine(player1.GetItem("Ruby"));
        
    }
}
