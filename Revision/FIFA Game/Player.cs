using Revision.FIFA_Game;

namespace Revision;

public class Player
{
    public string PlayerName { get; set; }
    public string TeamName { get; set; }
    public void Run(Ball ball)
    {
        Console.WriteLine($"{PlayerName} from {TeamName} is running to the ball in location: {ball.Location}");
    }
}