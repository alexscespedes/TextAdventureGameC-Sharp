namespace TextAdventureGame;

public class Enemy
{
    static int nextId;
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Health { get; set; } = 100;

    public int AttackPower { get; set; } = 10;

    public Enemy(string name, string description)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Description = description;
    }

    public int Attack()
    {
        var rand = new Random();
        return rand.Next(1, 5) * AttackPower;
    }

    public void TakeDamage(int amount)
    {
        Health = Math.Max(Health - amount, 0);

        if (!IsAlive())
        {
            Console.WriteLine($"The player {Name} has lost the game");
            return;
        }
        Console.WriteLine($"Player {Name} has {Health} health points left");
    }

    private bool IsAlive()
    {
        if (Health > 0)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"[Enemy #{Id}] | {Name} | {Description} | {Health} | {AttackPower}";
    }
}