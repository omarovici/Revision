using System.Collections;
using Revision.FIFA_Game;
using Revision.YouTube;

namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        Hashtable noteBook = new Hashtable();
        Console.WriteLine(noteBook.Count);
        noteBook.Add("Omar", "0101");
        noteBook.Add("Ahmed", "0102");
        // noteBook.Add("Ahmed", "0102"); // Exception
        noteBook.Add("Sayed", "0103");
        noteBook["Ali"] = "0104";
        noteBook["Ali"] = "0105";
        Console.WriteLine(noteBook["Ali"]);
        // noteBook.Clear();
        // noteBook.Remove("Sayed");
        // Hashtable noteBook2 = (Hashtable)noteBook.Clone();
        Console.WriteLine(noteBook.Count);
        foreach (DictionaryEntry item in noteBook)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}