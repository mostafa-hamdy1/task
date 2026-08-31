using System;
using System.Drawing;
namespace Task05

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Assignment Running ===");
            // قم بإلغاء التعليق (Uncomment) عن أية دالة تجعلها تعمل عند التشغيل:

            // --- Testing Part 01 ---
            // Part01Solutions.P01_DivideTwoIntegers();
            // Part01Solutions.P02_TestDefensiveCode();
            //Part01Solutions.P03_NullableDemo();
            // Part01Solutions.P04_ArrayOutOfBounds();
            // Part01Solutions.P05_MatrixSums();
            // Part01Solutions.P06_JaggedArray();
            //Part01Solutions.P07_NullableReferenceType();
            // Part01Solutions.P08_BoxingUnboxing();
            // Part01Solutions.SumAndMultiply(5,5,out int s, out int p);
            // Part01Solutions.printstring("Hello World", 6);
            //  Part01Solutions.P11_NullPropagation();
            //  Part01Solutions.P12_SwitchExpression();
            // Part01Solutions.SumArray(1, 2, 3, 4, 5); 

            // --- Testing Part 02 ---
            //Part02Solutions.PrintRange();
            //Part02Solutions.MultiplicationTable();
            //Part02Solutions.ListEvenNumbers();
            //Part02Solutions.ComputeExponentiation();
            //Part02Solutions.ReverseString();
            //Part02Solutions.ReverseInteger();
            //Part02Solutions.FindLongestDistance();
            //Part02Solutions.ReverseWords();
        }
    }

    // =========================================================================
    // PART 01 SOLUTIONS
    // =========================================================================
    public static class Part01Solutions
    {
        #region Problem01
        // 1. Divide with Try-Catch-Finally
        public static void P01_DivideTwoIntegers()
        {
            try
            {
                Console.Write("Enter first integer: ");
                int num1 = int.Parse(Console.ReadLine()!);
                Console.Write("Enter second integer: ");
                int num2 = int.Parse(Console.ReadLine()!);

                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Operation complete");
            }
        }

        #endregion

        #region problem02
        public static void P02_TestDefensiveCode()
        {
            Console.Write("Enter X: ");
            if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
            {
                Console.Write("Enter Y: ");
                if (int.TryParse(Console.ReadLine(), out int y) && y > 1)
                {
                    Console.WriteLine($"Valid Inputs: X={x}, Y={y}");
                }
                else
                {
                    Console.WriteLine("Y must be a positive integer greater than 1.");
                }
            }
            else
            {
                Console.WriteLine("X must be a positive integer.");
            }
        }
        #endregion

        #region probelm03
        // 3. Nullable Integers and Null-Coalescing
        public static void P03_NullableDemo()
        {
            int? nullableInt = null;
            int value = nullableInt ?? 10;
            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"HasValue: {nullableInt.HasValue}");

            if (nullableInt.HasValue)
                Console.WriteLine(nullableInt.Value);
        }
        #endregion

        #region problem04
        //// 4. Array Out of Bounds Handling
        //public static void P04_ArrayOutOfBounds()
        //{
        //    int[] numbers = new int[5];
        //    try
        //    {
        //        Console.WriteLine(numbers[10]);
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        Console.WriteLine($"Handled Exception: {ex.Message}");
        //    }
        //} 
        #endregion

        #region Problem05
        //// 5. 3x3 Array Sums
        //public static void P05_MatrixSums()
        //{
        //    int[,] matrix = new int[3, 3];
        //    Console.WriteLine("Enter elements for 3x3 matrix:");
        //    for (int i = 0; i < 3; i++)
        //        for (int j = 0; j < 3; j++)
        //            matrix[i, j] = int.Parse(Console.ReadLine()!);

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        int rowSum = 0;
        //        for (int j = 0; j < matrix.GetLength(1); j++) 
        //            rowSum += matrix[i, j];
        //        Console.WriteLine($"Row {i + 1} Sum: {rowSum}");
        //    }

        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        int colSum = 0;
        //        for (int i = 0; i < matrix.GetLength(0); i++) 
        //            colSum += matrix[i, j];
        //        Console.WriteLine($"Column {j + 1} Sum: {colSum}");
        //    }
        //} 
        #endregion

        #region Problem06
        //// 6. Jagged Array
        //public static void P06_JaggedArray()
        //{
        //    int[][] jagged = new int[3][];
        //    jagged[0] = new int[2];
        //    jagged[1] = new int[3];
        //    jagged[2] = new int[1];

        //    for (int i = 0; i < jagged.Length; i++)
        //    {
        //        Console.WriteLine($"Enter {jagged[i].Length} values for row {i + 1}:");
        //        for (int j = 0; j < jagged[i].Length; j++)
        //            jagged[i][j] = int.Parse(Console.ReadLine()!);
        //    }

        //    Console.WriteLine("\nJagged Array Contents:");
        //    for (int i = 0; i < jagged.Length; i++)
        //    {
        //        for (int j = 0; j < jagged[i].Length; j++)
        //        {
        //            Console.Write(jagged[i][j] + " ");
        //        }
        //        Console.WriteLine(); 
        //    }
        //} 
        #endregion

        #region Problem07
        //// 7. Nullable Reference Types
        //public static void P07_NullableReferenceType()
        //{
        //    Console.Write("Enter text (optional): ");
        //    string? input = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(input))
        //        input = null;

        //    string result = input!;
        //    Console.WriteLine($"Length: {result?.Length ?? 0}");
        //} 
        #endregion

        #region Problem08
        //// 8. Boxing and Unboxing
        //public static void P08_BoxingUnboxing()
        //{
        //    int num = 42;
        //    object boxed = num;

        //    try
        //    {
        //        string invalidCast = (string)boxed;
        //    }
        //    catch (InvalidCastException ex)
        //    {
        //        Console.WriteLine($"Handled Cast Exception: {ex.Message}");
        //    }
        //} 
        #endregion

        #region Problem09
        //// 9. SumAndMultiply with out parameters
        //public static void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //    Console.WriteLine($"Sum:{sum}");
        //    Console.WriteLine($"product:{product}");
        //} 
        #endregion

        #region Problem10
        //// 10. optional & named parameters
        //public static void printstring(string text, int count = 5)
        //{
        //    for (int i = 0; i < count; i++)
        //        Console.WriteLine(text);
        //} 
        #endregion

        #region Problem11
        //// 11. Null Propagation Operator
        //public static void P11_NullPropagation()
        //{

        //    int[]? numbers = null;
        //    int? length = numbers?.Length;
        //    Console.WriteLine($"Array Length: {length ?? 0}");
        //} 
        #endregion

        #region Problem12
        //// 12. Switch Expression
        //public static void P12_SwitchExpression()
        //{
        //    Console.Write("Enter day of week: ");
        //    string day = Console.ReadLine()!;
        //    int dayNumber = day.ToLower()
        //    switch
        //    {
        //        "monday" => 1,
        //        "tuesday" => 2,
        //        "wednesday" => 3,
        //        "thursday" => 4,
        //        "friday" => 5,
        //        "saturday" => 6,
        //        "sunday" => 7,
        //        _ => -1
        //    };
        //    Console.WriteLine($"Day Number: {dayNumber}");
        //} 
        #endregion

        #region Problem13
        //public static void SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int n in numbers)
        //    {
        //        sum += n;
        //    }

        //    Console.WriteLine($"Sum: {sum}");
        //} 
        #endregion

    }

    //// =========================================================================
    //// PART 02 SOLUTIONS
    //// =========================================================================
    public static class Part02Solutions
    {
        #region problem01
        //// 1. Program to Print Numbers in a Range
        //public static void PrintRange()
        //{
        //    Console.Write("Enter a positive integer: ");
        //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        //    {
        //        for (int i = 1; i <= n; i++)
        //        {
        //            Console.Write(i + (i < n ? ", " : ""));
        //        }
        //        Console.WriteLine();
        //    }
        //} 
        #endregion

        #region Problem02
        //// 2. Program to Display Multiplication Table
        //public static void MultiplicationTable()
        //{
        //    Console.Write("Enter an integer: ");
        //    if (int.TryParse(Console.ReadLine(), out int num))
        //    {
        //        for (int i = 1; i <= 12; i++)
        //        {
        //            Console.Write((num * i) + (i < 12 ? ", " : ""));
        //        }
        //        Console.WriteLine();
        //    }
        //} 
        #endregion

        #region Problem03
        //// 3. Program to List Even Numbers
        //public static void ListEvenNumbers()
        //{
        //    Console.Write("Enter a number: ");
        //    if (int.TryParse(Console.ReadLine(), out int n))
        //    {
        //        for (int i = 2; i <= n; i += 2)
        //        {
        //            Console.Write(i + (i + 2 <= n ? ", " : ""));
        //        }
        //        Console.WriteLine();
        //    }
        //} 
        #endregion

        #region Problem04
        //// 4. Program to Compute Exponentiation
        //public static void ComputeExponentiation()
        //{
        //    Console.Write("Enter base and power (e.g. 3, 4): ");
        //    string[] inputs = Console.ReadLine()!.Split(',');

        //    if (inputs.Length == 2 &&
        //        int.TryParse(inputs[0].Trim(), out int baseNum) &&
        //        int.TryParse(inputs[1].Trim(), out int power))
        //    {
        //        long result = 1;
        //        for (int i = 0; i < power; i++)
        //        {
        //            result *= baseNum;
        //        }
        //        Console.WriteLine($"Output: {result}");
        //    }
        //} 
        #endregion

        #region Problem05
        //// 5. Program to Reverse a Text String
        //public static void ReverseString()
        //{
        //    Console.Write("Enter a string: ");
        //    string input = Console.ReadLine()!;

        //    string reversed = "";
        //    for (int i = input.Length - 1; i >= 0; i--)
        //    {
        //        reversed += input[i];
        //    }

        //    Console.WriteLine($"Output: {reversed}");
        //} 
        #endregion

        #region Problem06
        //// 6. Program to Reverse an Integer Value
        //public static void ReverseInteger()
        //{
        //    Console.Write("Enter an integer: ");
        //    if (int.TryParse(Console.ReadLine(), out int number))
        //    {
        //        int reversed = 0;
        //        int temp = Math.Abs(number);

        //        while (temp > 0)
        //        {
        //            int remainder = temp % 10;
        //            reversed = (reversed * 10) + remainder;
        //            temp /= 10;
        //        }

        //        if (number < 0) reversed = -reversed;

        //        Console.WriteLine($"Output: {reversed}");
        //    }
        //} 
        #endregion

        #region Problem07
        //// 7. Program to Find Longest Distance Between Matching Elements
        //public static void FindLongestDistance()
        //{
        //    Console.Write("Enter array elements separated by spaces or commas: ");
        //    string[] rawInputs = Console.ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //    int[] arr = new int[rawInputs.Length];

        //    for (int i = 0; i < rawInputs.Length; i++)
        //    {
        //        arr[i] = int.Parse(rawInputs[i].Trim());
        //    }

        //    int maxDistance = -1;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = arr.Length - 1; j > i; j--)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                int distance = j - i - 1;
        //                if (distance > maxDistance)
        //                {
        //                    maxDistance = distance;
        //                }
        //                break;
        //            }
        //        }
        //    }

        //    if (maxDistance != -1)
        //        Console.WriteLine($"Longest distance: {maxDistance} cells.");
        //    else
        //        Console.WriteLine("No matching elements found.");
        //} 
        #endregion

        #region Problem08
        //// 8. Program to Reverse Words in a Sentence
        //public static void ReverseWords()
        //{
        //    Console.Write("Enter a sentence: ");
        //    string sentence = Console.ReadLine()!;

        //    string[] words = sentence.Split(' ');
        //    string reversedSentence = "";

        //    for (int i = words.Length - 1; i >= 0; i--)
        //    {
        //        reversedSentence += words[i] + (i > 0 ? " " : "");
        //    }

        //    Console.WriteLine($"Output: {reversedSentence}");
        //} 
        #endregion
    }
}

