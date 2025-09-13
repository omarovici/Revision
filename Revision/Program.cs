using System.Collections;
namespace Revision;

class Program
{
    static dynamic Print(dynamic obj)
    {
        return obj;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Print("Hello World"));
        Console.WriteLine(Print(123));
        Console.WriteLine(Print(45.67));
        Console.WriteLine(Print(true)); }
}