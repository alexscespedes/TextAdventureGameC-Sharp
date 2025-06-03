namespace TextAdventureGame;

class Program
{
    static void Main(string[] args)
    {
        var item1 = new Item("Ruby", "Red Stone", true, false);

        var room1 = new Room("Room 1", "Room for player 1");

        var player1 = new Player("Alex", room1);

        player1.AddToInventory(item1);
        player1.HasItem("Ru");
        player1.ShowInventory();
        player1.RemoveFromInventory(item1);
        player1.ShowInventory();



    }
}
