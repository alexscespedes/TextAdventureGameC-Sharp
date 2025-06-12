namespace TextAdventureGame;

public class GameEngine
{
    public GameState GameState { get; set; }

    public CommandParser CommandParser { get; set; }

    public bool IsRunning { get; set; }

    public CombatSystem CombatSystem { get; set; }

    public GameEngine(GameState gameState, CommandParser commandParser, CombatSystem combatSystem)
    {
        GameState = gameState;
        CommandParser = commandParser;
        CombatSystem = combatSystem;
    }

    public void Start()
    {

    }

    private void ProcessTurn()
    {

    }

    private void InitializeWorld()
    {

    }
}