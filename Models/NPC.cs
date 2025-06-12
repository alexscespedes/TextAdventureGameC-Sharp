namespace TextAdventureGame;

public class NPC
{
    static int nextId;
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<string> Dialogue { get; set; }

    public NPC(string name, string description, List<string> strings)
    {
        Id = Interlocked.Increment(ref nextId);
        Name = name;
        Description = description;
        Dialogue = strings;
    }

    public void Speak()
    {
        if (!CanTalk())
        {
            Console.WriteLine($"NPC {Name} doesn't have conversations ");
            return;
        }

        foreach (var text in Dialogue)
        {
            Console.WriteLine($"NPC: {text}");
        }
    }

    private bool CanTalk()
    {
        if (Dialogue.Count == 0)
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return $"[NPC #{Id}] | NPC Name: {Name} | NPC Description: {Description}";
    }
    
}