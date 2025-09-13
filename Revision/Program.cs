using System.Collections;
namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        // LINQ
        
        // 1. Fluent Syntax
        // List<int> Numbers = new List<int>() {9,8,7,6,5,1,2,3,4};
        // var result = Enumerable.Where(Numbers, x => x % 2 == 0);
        // var result = Numbers.Where(x=> x % 2 == 0);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        
        
        // 2. Query Syntax
        // List<int> Numbers = new List<int>() {9,8,7,6,5,1,2,3,4};
        // var result = from n in Numbers
        //     where n % 2 != 0
        //     select n;
        // foreach (var item in result)
        //     Console.WriteLine(item);

    }
}