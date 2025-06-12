namespace TextAdventureGame;

public class CommandParser
{
    public GameState GameState { get; set; }

    public CombatSystem CombatSystem { get; set; }

    public CommandParser(GameState gameState, CombatSystem combatSystem)
    {
        GameState = gameState;
        CombatSystem = combatSystem;
    }

  public void ParseCommand(string userInput)
  {

  }

    public void SplitInput()
    {

    }

    public void ExecuteCommand()
    {
        
    }
}