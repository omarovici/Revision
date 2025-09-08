namespace Revision.FIFA_Game;

public class Ball
{
    public int Id { get; set; }
    private Location location;

    public Location Location
    {
        get { return location; }
        set
        {
            if (!value.Equals(location))
            {
                location = value;
                BallLocationChanged?.Invoke(this);
            }
        }
    }
    public event Action<Ball>? BallLocationChanged;
    override public string ToString()
    {
        return $"Id: {Id}, Location: [{location}]";
    }
}