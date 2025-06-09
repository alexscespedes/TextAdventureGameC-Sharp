namespace TextAdventureGame;

class Program
{
    static void Main(string[] args)
    {
        /*
        var ball = new Item("Ball", "Basketball Item", true, false);
        var shoes = new Item("Shoes", "Nike Shoes", true, false);
        var lambo = new Item("Lamboghini", "The Fancy Car", true, true);

        var room1 = new Room("The 2K Apartment", "The New York Apartment");
        var room2 = new Room("The Basket Practice", "Team Court");
        var room3 = new Room("The Lifting Area", "Team Gym Apartment");
        var room4 = new Room("TD Garden", "The Team Basketball Court");
        var room5 = new Room("Press Conference", "Room with reporters");

        var player1 = new Player("Alexander Sencion", room1);
        var player2 = new Player("Stefan Salvatore", room5);
        */

        var cpu = new NPC("Lamboghini", "The Fancy Car", ["Hey friend", "ready to play?"] );

        cpu.Speak();



    }
}
