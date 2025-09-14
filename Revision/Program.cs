using System.Collections;
using Revision.Data;

namespace Revision;

using static Revision.Data.ListGenerator;

class Program
{
    static void Main(string[] args)
    {
        #region Filteration Operators

        // var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 20m);
        // Result = ProductsList.Where((P, I) => I < 10 && P.ProductName.Length <= 10);
        //
        // Result = from P in ProductsList
        //     where P.UnitsInStock > 0 && P.UnitPrice > 20m
        //     select P;
        //
        // foreach (var p in Result)
        //     Console.WriteLine(p);


        // var Result = ProductsList.OfType<Product02>().Where(p => p.UnitsInStock > 0);
        
        // foreach (var item in Result)
        //     Console.WriteLine(item);

        // ArrayList Fruits = new ArrayList()
        // {
        //     "Apple",
        //     "Orange",
        //     123,
        //     "Banana",
        //     456,
        //     "Mango",
        //     "LemoN"
        // };
        // var Result = Fruits.OfType<string>().Where(F => F.Contains('n' , StringComparison.InvariantCultureIgnoreCase));
        //
        // foreach (var Fruit in Result)
        //     Console.WriteLine(Fruit);

        #endregion
    }
}