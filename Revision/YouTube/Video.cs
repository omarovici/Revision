namespace Revision.YouTube;

public class Video
{
    public string Title { get; set; }
    public string Description { get; set; }

    override public string ToString()
    {
        return $"Title: {Title}, Description: {Description}";
    }
}