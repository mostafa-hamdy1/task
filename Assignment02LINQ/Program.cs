using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;

using day10_G01;
using static day10_G01.ListGenerators;
using static day10_G01.Customer;
using static day10_G01.Product;
using static day10_G01.Order;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Restriction Operators
            #region Problem01
            //var result = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem02
            //var result = ProductList.Where((p) => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem03
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((digit, index) => digit.Length < index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //LINQ - Element Operators 
            #region Problem01
            //var result = ProductList.FirstOrDefault((p) => p.UnitsInStock == 0);

            //Console.WriteLine(result); 
            #endregion

            #region problem02
            //var result = ProductList.FirstOrDefault((p) => p.UnitPrice > 1000M);

            //Console.WriteLine(result?.ToString() ?? "No product found with price > 1000"); 
            #endregion

            #region Problem03
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where((n) => n > 5)
            //                         .Skip(1)
            //                             .FirstOrDefault();

            //Console.WriteLine(result); 
            #endregion

            //LINQ - Aggregate Operators
            #region Problem01
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count((n) => n % 2 != 0);

            //Console.WriteLine(result); 
            #endregion

            #region Problem02
            //var result = CustomerList.Select((c) => new
            //{
            //    CustomerName = c.Name,
            //    OrderCount = c.Orders.Length
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerName}: {item.OrderCount}");
            //} 
            #endregion

            #region Problem03
            //var result = ProductList.GroupBy((p) => p.Category)
            //            .Select((g) => new
            //            {
            //                Category = g.Key,
            //                ProductCount = g.Count()
            //            });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.ProductCount}");
            //} 
            #endregion

            #region Problem04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();

            //Console.WriteLine(result); 
            #endregion

            #region Problem05
            //var result = ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.CheapestPrice}");
            //} 
            #endregion

            //LINQ - Ordering Operators
            #region Problem01
            //var result = ProductList.OrderBy((p) => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem02
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOVeR", "cHeRrY" };

            //var result = Arr.OrderBy((w) => w.ToLower());

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region Problem03
            //var result = ProductList.OrderByDescending((p) => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem04
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy((d) => d.Length)
            //       .ThenBy(d => d);

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //} 
            #endregion

            #region Problem05
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOVeR", "cHeRrY" };

            //var result = words.OrderBy((w) => w.Length)
            //    .ThenBy((w) => w.ToLower());

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region Problem06
            //var result = ProductList.OrderBy((p) => p.Category)
            //               .ThenByDescending((p) => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem07
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOVeR", "cHeRrY" };

            //var result = Arr.OrderBy((w) => w.Length)
            //    .ThenByDescending((w) => w.ToLower());

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region Problem08
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((d) => d.Length > 1 && d[1] == 'i')
            //              .Reverse();

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //} 
            #endregion

            //LINQ – Transformation Operators 
            #region Problem01
            //var result = ProductList.Select((p) => p.ProductName);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region Problem02
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRrY" };

            //var result = words.Select((w) => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //} 
            #endregion

            #region Problem03
            //var result = ProductList.Select((p) => new
            //{
            //    p.ProductName,
            //    p.Category,
            //    Price = p.UnitPrice
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.Category} - {item.Price}");
            //} 
            #endregion

            #region Problem04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((v, index) => new
            //{
            //    Num = v,
            //    InPlace = v == index
            //});

            //Console.WriteLine("Number: In-place?");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Num}: {item.InPlace}");
            //} 
            #endregion

            #region Problem05
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //} 
            #endregion

            #region Problem06
            //var result = CustomerList.SelectMany((c) => c.Orders)
            //                 .Where((o) => o.Total < 500.00);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //} 
            #endregion

            #region Problem07
            //var result = CustomerList.SelectMany(c => c.Orders)
            //                        .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //} 
            #endregion

            //LINQ - Partitioning Operators 
            #region Problem01
            //var result = CustomerList.SelectMany(c => c.Orders)
            //                      .Take(3);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //} 
            #endregion

            #region Problem02
            //var result = CustomerList.SelectMany((c) => c.Orders)
            //             .Skip(2);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //} 
            #endregion

            #region Problem03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Problem04
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //  var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Problem05
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

        }
    }
}
