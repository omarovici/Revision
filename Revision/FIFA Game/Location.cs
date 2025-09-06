namespace Revision.FIFA_Game;

public struct Location
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    override public string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }
}