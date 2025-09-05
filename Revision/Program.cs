namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        Predicate<int> predicate = delegate (int x){return x%2==0;};
        Console.WriteLine(predicate(4)); // True
        Console.WriteLine(predicate(5)); // False
        
        Predicate<int> predicate2 = x => x % 2 != 0;
        Console.WriteLine(predicate2(4)); // False
        Console.WriteLine(predicate2(5)); // True


    }
}