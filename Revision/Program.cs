using System.Collections;
using System.Collections.Immutable;
using Revision.Data;

namespace Revision;

using static Revision.Data.ListGenerator;

class Program
{
    public static IEnumerable<int> GetLazyNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            yield return i;
        }
    }

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

        #region Aggregate Operators

        // var Result = ProductsList.Count();
        // Result = ProductsList.Count;
        // Console.WriteLine(Result);

        // var Numbers = Enumerable.Range(1, 100);
        // var NumbersList = Numbers.ToList();
        // Console.WriteLine(NumbersList.Count);
        // Console.WriteLine(Numbers.Count());

        // var Result = ProductsList.Where(p => p.UnitsInStock > 0).Count();
        // Result = ProductsList.Count(p => p.UnitsInStock > 0);
        // Console.WriteLine(Result);
        //
        // bool Flag = ProductsList.TryGetNonEnumeratedCount(out Result);
        // Console.WriteLine(Flag);
        // Console.WriteLine(Result);

        // var Numbers = GetLazyNumbers();
        // Console.WriteLine(Numbers.Count());

        #endregion

        #region Sum and Average

        // var result = ProductsList.Sum(p => p.UnitPrice);
        // result = ProductsList.Average(p => p.UnitPrice);
        // Console.WriteLine(result);

        #endregion

        #region Maximum and Minimum

        // var Result = ProductsList.Max(new ProductUnitInStockComparer());
        // Result = ProductsList.Min();
        // Console.WriteLine(Result);

        // var Result = ProductsList.MinBy(p => p.ProductName);
        // Result = ProductsList.MaxBy(p => p.ProductName);
        // Console.WriteLine(Result);

        #endregion

        #region Aggregate

        // string[] Words = { "One", "Two", "Three", "Four", "Five" };
        // var Result = Words.Aggregate((S1, S2) => S1 + " " + S2);
        // Result = Words.Aggregate("Hi :",(S1, S2)=> S1 + " " + S2);
        // Result = Words.Aggregate("Hi :",(S1, S2)=> S1 + " " + S2, (TAcc)=> TAcc.Replace(' ','_'));
        // Console.WriteLine(Result);

        #endregion

        #region Casting Operators

        // List<Product> Result = ProductsList.Where(x => x.UnitsInStock == 0).ToList(); // Cast to List
        // Product[] array = ProductsList.Where(x => x.UnitsInStock == 0).ToArray(); // Cast to Array
        // Dictionary<long, Product> dict = ProductsList.Where(x => x.UnitsInStock == 0).ToDictionary(p => p.ProductID);
        // Dictionary<long, string> dict2 = ProductsList.Where(x => x.UnitsInStock == 0).ToDictionary(p=> p.ProductID, p=> p.ProductName);
        // foreach (var product in dict2)
        // {
        //     Console.WriteLine($"Key is {product.Key} and Value is {product.Value}");
        // }

        // Mutable HashSet
        // HashSet<Product> set = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet();
        // set.Add(new Product(){ProductName = "Test"});

        // Immutable HashSet
        // var hasset = ProductsList.Where(p => p.UnitsInStock == 0).ToImmutableHashSet();
        // hasset.Add(new Product(){ProductName = "Test"});

        // foreach (Product product in hasset)
        //     Console.WriteLine(product);

        #endregion

        #region Generate Operators [Valid Only With Method Syntax]

        // var Result = Enumerable.Range(1, 100);
        // Result = Enumerable.Repeat(2, 100);
        // var Products = Enumerable.Repeat(new Product(){Category = "Meat"}, 100);
        // var Result = Enumerable.Empty<Product>().ToList();
        // Product[] Arr = new Product[0];
        //
        // foreach (var result in Result)
        //     Console.WriteLine(result);

        #endregion

        #region Set Operators [Union Family]

        // var Numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // var Numbers2 = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        // var Result = Numbers1.Union(Numbers2);
        // Result = Numbers1.Concat(Numbers2);
        // Result = Numbers1.Concat(Numbers2).Distinct();
        // Result = Numbers1.Intersect(Numbers2);
        // Result = Numbers1.Except(Numbers2);
        //
        // foreach (var item in Result)
        //     Console.WriteLine(item);


        // var Products1 = new List<Product>()
        // {
        //     new Product
        //     {
        //         ProductID = 1, ProductName = "Chai", Category = "Beverages",
        //         UnitPrice = 18.00M, UnitsInStock = 100
        //     },
        //     new Product
        //     {
        //         ProductID = 2, ProductName = "Cha2ng", Category = "Beverages",
        //         UnitPrice = 19.0000M, UnitsInStock = 17
        //     },
        //     new Product
        //     {
        //         ProductID = 2, ProductName = "Chang", Category = "Beverages",
        //         UnitPrice = 19.0000M, UnitsInStock = 17
        //     },
        //     new Product
        //     {
        //         ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
        //         UnitPrice = 10.0000M, UnitsInStock = 13
        //     },
        //     new Product
        //     {
        //         ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
        //         UnitPrice = 22.0000M, UnitsInStock = 53
        //     },
        //     new Product
        //     {
        //         ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
        //         UnitPrice = 21.3500M, UnitsInStock = 0
        //     }
        // };
        //
        // var Products2 = new List<Product>()
        // {
        //     new Product
        //     {
        //         ProductID = 1, ProductName = "Chai", Category = "Beverages",
        //         UnitPrice = 18.00M, UnitsInStock = 100
        //     },
        //     new Product
        //     {
        //         ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
        //         UnitPrice = 22.0000M, UnitsInStock = 53
        //     },
        //     new Product
        //     {
        //         ProductID = 2, ProductName = "Cha1ng", Category = "Beverages",
        //         UnitPrice = 19.0000M, UnitsInStock = 17
        //     },
        // };

        // var Result = Products1.Union(Products2);
        // Result = Products1.Union(Products2, new ProductIdEqualityComparer());
        // var Result = Products1.UnionBy(Products2, p => p.ProductID);
        // Result = Products1.Intersect(Products2);
        // Result = Products1.Intersect(Products2, new ProductIdEqualityComparer());
        // Result = Products1.IntersectBy(Products2.Select(p => p.ProductID), p => p.ProductID);
        // var Result = Products1.ExceptBy(Products2.Select(p => p.ProductID), p => p.ProductID);
        // var Result = Products1.Distinct();
        // Result = Products1.Distinct(new ProductIdEqualityComparer());
        // var Result = Products1.DistinctBy(p => p.ProductID);

        // foreach (var item in Result)
        //     Console.WriteLine(item);

        #endregion

        #region Quantifier Operators - Return Boolean

        // Console.WriteLine(ProductsList.Any());
        // Console.WriteLine(ProductsList.Any(p=>p.UnitsInStock==0));
        // Console.WriteLine(ProductsList.All(p=>p.UnitsInStock==0));
        // var Products1 = new List<Product>()
        // {
        //     new Product
        //     {
        //         ProductID = 1, ProductName = "Chai", Category = "Beverages",
        //         UnitPrice = 18.00M, UnitsInStock = 100
        //     },
        //     new Product
        //     {
        //         ProductID = 2, ProductName = "Cha2ng", Category = "Beverages",
        //         UnitPrice = 19.0000M, UnitsInStock = 17
        //     },
        //     new Product
        //     {
        //         ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
        //         UnitPrice = 10.0000M, UnitsInStock = 13
        //     },
        //     new Product
        //     {
        //         ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
        //         UnitPrice = 22.0000M, UnitsInStock = 53
        //     },
        //     new Product
        //     {
        //         ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
        //         UnitPrice = 21.3500M, UnitsInStock = 0
        //     }
        // };
        //
        // Product product = new Product
        // {
        //     ProductID = 1, ProductName = "Ch1ai", Category = "Beverages",
        //     UnitPrice = 18.00M, UnitsInStock = 100
        // };
        //
        // Console.WriteLine(ProductsList.Contains<Product>(product, new ProductIdEqualityComparer()));

        // var Numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // var Numbers2 = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        // Console.WriteLine(Numbers1.SequenceEqual(Numbers2)); // False

        #endregion

        #region Let & Into Keywords

        // var Result = from p in ProductsList
        //     where p.UnitPrice * 0.8m < 10
        //     select new
        //     {
        //         p.ProductName,
        //         PriceAfterDiscount = p.UnitPrice * 0.8m
        //     };
        //
        // Result = from p in ProductsList
        //     let PriceAfterDiscount = p.UnitPrice * 0.8m
        //     where PriceAfterDiscount < 10
        //     select new
        //     {
        //         p.ProductName,
        //         PriceAfterDiscount
        //     };
        //
        // var Result2 = from p in ProductsList
        //     select p.UnitPrice * 0.9m
        //         into DiscountedPrices
        //         where DiscountedPrices < 10
        //         select DiscountedPrices;
        //         
        // foreach (var p in Result2)
        //     Console.WriteLine(p);

        #endregion

        #region Grouping Operators

        // var Result =
        //     from p in ProductsList
        //     where p.UnitsInStock > 0
        //     group p by p.Category
        //     into ProductGroup
        //     where ProductGroup.Count() > 10
        //     select ProductGroup;

        // foreach (var group in Result)
        // {
        //     Console.WriteLine($"Category is {group.Key} and Count is {group.Count()}");
        //     foreach (var item in group)
        //         Console.WriteLine($"\t {item}");
        // }

        // foreach (var group in Result)
        // {
        //     Console.WriteLine($"Category is {group.Key} and Count is {group.Count()}");
        // }

        // var Result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category,
        //     (k, p) => new { Category = k, CountOfProducts = p.Count() , StringComparer.OrdinalIgnoreCase });

        // var Result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category, p => p.ProductName,
        //     (k, p) => new { Category = k, Count = p.Count() },StringComparer.OrdinalIgnoreCase);
        //
        // foreach (var item in Result)
        //     Console.WriteLine($"Category is {item.Category} and Count is {item.Count}");

        #endregion

        #region Partitioning Operators

        // var Result = ProductsList.Where(p => p.UnitsInStock > 0).Take(5);
        // Result = ProductsList.Where(p => p.UnitsInStock > 0).TakeLast(5);
        // Result = ProductsList.Where(p => p.UnitsInStock > 0).Skip(5).Take(5);
        // Result = ProductsList.Where(p => p.UnitsInStock > 0).SkipLast(5);
        
        // int[] RandomNumbers = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
        // var Result = RandomNumbers.TakeWhile((num , i) => num > i);
        // var Result = RandomNumbers.SkipWhile(n=> n % 2 != 0);
        // var Result = RandomNumbers.Chunk(3);
        //
        // foreach (var p in Result)
        // {
        //     if(p is int[])
        //         Console.WriteLine(string.Join(" , " , p));
        //     Console.WriteLine();
        // }

        // var Result = ProductsList.Chunk(10);
        //
        // foreach (var chunk in Result)
        // {
        //     Console.WriteLine(chunk.Count());
        // }

        #endregion
    }
}