namespace Revision.FIFA_Game;

public class Refree
{
    public string RefreeName { get; set; }

    public void Look()
    {
        Console.WriteLine($"Refree: {RefreeName} is looking ...");
    }
}