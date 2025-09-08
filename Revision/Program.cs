using Revision.FIFA_Game;
using Revision.YouTube;

namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        Channel channel = new Channel { ChannelName = "Pewdipie" };
        channel.AddVideo(new Video(){Title = "How to make a game in unity", Description = "This is a tutorial on how to make a game in unity"});
        Subscriber subscriber1 = new Subscriber { SubscriberName = "Omar" };
        Subscriber subscriber2 = new Subscriber { SubscriberName = "Khalid" };
        Subscriber subscriber3 = new Subscriber { SubscriberName = "Ahmed" };
        channel.UploadVideo += subscriber1.Notify;
        channel.UploadVideo += subscriber2.Notify;
        channel.UploadVideo += subscriber3.Notify;
        channel.AddVideo(new Video(){Title = "How to make a game in unity", Description = "This is a tutorial on how to make a game in unity"});
        Console.WriteLine("--------------------------------------------------");
        channel.UploadVideo -= subscriber3.Notify;
        channel.AddVideo(new Video(){Title = "How to make a game in unity", Description = "This is a tutorial on how to make a game in unity"});
    }
}