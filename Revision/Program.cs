using Revision.FIFA_Game;

namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        Ball ball = new Ball() {Id = 1};
        Console.WriteLine(ball);
        ball.Location = new Location() {X = 10, Y = 20, Z = 30};
        Console.WriteLine(ball);
        Player player01 = new Player() {PlayerName = "Salah", TeamName = "Liverpool"};
        Player player02 = new Player() {PlayerName = "Isak", TeamName = "Liverpool"};
        Player player03 = new Player() {PlayerName = "Marmoush", TeamName = "Manchester City"};
        Player player04 = new Player() {PlayerName = "Foden", TeamName = "Manchester City"};
        Player player05 = new Player() {PlayerName = "Halaand", TeamName = "Manchester City"};
        Refree refree = new Refree() {RefreeName = "Gamal El-Ghandour"};
        ball.Location = new Location() {X = 1, Y = 1, Z = 1};
        Console.WriteLine(ball);
        ball.BallLocationChanged += player01.Run;
        ball.BallLocationChanged += player02.Run;
        ball.BallLocationChanged += player03.Run;
        ball.BallLocationChanged += player04.Run;
        ball.BallLocationChanged += refree.Look;
        ball.Location = new Location() {X = 100, Y = 200, Z = 300};
        ball.Location = new Location() {X = 100, Y = 200, Z = 300};
        ball.Location = new Location() {X = 100, Y = 200, Z = 300};
        ball.Location = new Location() {X = 100, Y = 200, Z = 300};
        ball.BallLocationChanged -= player04.Run;
        ball.BallLocationChanged += player05.Run;
        ball.Location = new Location() {X = 1000, Y = 2000, Z = 3000};
    }
}