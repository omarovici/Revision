namespace Revision.YouTube;

public class Subscriber
{
    public string SubscriberName { get; set; }

    public void Notify(Video video, Channel channel)
    {
        Console.WriteLine($"{SubscriberName} has been notified of a new video '{video.Title}' on channel '{channel.ChannelName}'");
    }
    override public string ToString()
    {
        return $"SubscriberName: {SubscriberName}";
    }
}