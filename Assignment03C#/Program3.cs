using System;
using System.Text;

namespace task03
{
    class person
    { public string Name { get; set; } }
        
    internal class Program3
    {
        static void Main(string[] args)
        {
            #region problem01
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //try
            //{
            //    // Using int.Parse
            //    int num1 = int.Parse(input);
            //    Console.WriteLine($"Parsed with int.Parse: {num1}");

            //    // Using Convert.ToInt32
            //    int num2 = Convert.ToInt32(input);
            //    Console.WriteLine($"Parsed with Convert.ToInt32: {num2}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Input is not a valid integer format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Error: Number is too large or too small.");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Error: Input cannot be null.");
            //} 
            #endregion

            #region problem02
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int result))
            //{
            //    Console.WriteLine($"Valid Integer: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input, please enter a valid integer.");
            //} 
            #endregion

            #region problem03
            //object obj;

            //obj = 10;
            //Console.WriteLine($"int HashCode: {obj.GetHashCode()}");

            //obj = "Hello World";
            //Console.WriteLine($"string HashCode: {obj.GetHashCode()}");

            //obj = 99.99;
            //Console.WriteLine($"double HashCode: {obj.GetHashCode()}"); 
            #endregion

            #region Problem04

            //person obj1 = new person { Name = "Original" };
            //person obj2 = obj1;

            //obj1.Name = "Modified";

            //Console.WriteLine($"obj2.Name: {obj2.Name}"); 
            #endregion

            #region problem05
            //string text = "Hello";
            //Console.WriteLine($"Before Modification HashCode: {text.GetHashCode()}");

            //text += " Hi Willy";
            //Console.WriteLine($"After Modification HashCode: {text.GetHashCode()}");
            //Console.WriteLine(text); 
            #endregion

            #region problem06
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine($"Before Append HashCode: {sb.GetHashCode()}");

            //sb.Append(" - Welcome!");
            //Console.WriteLine($"After Append HashCode: {sb.GetHashCode()}");
            //Console.WriteLine(sb); 
            #endregion

            #region Problem07
            //Console.Write("Enter num 1: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter num 2: ");
            //int b = int.Parse(Console.ReadLine());

            //// 1. Concatenation
            //Console.WriteLine("Sum is " + (a + b));

            //// 2. Composite Formatting
            //Console.WriteLine(string.Format("Sum is {0}", a + b));

            //// 3. String Interpolation
            //Console.WriteLine($"Sum is {a + b}"); 
            #endregion

            #region problem08
            //StringBuilder sb = new StringBuilder("Hello World");

            //// Append
            //sb.Append("!!!");

            //// Replace
            //sb.Replace("World", "C#");

            //// Insert
            //sb.Insert(0, "Start: ");

            //// Remove
            //sb.Remove(0, 7);

            //Console.WriteLine(sb.ToString()); 
            #endregion
        }    
    }

    
}
