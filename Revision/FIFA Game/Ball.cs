namespace Revision.FIFA_Game;

public class Ball
{
    public int Id { get; set; }
    private Location location;

    public Location Location
    {
        get { return location; }
        set { location = value; }
    }

    override public string ToString()
    {
        return $"Id: {Id}, Location: [{location}]";
    }
}