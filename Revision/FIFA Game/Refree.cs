namespace Revision.FIFA_Game;

public class Refree
{
    public string RefreeName { get; set; }

    public void Look(Ball ball)
    {
        Console.WriteLine($"Refree: {RefreeName} is looking at the ball in location: {ball.Location}");
    }
}