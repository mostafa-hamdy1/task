using System;
using System.Collections.Generic;

namespace Task10
{

    #region Employee
    public class Employee : IComparable<Employee>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Id is {Id}, Name is {Name}, Salary is {Salary}";
        }
        public int CompareTo(Employee other)
        {

            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }
    }
    #endregion

    #region SortingAlgorithm
    public class SortingAlgorithm<T> where T : IComparable<T>, ICloneable
    {
        public static void Sort(T[] array)
        {
            if (array == null || array.Length <= 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        // Generic Swap Method
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    #endregion


    #region delegate
    public delegate TResult CompareFuncDelegate<in T1, in T2, out TResult>(T1 X, T2 Y);

    #endregion

    #region SortingTwo<T>
    public class SortingTwo<T>
    {
        public static void Sort(T[] items, CompareFuncDelegate<T, T, bool> compareFunc)
        {
            if (items == null || items.Length <= 1) return;

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {

                    if (compareFunc.Invoke(items[j], items[j + 1]))
                    {
                        Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    #endregion

    #region CompareFunctions
    public class CompareFunctions
    {
        public static bool CompareLengthAsc(string X, string Y)
        {
            return X?.Length > Y?.Length;
        }
        public static bool CompareEmployeeBySalaryThenName(Employee e1, Employee e2)
        {
            if (e1 == null || e2 == null) return false;

            if (e1.Salary != e2.Salary)
            {
                return e1.Salary > e2.Salary;
            }

            return string.Compare(e1.Name, e2.Name) > 0;
        }
    }
    #endregion


    #region Manager : Employee, IComparable<Manager>
    public class Manager : Employee, IComparable<Manager>
    {

        public int CompareTo(Manager other)
        {
            if (other == null) return 1;

            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Manager -> Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
    #endregion

    #region FuncSorter
    public class FuncSorter<T>
    {
        public static void Sort(T[] items, Func<T, T, bool> compareFunc)
        {
            if (items == null || items.Length <= 1) return;

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (compareFunc.Invoke(items[j], items[j + 1]))
                    {
                        Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    #endregion

    #region Helpers
    public class Helpers<T>
    {

        public static T GetDefault()
        {
            return default(T);
        }
    }
    #endregion

    #region StringTransformerDelegate
    public delegate string StringTransformerDelegate(string input);
    #endregion

    #region StringTransformer
    public class StringTransformer
    {
        public static List<string> TransformList(List<string> list, StringTransformerDelegate processor)
        {
            List<string> result = new List<string>();

            if (list == null || processor == null) return result;

            foreach (string item in list)
            {
                result.Add(processor(item));
            }

            return result;
        }

        public static string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    #endregion

    #region MathOperationDelegate
    public delegate int MathOperationDelegate(int x, int y);
    #endregion

    #region MathProcessor
    public class MathProcessor
    {
        public static int ExecuteOperation(int a, int b, MathOperationDelegate operation)
        {
            return operation?.Invoke(a, b) ?? 0;
        }

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => b != 0 ? a / b : 0;
    }

    #endregion

    #region GenericDelegate
    public delegate R GenericDelegate<T, R>(T input);
    #endregion

    #region GenericTransformer
    public class GenericTransformer
    {
        public static List<R> TransformList<T, R>(List<T> list, GenericDelegate<T, R> transformer)
        {
            List<R> resultList = new List<R>();

            if (list == null || transformer == null) return resultList;

            foreach (T item in list)
            {

                R transformedItem = transformer.Invoke(item);
                resultList.Add(transformedItem);
            }

            return resultList;
        }
    }
    #endregion

    #region FuncProcessor
    public class FuncProcessor
    {

        public static List<int> ProcessList(List<int> list, Func<int, int> operation)
        {
            List<int> resultList = new List<int>();

            if (list == null || operation == null) return resultList;

            foreach (int item in list)
            {
                resultList.Add(operation(item));
            }

            return resultList;
        }
    }
    #endregion

    #region ActionProcessor
    public class ActionProcessor
    {

        public static void ProcessList(List<string> list, Action<string> action)
        {
            if (list == null || action == null) return;

            foreach (string item in list)
            {
                action.Invoke(item);
            }
        }
    }
    #endregion

    #region PredicateProcessor
    public class PredicateProcessor
    {
        public static List<int> FilterList(List<int> list, Predicate<int> predicate)
        {
            List<int> resultList = new List<int>();

            if (list == null || predicate == null) return resultList;

            foreach (int item in list)
            {
                if (predicate.Invoke(item))
                {
                    resultList.Add(item);
                }
            }

            return resultList;
        }
    }
    #endregion

    #region AnonymousFilterProcessor
    public class AnonymousFilterProcessor
    {
        public static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
        {
            List<string> resultList = new List<string>();

            if (list == null || condition == null) return resultList;

            foreach (string item in list)
            {
                if (condition.Invoke(item))
                {
                    resultList.Add(item);
                }
            }

            return resultList;
        }
    }
    #endregion

    #region AnonymousMathProcessor
    public class AnonymousMathProcessor
    {
        public static int PerformOperation(int x, int y, Func<int, int, int> operation)
        {
            return operation?.Invoke(x, y) ?? 0;
        }
    }
    #endregion

    #region LambdaFilterProcessor
    public class LambdaFilterProcessor
    {
        public static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
        {
            List<string> resultList = new List<string>();

            if (list == null || condition == null) return resultList;

            foreach (string item in list)
            {
                if (condition.Invoke(item))
                {
                    resultList.Add(item);
                }
            }

            return resultList;
        }
    }
    #endregion

    #region LambdaMathProcessor
    public class LambdaMathProcessor
    {
        public static double PerformOperation(double x, double y, Func<double, double, double> operation)
        {
            return operation?.Invoke(x, y) ?? 0.0;
        }
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test-Problem1
            //   Employee[] employees = new Employee[]
            //{
            //       new Employee { Id = 101, Name = "Ahmed", Salary = 8000 },
            //       new Employee { Id = 102, Name = "Mona",  Salary = 4500 },
            //       new Employee { Id = 103, Name = "Ali",   Salary = 6000 }
            //};

            //   Console.WriteLine("=== Before Sorting ===");
            //   foreach (var emp in employees)
            //   {
            //       Console.WriteLine(emp);
            //   }
            //   SortingAlgorithm<Employee>.Sort(employees);

            //   Console.WriteLine("\n=== After Sorting (Ascending by Salary) ===");
            //   foreach (var emp in employees)
            //   {
            //       Console.WriteLine(emp);
            //   } 
            #endregion

            #region Test-Problem02
            //int[] numbers = { 5, 2, 8, 1, 9, 3 };

            //Console.WriteLine("Original Array:");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //// استدعاء SortingTwo.Sort واستخدام Lambda Expression للترتيب التنازلي
            //SortingTwo<int>.Sort(numbers, (x, y) => x < y);

            //Console.WriteLine("\nSorted Array (Descending using Lambda Expression):");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Test-problem03
            //string[] names = { "Ahmed", "Ali", "Mostafa", "Omar" };

            //Console.WriteLine("Original Array:");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //SortingTwo<string>.Sort(names, CompareFunctions.CompareLengthAsc);

            //Console.WriteLine("\nSorted Array by Length (Ascending):");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region Test-Problem04
            //Manager[] managers = new Manager[]
            //{
            //    new Manager { Id = 1, Name = "Samy", Salary = 15000 },
            //    new Manager { Id = 2, Name = "Hassan", Salary = 10000 },
            //    new Manager { Id = 3, Name = "Noha", Salary = 20000 }
            //};

            //Console.WriteLine("Before Sorting Managers:");
            //foreach (var mgr in managers)
            //{
            //    Console.WriteLine(mgr);
            //}
            //SortingAlgorithm<Manager>.Sort(managers);

            //Console.WriteLine("\nAfter Sorting Managers (Ascending by Salary):");
            //foreach (var mgr in managers)
            //{
            //    Console.WriteLine(mgr);
            //} 
            #endregion

            #region Test-Problem05
            // Employee[] employees = new Employee[]
            //{
            //     new Employee { Id = 101, Name = "Mostafa", Salary = 8000 },
            //     new Employee { Id = 102, Name = "Ali",     Salary = 4500 },
            //     new Employee { Id = 103, Name = "Ibrahim", Salary = 6000 }
            //};

            // Func<Employee, Employee, bool> compareByNameLength = (e1, e2) => e1?.Name?.Length > e2?.Name?.Length;

            // FuncSorter<Employee>.Sort(employees, compareByNameLength);
            // Console.WriteLine("Employees sorted by Name Length:");
            // foreach (var emp in employees)
            // {
            //     Console.WriteLine(emp);
            // } 
            #endregion

            #region Test-Problem06

            //int[] numbers1 = { 5, 2, 8, 1, 9, 3 };
            //int[] numbers2 = { 5, 2, 8, 1, 9, 3 };

            //SortingTwo<int>.Sort(numbers1, delegate (int x, int y)
            //{
            //    return x > y; 
            //});

            //Console.WriteLine("Sorted using Anonymous Function:");
            //foreach (int num in numbers1)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("\n-----------------------------\n");

            //SortingTwo<int>.Sort(numbers2, (x, y) => x > y);

            //Console.WriteLine("Sorted using Lambda Expression:");
            //foreach (int num in numbers2)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Test-Problem07
            //int[] numbers = { 10, 20, 30, 40 };

            //Console.WriteLine("Before Swap:");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //SortingAlgorithm<int>.Swap(ref numbers[0], ref numbers[1]);

            //Console.WriteLine("\nAfter Swapping index 0 and index 1:");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Test-Problem08
            //Employee[] employees = new Employee[]
            //{
            //    new Employee { Id = 101, Name = "Samy",    Salary = 8000 },
            //    new Employee { Id = 102, Name = "Ahmed",   Salary = 5000 },
            //    new Employee { Id = 103, Name = "Mostafa", Salary = 5000 }, 
            //    new Employee { Id = 104, Name = "Ali",     Salary = 9000 }
            //};

            //Console.WriteLine("Before Sorting:");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}


            //SortingTwo<Employee>.Sort(employees, CompareFunctions.CompareEmployeeBySalaryThenName);

            //Console.WriteLine("\nAfter Sorting (By Salary then Name):");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion

            #region Test-Problem09
            //// 1. Value Types
            //int defaultInt = Helpers<int>.GetDefault();
            //bool defaultBool = Helpers<bool>.GetDefault();

            //Console.WriteLine($"Default Value for int: {defaultInt}");       // Output: 0
            //Console.WriteLine($"Default Value for bool: {defaultBool}");     // Output: False

            //// 2. Reference Types
            //string defaultString = Helpers<string>.GetDefault();
            //Employee defaultEmployee = Helpers<Employee>.GetDefault();

            //Console.WriteLine($"Default Value for string is null: {defaultString == null}"); // Output: True
            //Console.WriteLine($"Default Value for Employee is null: {defaultEmployee == null}"); // Output: True 
            #endregion

            #region Test-Problem10
            // Employee[] originalEmployees = new Employee[]
            //{
            //     new Employee { Id = 101, Name = "Samy",    Salary = 8000 },
            //     new Employee { Id = 102, Name = "Ahmed",   Salary = 3000 },
            //     new Employee { Id = 103, Name = "Mostafa", Salary = 5000 }
            //};


            // Employee[] clonedEmployees = new Employee[originalEmployees.Length];
            // for (int i = 0; i < originalEmployees.Length; i++)
            // {
            //     clonedEmployees[i] = (Employee)originalEmployees[i].Clone();
            // }


            // SortingAlgorithm<Employee>.Sort(clonedEmployees);


            // Console.WriteLine("Original Array (Unsorted):");
            // foreach (var emp in originalEmployees)
            // {
            //     Console.WriteLine(emp);
            // }

            // Console.WriteLine("\nCloned Array (Sorted):");
            // foreach (var emp in clonedEmployees)
            // {
            //     Console.WriteLine(emp);
            // } 
            #endregion

            #region Test-Problem11
            //List<string> names = new List<string> { "mostafa", "ahmed", "ali" };

            //List<string> upperNames = StringTransformer.TransformList(
            //    names,
            //    s => s.ToUpper()
            //);

            //Console.WriteLine("Uppercase Transformation:");
            //foreach (var name in upperNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("\n-----------------------------\n");

            //List<string> reversedNames = StringTransformer.TransformList(
            //    names,
            //    StringTransformer.ReverseString
            //);

            //Console.WriteLine("Reversed Transformation:");
            //foreach (var name in reversedNames)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region Test-Problem12
            //int num1 = 20;
            //int num2 = 5;


            //int sum = MathProcessor.ExecuteOperation(num1, num2, (x, y) => x + y);
            //Console.WriteLine($"Addition ({num1} + {num2}): {sum}");

            //int diff = MathProcessor.ExecuteOperation(num1, num2, MathProcessor.Subtract);
            //Console.WriteLine($"Subtraction ({num1} - {num2}): {diff}");

            //int product = MathProcessor.ExecuteOperation(num1, num2, (x, y) => x * y);
            //Console.WriteLine($"Multiplication ({num1} * {num2}): {product}");

            //int quotient = MathProcessor.ExecuteOperation(num1, num2, (x, y) => x / y);
            //Console.WriteLine($"Division ({num1} / {num2}): {quotient}"); 
            #endregion

            #region Test-Problem13
            //List<int> numbers = new List<int> { 10, 20, 30, 40 };


            //List<string> stringNumbers = GenericTransformer.TransformList(
            //    numbers,
            //    num => $"Number: {num}"
            //);

            //Console.WriteLine("Converted Integers to Strings:");
            //foreach (var str in stringNumbers)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine("\n-----------------------------\n");

            //List<string> words = new List<string> { "C#", "Generics", "Delegates" };

            //List<int> wordLengths = GenericTransformer.TransformList(
            //    words,
            //    word => word.Length
            //);

            //Console.WriteLine("Converted Strings to Word Lengths:");
            //foreach (var length in wordLengths)
            //{
            //    Console.WriteLine($"Length: {length}");
            //} 
            #endregion

            #region Test-Problem14
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };


            // Func<int, int> squareFunc = n => n * n;

            // List<int> squaredNumbers = FuncProcessor.ProcessList(numbers, squareFunc);

            // Console.WriteLine("Original Numbers:");
            // foreach (var num in numbers)
            // {
            //     Console.Write(num + " ");
            // }
            // Console.WriteLine(); 

            //Console.WriteLine("\nSquared Numbers:");
            // foreach (var num in squaredNumbers)
            // {
            //     Console.Write(num + " ");
            // }
            // Console.WriteLine(); 
            #endregion

            #region Test-Problem15
            //List<string> names = new List<string> { "Mostafa", "Ahmed", "Ali" };

            //Action<string> printAction = name => Console.WriteLine($"Hello, {name}!");

            //Console.WriteLine("--- Printing with Custom Action ---");
            //ActionProcessor.ProcessList(names, printAction);

            //Console.WriteLine("\n--- Printing directly with Console.WriteLine ---");
            //ActionProcessor.ProcessList(names, Console.WriteLine);
            #endregion

            #region Test-Problem16
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Predicate<int> isEvenPredicate = n => n % 2 == 0;

            //List<int> evenNumbers = PredicateProcessor.FilterList(numbers, isEvenPredicate);

            //Console.WriteLine("Even Numbers:");
            //foreach (var num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region Test-Probelm17
            //List<string> words = new List<string> { "Apple", "Banana", "Ahmed", "Mango", "Ali", "Cat" };

            //List<string> startsWithA = AnonymousFilterProcessor.FilterStrings(
            //    words,
            //    s => s.StartsWith("A")
            //);

            //Console.WriteLine("Strings that start with 'A':");
            //foreach (var word in startsWithA)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine("\n-----------------------------\n");

            //// 2. استخدام Anonymous Method (delegate) للفلترة: الكلمات التي تحتوي على المقظع "an"
            //List<string> containsAn = AnonymousFilterProcessor.FilterStrings(
            //    words,
            //    delegate (string s) { return s.Contains("an"); }
            //);

            //Console.WriteLine("Strings containing 'an':");
            //foreach (var word in containsAn)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region Test-Problem18
            //int num1 = 12;
            //int num2 = 4;

            //int addResult = AnonymousMathProcessor.PerformOperation(
            //    num1,
            //    num2,
            //    delegate (int a, int b) { return a + b; }
            //);

            //Console.WriteLine($"Addition ({num1} + {num2}): {addResult}");

            //int subResult = AnonymousMathProcessor.PerformOperation(
            //    num1,
            //    num2,
            //    (a, b) => a - b
            //);

            //Console.WriteLine($"Subtraction ({num1} - {num2}): {subResult}");

            //int mulResult = AnonymousMathProcessor.PerformOperation(
            //    num1,
            //    num2,
            //    (a, b) => a * b
            //);

            //Console.WriteLine($"Multiplication ({num1} * {num2}): {mulResult}"); 
            #endregion

            #region Test-Problem19
            //List<string> words = new List<string> { "Cat", "Apple", "Elephant", "Dog", "Blue", "Red" };

            //List<string> lengthGreaterThan3 = LambdaFilterProcessor.FilterStrings(
            //    words,
            //    s => s.Length > 3
            //);

            //Console.WriteLine("Strings with length > 3:");
            //foreach (var word in lengthGreaterThan3)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine("\n-----------------------------\n");

            //List<string> containsE = LambdaFilterProcessor.FilterStrings(
            //    words,
            //    s => s.Contains("e")
            //);

            //Console.WriteLine("Strings containing the letter 'e':");
            //foreach (var word in containsE)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region Test-problem20
            //double a = 10.0;
            //double b = 2.0;

            //double divisionResult = LambdaMathProcessor.PerformOperation(
            //    a,
            //    b,
            //    (x, y) => y != 0 ? x / y : double.NaN
            //);

            //Console.WriteLine($"Division ({a} / {b}): {divisionResult}");

            //double exponentResult = LambdaMathProcessor.PerformOperation(
            //    a,
            //    b,
            //    (x, y) => Math.Pow(x, y)
            //);

            //Console.WriteLine($"Exponentiation ({a} ^ {b}): {exponentResult}"); 
            #endregion

        }
    }
}
