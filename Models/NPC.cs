namespace TextAdventureGame;

public class NPC
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<string> Dialogue { get; set; }

    public bool IsFriendly { get; set; }

    public NPC() { }

    public void Speak()
    {

    }

    public void GiveItem()
    {

    }

    public void ReceiveItem()
    {
        
    }
    
}