using System;
using System.Reflection;
using System.Threading.Channels;

namespace Task09
{
    #region Problem03
    //public class Person
    // {

    //     public int ID { get; set; }
    //     public string Name { get; set; }
    //     public String Department { get; set; }

    // } 
    #endregion

    #region Peoblem04
    //internal class Parent
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Parent");
    //    }

    //    private int salary;

    //    // virtual prop
    //    public virtual int Salary
    //    {
    //        get { return salary; }
    //        set { salary = value + 1000; }
    //    }

    //}
    //internal class Child : Parent
    //{
    //    // sealed method
    //    public sealed override void Print()
    //    {
    //        Console.WriteLine("Child");
    //    }
    //    // sealed prop
    //    public sealed override int Salary
    //    {
    //        get { return base.Salary; }
    //        set { base.Salary = value + 2000; }
    //    }

    //    public void DisplaySalary()
    //    {
    //        Console.WriteLine($"Salary:{Salary}");
    //    }
    //} 
    #endregion

    #region Problem05 and Problem08
    //public static class Utility
    //{
    //    //problem05
    //    public static double CalcRectangle(double Length, double Width)
    //    {
    //        return 2 * (Length + Width);
    //    }
    //    //---------------------------------
    //    //Problem08
    //    public static double CelsiusToFahrenheit(double celsius)
    //    {
    //        return (celsius * 9 / 5) + 32;
    //    }


    //    public static double FahrenheitToCelsius(double fahrenheit)
    //    {
    //        return (fahrenheit - 32) * 5 / 9;
    //    }

    //}
    #endregion

    #region Problem06
    //internal class ComplexNumber
    //{

    //    public int Real { get; set; }
    //    public int Imag { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Real} + {Imag}i";
    //    }
    //    //// operator Overloading : 
    //    public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
    //    {
    //        return new ComplexNumber()
    //        {
    //            Real = ((left?.Real ?? 0) * (right?.Real ?? 0)) - ((left?.Imag ?? 0) * (right?.Imag ?? 0)),
    //            Imag = ((left?.Real ?? 0) * (right?.Imag ?? 0)) + ((left?.Imag ?? 0) * (right?.Real ?? 0))
    //        };
    //    }
    //} 
    #endregion

    #region struct Employee
    public struct Employee
    {
        public int Id;
        public string Name;
        public double Salary { get; set; }
        public Department Dept { get; set; }

        public Employee(int _id, string _name, double _salary, Department _dept)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
            Dept = _dept;
        }

