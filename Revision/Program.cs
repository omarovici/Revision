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

        #region Projection Operators

        // var Result = ProductsList.Select(p => p.ProductName);
        //
        // Result = from p in ProductsList
        //     select p.ProductName;
        //
        // var Result2 = ProductsList.Select(p=> new {p.ProductName , p.UnitPrice});
        //
        // var Result3 = ProductsList.Where(p => p.UnitsInStock > 0)
        //     .Select(p => new
        //     {
        //         ID = p.ProductID,
        //         Name = p.ProductName,
        //         OldPrice = p.UnitPrice,
        //         NewPrice = p.UnitPrice * 0.8m
        //     });
        //
        // Result3 = from p in ProductsList
        //     where p.UnitsInStock > 0
        //     select new
        //     {
        //         ID = p.ProductID,
        //         Name = p.ProductName,
        //         OldPrice = p.UnitPrice,
        //         NewPrice = p.UnitPrice * 0.8m
        //     };

        // var Result = ProductsList.Where(p => p.UnitsInStock > 0)
        //     .Select((P, I) => new
        //     {
        //         Serial = I+1,
        //         Name = P.ProductName,
        //     });
        
        // List<string> Words = new List<string>()
        // {
        //     "One Omar",
        //     "Two",
        //     "Three",
        //     "Four",
        //     "Five",
        //     "Six",
        //     "Seven",
        //     "Eight",
        //     "Nine",
        //     "Ten"
        // };
        //
        // var Result = from word in Words
        //     from W in word.Split(' ')
        //     select word;
        //
        // Result = Words.SelectMany(w => w.Split(' '));

        // var Result = CustomersList.SelectMany(c => c.Orders);
        //
        // Result = from c in CustomersList
        //     from o in c.Orders
        //     select o;
        
        // var Result = CustomersList.SelectMany(c=> c.Orders , (c , o) => new
        // {
        //     c.CustomerName,
        //     o.OrderID,
        //     o.Total
        // });
        //
        // Result = from c in CustomersList
        //     from o in c.Orders
        //         select new 
        //         {
        //             c.CustomerName,
        //             o.OrderID,
        //             o.Total
        //         };

        // var CustomerOrders = CustomersList.SelectMany((C, Index) => C.Orders.Select((O, I) =>
        //     new
        //     {
        //         CustomerIndex = Index + 1,
        //         OrderIndex = I + 1,
        //         C.CustomerName,
        //         O.OrderID,
        //         O.Total
        //     }));
        
        // List<int> Numbers = new List<int>()
        // {
        //     1,2,3,4,5,6,7,8,9,10,11,12
        // };
        // char[] Letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k'};
        // string[] Words = { "First" , "Second", "Third" };
        //
        // var Result = Numbers.Zip(Letters,(N,L) => $"Number is {N} and Letter is {L}");
        //
        //
        // foreach (var item in Result)
        //     Console.WriteLine(item);

        #endregion

        #region Sort Operators

        // var Result = CustomersList.OrderBy(c=> c.CustomerName);
        // foreach (var item in Result)
        //     Console.WriteLine(item);

        // var Result = ProductsList.OrderBy(p => p.UnitsInStock).ThenByDescending(p=>p.UnitPrice);
        //
        // Result = from p in ProductsList
        //     orderby p.UnitsInStock, p.UnitPrice descending
        //     select p;
        //


        // var Result = ProductsList.Where(P => P.ProductName.Length < 10).Select(p => p.ProductName).OrderBy(n=>n.Length);
        //
        // foreach (var item in Result)
        //     Console.WriteLine(item);

        #endregion

        #region Element Operators

        // var Result = ProductsList.First();
        // Result = ProductsList.Last();
        // Console.WriteLine(Result);
        
        // List<Product> products = new List<Product>();
        // var Result = products.FirstOrDefault();
        // Result = products.LastOrDefault();
        // Console.WriteLine(Result);
        
        // List<Product> products = new List<Product>();
        // var Result = products.FirstOrDefault(o=>o.UnitsInStock == 0,new Product());
        // Console.WriteLine(Result);

        // var Result = ProductsList.ElementAt(1);
        // Result = ProductsList.ElementAt(new Index(1,true));
        // Result = ProductsList.ElementAt(^1);
        // Result = ProductsList.ElementAt(100);
        // var Result = ProductsList.ElementAtOrDefault(100);
        // Console.WriteLine(Result);

        // var Result = ProductsList.SingleOrDefault(p=>p.ProductID==1);
        // Console.WriteLine(Result);

        // var Result = from p in ProductsList
        //     where p.UnitsInStock == 0
        //     select new
        //     {
        //         p.ProductID,
        //         p.ProductName
        //     };
        //
        // foreach (var item in Result)
        //     Console.WriteLine(item);
        
        // var Result = (from p in ProductsList
        //     where p.UnitsInStock == 0
        //     select new
        //     {
        //         p.ProductID,
        //         p.ProductName
        //     }).FirstOrDefault();
        //
        // Console.WriteLine(Result);


        #endregion
    }
}