namespace Revision;

public class Player
{
    public string PlayerName { get; set; }
    public string TeamName { get; set; }
    public void Run()
    {
        Console.WriteLine($"{PlayerName} from {TeamName} is running ...");
    }
}