        public override string ToString()
        {
            return $"({Id}, {Name}, {Salary} Dept: {Dept})";
        }


        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id &&
                       this.Name == other.Name &&
                       this.Salary == other.Salary&& Equals(this.Dept, other.Dept);
            }
            return false;
        }

        
        // Overloading == 
        public static bool operator ==(Employee Left, Employee Right)
        {
            return Left.Equals(Right);
        }

        // Overloading !=
        public static bool operator !=(Employee Left, Employee Right)
        {
            return !Left.Equals(Right);
        }
    }
    #endregion

    #region Helper2
    public class Helper2
    {
        // 1. Search Method: Returns the index of the first match, or -1 if not found
        public static int SearchArray<T>(T[] Arr, T Value)
        {
            if (Arr == null || Value == null) return -1;

            for (int i = 0; i < Arr.Length; i++)
            {

                if (Value.Equals(Arr[i]))
                    return i;
            }
            return -1;
        }
        // 2. Max Method: Returns the greater value using IComparable constraint
        public static T Max<T>(T left, T right) where T : IComparable<T>
        {

            if (left.CompareTo(right) > 0)
                return left;

            return right;
        }
        // 3. Replace Method: Modifies array in place by replacing oldValue with newValue

        public static void ReplaceArray<T>(T[] Arr, T oldValue, T newValue)
        {
            if (Arr == null) return;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != null && Arr[i].Equals(oldValue))
                {
                    Arr[i] = newValue;
                }
            }
        }

        // 4.Part2. Reverse Method: Returns a new array with elements in reverse order
        public static T[] ReverseArray<T>(T[] array)
        {
            if (array == null) return null;

            T[] reversed = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }

            return reversed;
        }
        // 5. Swap Method: Swaps two elements in an array at specified indices
        public static void SwapArrayElements<T>(T[] array, int index1, int index2)
        {
            // Bounds check to avoid IndexOutOfRangeException
            if (array == null || index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
            {
                return;
            }

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        // 6. MaxArray Method: Returns the maximum element in an array using IComparable constraint
        public static T MaxArray<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr == null || Arr.Length == 0) return default(T);

            T max = Arr[0];

            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] != null && Arr[i].CompareTo(max) > 0)
                {
                    max = Arr[i];
                }
            }

            return max;
        }
    }
    #endregion


    #region  Struct Rectangle
    //public struct Rectangle
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }

    //    public Rectangle(double _Length, double _Width)
    //    {
    //        Length = _Length;
    //        Width = _Width;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Length: {Length}, Width: {Width}";
    //    }
    //} 
    #endregion

    #region class Department
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public Department(int deptId, string deptName)
        {
            DeptId = deptId;
            DeptName = deptName;
        }

        // Overriding Equals to check value equality for Department
        public override bool Equals(object obj)
        {
            if (obj is Department other)
            {
                return this.DeptId == other.DeptId && this.DeptName == other.DeptName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DeptId, DeptName);
        }

        public override string ToString()
        {
            return $"DeptId: {DeptId}, DeptName: {DeptName}";
        }
    }
    #endregion

    #region CircleStruct
    // 1. Struct Implementation
    public struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        // Operator Overloading == & != for Struct
        public static bool operator ==(CircleStruct left, CircleStruct right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CircleStruct left, CircleStruct right)
        {
            return !left.Equals(right);
        }
    }
    #endregion

    #region CircleClass
    // 2. Class Implementation (Default Behavior)
    public class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
    }
    #endregion

    #region  CustomStack<T>
    public class CustomStack<T>
    {
        private T[] items;
        private int top;

        public CustomStack(int capacity = 10)
        {
            items = new T[capacity];
            top = -1;
        }

        // Push: Add item to top of stack
        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }
            items[++top] = item;
        }

        // Pop: Remove and return item from top of stack
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top--];
        }

        // Peek: Return top item without removing it
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    } 
    #endregion

    internal class Program
        {

        #region Problem01
        //enum Weekdays
        //{
        //    Monday = 1,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday
        //}
        #endregion

        #region Problem02
        //enum Grades : short
        //    {
        //        F = -1,
        //        D, 
        //        C, 
        //        B, 
        //        A  
        //    } 
        #endregion

        #region Problem07
        //enum Gender :byte
        //{ 

        //   Male,
        //   Female
        // } 
        #endregion

        #region Non Generic Swap for Rectangle
        //public static void Swap(ref Rectangle X, ref Rectangle Y)
        //{
        //    Rectangle Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        #endregion

        static void Main(string[] args)
            {

            #region test-problem01
            //for (int i = 1; i <= 5; i++)
            //{
            //    Weekdays day = (Weekdays)i;
            //    Console.WriteLine($"Day: {day}, Value: {i}");
            //}
            #endregion

            #region Test-Problem02
            //for (short i = -1; i <= 3; i++)
            //{
            //    Grades grade = (Grades)i;
            //    Console.WriteLine($"Grade: {grade}, Value: {i}");
            //} 
            #endregion

            #region Test-Problem03
            //Person p01 = new Person();
            //p01.Department = "Hr";

            //Person p02 = new Person();
            //p02.Department = "IT";
            //Console.WriteLine($"Person 1 Department:{p01.Department}");
            //Console.WriteLine($"Person 2 Department:{p02.Department}"); 
            #endregion

            #region Test-Peoblem04
            //Child childobj = new Child();
            //childobj.Salary = 10000;
            //childobj.DisplaySalary(); 
            #endregion

            #region Test-Problem05
            //double result = Utility.CalcRectangle(5, 8);
            //Console.WriteLine($"CalcRectangle:{result}"); 
            #endregion

            #region Test-Problem06
            //ComplexNumber c1 = new ComplexNumber { Real = 2, Imag = 3 };
            //ComplexNumber c2 = new ComplexNumber { Real = 4, Imag = 5 };
            //ComplexNumber c3 = c1 * c2;

            //Console.WriteLine($"Result: {c3.Real} + {c3.Imag}i"); 
            #endregion

            #region Test-Problem07
            //Type underlyingType = Enum.GetUnderlyingType(typeof(Gender));
            //Console.WriteLine($"Underlying type of Gender is: {underlyingType.Name}"); 
            #endregion

            #region Test-problem08
            //double fahrenheit = Utility.CelsiusToFahrenheit(25);
            //Console.WriteLine($"25°C = {fahrenheit}°F");

            //double celsius = Utility.FahrenheitToCelsius(77);
            //Console.WriteLine($"77°F = {celsius}°C"); 
            #endregion

            #region Test-Problem09

            //Employee[] employees = new Employee[]
            //{
            //new Employee { Id = 101, Name = "Ahmed", Salary = 5000 },
            //new Employee { Id = 102, Name = "Sara", Salary = 7000 }
            //};

            //Employee searchTarget = new Employee { Id = 101, Name = "Ahmed", Salary = 5000 };


            //int index = Helper2<Employee>.SearchArray(employees, searchTarget);

            //Console.WriteLine($"Employee Index: {index}"); 
            #endregion

            #region Test-Problem10
            //int maxInt = Helper2.Max(10, 25);
            //Console.WriteLine($"Max Int: {maxInt}");

            //// 2. double
            //double maxDouble = Helper2.Max(15.5, 8.2);
            //Console.WriteLine($"Max Double: {maxDouble}");

            //// 3. string 
            //string maxString = Helper2.Max("Apple", "Zebra");
            //Console.WriteLine($"Max String: {maxString}");
            #endregion

            #region Test-Problem11
            //int[] numbers = { 1, 2, 3, 2, 4, 2 };
            //Helper2.ReplaceArray(numbers, 2, 99);
            //Console.WriteLine("Array after replace (int):");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("----------------------------------");
            //string[] names = { "Ali", "Omar", "Ali", "Sara" };
            //Helper2.ReplaceArray(names, "Ali", "Hassan");
            //Console.WriteLine("Array after replace (string):");
            //foreach (string name in names)
            //{
            //    Console.Write(name + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Test-Problem12
            //Rectangle r1 = new Rectangle(10, 5);
            //Rectangle r2 = new Rectangle(20, 15);

            //Console.WriteLine($"Before Swap -> R1: {r1} | R2: {r2}");

            //// Call Swap method
            //Swap(ref r1, ref r2);

            //Console.WriteLine($"After Swap  -> R1: {r1} | R2: {r2}"); 
            #endregion

            #region Test-problem13
            //Department hr = new Department(10, "HR");
            //Department it = new Department(20, "IT");

            //Employee[] empArray = new Employee[]
            //{
            //    new Employee(1, "Ahmed", 5000, hr),
            //    new Employee(2, "Sara", 7000, it),
            //    new Employee(3, "Mona", 6000, hr)
            //};


            //Employee target = new Employee(2, "Sara", 7000, it);


            //int index = Helper2.SearchArray(empArray, target);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Found employee at index: {index}");
            //    Console.WriteLine(empArray[index]);
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found");
            //} 
            #endregion

            #region Test-Problem14
            //// --- 1. Struct Comparison (Value Type) ---
            //CircleStruct cs1 = new CircleStruct(5, "Red");
            //CircleStruct cs2 = new CircleStruct(5, "Red");

            //Console.WriteLine("=== Struct Comparison ===");
            //Console.WriteLine($"cs1.Equals(cs2): {cs1.Equals(cs2)}"); 
            //Console.WriteLine($"cs1 == cs2: {cs1 == cs2}");           

            //Console.WriteLine();

            //// --- 2. Class Comparison (Reference Type) ---
            //CircleClass cc1 = new CircleClass(5, "Red");
            //CircleClass cc2 = new CircleClass(5, "Red");

            //Console.WriteLine("=== Class Comparison ===");
            //Console.WriteLine($"cc1.Equals(cc2): {cc1.Equals(cc2)}"); 
            //Console.WriteLine($"cc1 == cc2: {cc1 == cc2}");            
            #endregion

            #region Test-part2-Problem1
            //// --- Test Integer Array ---
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] reversedNumbers = Helper2.ReverseArray(numbers);

            //Console.WriteLine("Reversed Integers:");
            //foreach (var num in reversedNumbers)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine("\n");

            //// --- Test String Array ---
            //string[] names = { "Ahmed", "Sara", "Omar" };
            //string[] reversedNames = Helper2.ReverseArray(names);

            //Console.WriteLine("Reversed Strings:");
            //foreach (var name in reversedNames)
            //{
            //    Console.Write(name + " ");
            //} 
            #endregion

            #region Test-part2-Problem2
            //// Test with integers
            //CustomStack<int> numbersStack = new CustomStack<int>(5);
            //numbersStack.Push(10);
            //numbersStack.Push(20);
            //numbersStack.Push(30);

            //Console.WriteLine($"Top item (Peek): {numbersStack.Peek()}"); // Output: 30
            //Console.WriteLine($"Popped item: {numbersStack.Pop()}");       // Output: 30
            //Console.WriteLine($"New top item: {numbersStack.Peek()}");     // Output: 20

            //// Test with strings
            //CustomStack<string> namesStack = new CustomStack<string>(5);
            //namesStack.Push("Ahmed");
            //namesStack.Push("Sara");

            //Console.WriteLine($"Popped name: {namesStack.Pop()}");          // Output: Sara 
            #endregion

            #region Test-part2-Problem3
            //// --- Test SwapArrayElements ---
            //int[] numbers = { 10, 20, 30, 40 };

            //Console.Write("Before Swap: ");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //// Swap element at index 1 (20) with element at index 3 (40)
            //Helper2.SwapArrayElements(numbers, 1, 3);

            //Console.Write("After Swap: ");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region Test-part2-Problem4
            //// --- Test MaxArray with Integers ---
            //int[] numbers = { 15, 42, 8, 99, 23 };
            //int maxNum = Helper2.MaxArray(numbers);
            //Console.WriteLine("Max Integer: " + maxNum);

            //// --- Test MaxArray with Strings ---
            //string[] names = { "Ahmed", "Sara", "Ziad", "Mona" };
            //string maxName = Helper2.MaxArray(names);
            //Console.WriteLine("Max String: " + maxName); 
            #endregion


        }
    }

}
