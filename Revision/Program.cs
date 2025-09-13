using System.Collections;
namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        // LINQ execution ways
        // 1. Immediate Execution
        // 2. Deferred Execution
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var Result = numbers.Where(n => n % 2 == 0).ToList();
        numbers.AddRange(new List<int> { 11, 12, 13 });
        foreach (var item in Result)
        {
            Console.WriteLine(item);
        }
        
    }
}