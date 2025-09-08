namespace Revision.YouTube;

public struct Channel
{
    public string ChannelName { get; set; }
    private List<Video> Videos { get; set; }

    public Channel()
    {
        Videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        Videos.Add(video);
        UploadVideo?.Invoke(video,this);
    }
    
    public event Action<Video,Channel> UploadVideo;
    
    override public string ToString()
    {
        return $"ChannelName: {ChannelName}";
    }
}