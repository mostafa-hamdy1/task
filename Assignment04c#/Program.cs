using System;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Part 01
            #region Problem01

            //// - Problem 1: 1D Array Initialization
            //int[] arr1Way1 = new int[3] { 1, 2, 3 };
            //int[] arr1Way2 = { 4, 5, 6 };
            //int[] arr1Way3 = new[] { 7, 8, 9 };

            //foreach (int val in arr1Way1)
            //    Console.WriteLine(val);

            //try
            //{
            //    Console.WriteLine(arr1Way1[10]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("IndexOutOfRangeException Caught!");
            //} 
            #endregion

            #region Problem02
            ////- Problem 2: Shallow Copy vs Deep Copy
            //int[] shallow1 = { 10, 20, 30 };
            //int[] shallow2 = shallow1; // Shallow copy
            //shallow2[0] = 99; // Affects shallow1

            //int[] deep1 = { 10, 20, 30 };
            //int[] deep2 = (int[])deep1.Clone(); // Deep copy
            //deep2[0] = 99; // Does NOT affect deep1 
            #endregion

            #region problem03
            //// - Problem 3: 2D Array Student Grades
            //int[,] grades = new int[3, 3];

            //// قراءة الدرجات من المستخدم
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter grade for Student {i + 1}, Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// طباعة الدرجات
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Student {i + 1} grades: ");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(grades[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem04
            //int[] numbers = { 40, 10, 50, 20, 30 };

            //Console.WriteLine("Original: " + string.Join(", ", numbers));

            //Array.Sort(numbers);
            //Console.WriteLine("After Sort: " + string.Join(", ", numbers));

            //Array.Reverse(numbers);
            //Console.WriteLine("After Reverse: " + string.Join(", ", numbers));

            //int index = Array.IndexOf(numbers, 40);
            //Console.WriteLine("Index of 40: " + index);

            //int[] copiedArray = new int[5];
            //Array.Copy(numbers, copiedArray, numbers.Length);
            //Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));

            //Array.Clear(numbers, 0, numbers.Length);
            //Console.WriteLine("After Clear: " + string.Join(", ", numbers)); 
            #endregion

            #region Problem05
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index--;
            //} 
            #endregion

            #region Problem06

            //int number;
            //bool isValid;

            //do
            //{
            //    Console.Write("Please enter a positive odd number: ");
            //    string input = Console.ReadLine();

            //    isValid = int.TryParse(input, out number) && number > 0 && number % 2 != 0;

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid input! Try again.");
            //    }

            //} while (!isValid);

            //Console.WriteLine($"Valid positive odd number entered: {number}"); 
            #endregion

            #region Problem07
            //int[,] matrix = {
            //{ 1, 2, 3 },
            //{ 4, 5, 6 },
            //{ 7, 8, 9 }
            //};

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem08
            //Console.Write("Enter a month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //// 1. Using if-else statement
            //Console.Write("Using if-else: ");
            //if (month == 1) Console.WriteLine("January");
            //else if (month == 2) Console.WriteLine("February");
            //else if (month == 3) Console.WriteLine("March");
            //else if (month == 4) Console.WriteLine("April");
            //else if (month == 5) Console.WriteLine("May");
            //else if (month == 6) Console.WriteLine("June");
            //else if (month == 7) Console.WriteLine("July");
            //else if (month == 8) Console.WriteLine("August");
            //else if (month == 9) Console.WriteLine("September");
            //else if (month == 10) Console.WriteLine("October");
            //else if (month == 11) Console.WriteLine("November");
            //else if (month == 12) Console.WriteLine("December");
            //else Console.WriteLine("Invalid month number!");

            //// 2. Using switch statement
            //Console.Write("Using switch: ");
            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Invalid month number!"); break;


            //} 
            #endregion

            #region Problem09
            //int[] numbers = { 15, 5, 20, 5, 30, 10 };

            //// 1. Sort the array
            //Array.Sort(numbers);
            //Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));

            //// 2. Search for a specific value (e.g., 5)
            //int searchValue = 5;
            //int firstIndex = Array.IndexOf(numbers, searchValue);
            //int lastIndex = Array.LastIndexOf(numbers, searchValue);

            //Console.WriteLine($"First occurrence of {searchValue}: index {firstIndex}");
            //Console.WriteLine($"Last occurrence of {searchValue}: index {lastIndex}"); 
            #endregion

            #region Problem10
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// 1. Sum using for loop
            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine($"Sum using for loop: {sumFor}");

            //// 2. Sum using foreach loop
            //int sumForeach = 0;
            //foreach (int item in numbers)
            //{
            //    sumForeach += item;
            //}
            //Console.WriteLine($"Sum using foreach loop: {sumForeach}"); 
            #endregion

            #region Problem02
            //// Part02

            //// Part 02 - Problem 2: Enum DayOfWeek
            //Console.Write("Enter a day number (1-7): ");
            //string input = Console.ReadLine();

            //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);

            //Console.WriteLine($"Corresponding Day: {day}"); 
            #endregion

        }
    }
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
