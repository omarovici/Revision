using System.Collections;
using Revision.FIFA_Game;
using Revision.YouTube;

namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,long> dict = new Dictionary<string,long>();
        dict.Add("FIFA", 2024);
        dict.Add("YouTube", 2005);
        dict.Add("Instagram", 2010);
        dict.Add("Snapchat", 2011);
        dict.Add("TikTok", 2016);
        dict.Add("Facebook", 2004);
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} was released in {item.Value}");
        }
    }
}