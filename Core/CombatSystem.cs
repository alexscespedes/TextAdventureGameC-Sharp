namespace TextAdventureGame;

public class CombatSystem
{
    public bool IsInCombat { get; set; } = false;

    public Enemy? CurrentEnemy { get; set; }

    public Player Player { get; set; }

    public CombatSystem(Player player)
    {
        Player = player;
    }

    public void StartCombat()
    {

    }

    public void EndCombat()
    {

    }
    
    public void IsPlayerInCombat()
    {
        
    }
}