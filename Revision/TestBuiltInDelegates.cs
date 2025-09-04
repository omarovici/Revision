namespace Revision;

public class TestBuiltInDelegates
{
    public static bool CheckPositive(int number) { return number > 0;}
    public static string Casting(int number) {return number.ToString();}
    public static void Print() { Console.WriteLine("Hello World!"); }
    public static void Print(string s) { Console.WriteLine($"Hello {s}"); }
}