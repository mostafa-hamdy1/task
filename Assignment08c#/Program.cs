using System;

namespace Task08
{
    internal class Program
    {
        #region paet02 Helper Methods
        //public static void PrintTenShapes(IShapeSeries series)
        //{
        //    series.ResetSeries();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"Area {i + 1}: {series.CurrentShapeArea}");
        //        series.GetNextArea();
        //    }
        //} 
        #endregion

        #region Part02_Peoblem04
		        //public static void SelectionSort(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length - 1; i++)
        //    {
        //        int minIndex = i;
        //        for (int j = i + 1; j < numbers.Length; j++)
        //        {
        //            if (numbers[j] < numbers[minIndex])
        //            {
        //                minIndex = j;
        //            }
        //        }
        //        int temp = numbers[minIndex];
        //        numbers[minIndex] = numbers[i];
        //        numbers[i] = temp;
        //    } 
	     #endregion
        
        static void Main(string[] args)
        {
            // Test Part01
            #region test problem1
            //IVehicle myCar = new Car();
            //myCar.StartEngine();
            //myCar.StopEngine();

            //IVehicle myBike = new Bike();
            //myBike.StartEngine();
            //myBike.StopEngine(); 
            #endregion

            #region test Problem 02
            //Shape rect = new Rectangle(5, 4);
            //rect.Display();

            //Shape circle = new Circle(3);
            //circle.Display();
            #endregion

            #region test problem3
            //Product[] products = {
            //    new Product(1, "Laptop", 1500),
            //    new Product(2, "Mouse", 25),
            //    new Product(3, "Keyboard", 50)
            //};


            //Array.Sort(products);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region test Problem4

            //Student student1 = new Student(1, "Mostafa", 95.5);

            //Student shallowCopy = student1;

            //Student deepCopy = new Student(student1);


            //student1.Name = "Ali";


            //Console.WriteLine($"Original: {student1}");    // Name will be Ali
            //Console.WriteLine($"Shallow:  {shallowCopy}");  // Name will change to Ali (Affected!)
            //Console.WriteLine($"Deep:     {deepCopy}");     // Name stays Mostafa (Safe!)
            #endregion

            #region test Problem5
            //Robot myRobot = new Robot();
            //myRobot.Walk();

            //IWalkable walker = myRobot;
            //walker.Walk();
            #endregion

            #region test Problem6
            //Account acc = new Account(101, "Mostafa", 5000m);
            //Console.WriteLine(acc);
            //acc.Balance = 7500m;
            //Console.WriteLine($"Updated Balance: {acc.Balance}");
            //acc.Balance = -1000m;
            //Console.WriteLine($"After Invalid Update: {acc.Balance}");
            #endregion

            #region test Problem7
            //Book book1 = new Book();

            //Book book2 = new Book("C# Programming");


            //Book book3 = new Book("Clean Code", "Robert C. Martin");

            //Console.WriteLine(book1);
            //Console.WriteLine(book2);
            //Console.WriteLine(book3);
            #endregion

            //===================
            // Test Part02
            //===================
            #region Part 02 - test Problem01
            //IShapeSeries squares = new SquareSeries();
            //Console.WriteLine("--- Square Series ---");
            //PrintTenShapes(squares);

            //IShapeSeries circles = new CircleSeries();
            //Console.WriteLine("\n--- Circle Series ---");
            //PrintTenShapes(circles);
            #endregion

            #region Part 02 - test peoblem02

            //            Shape[] shapes = {
            //    new Shape("Circle", 78.5),
            //    new Shape("Square", 16.0),
            //    new Shape("Rectangle", 24.0)
            //};

            //Array.Sort(shapes);

            //foreach (var shape in shapes)
            //{
            //    Console.WriteLine(shape);
            //}
            #endregion

            #region Part 02 _test Problem04
            //int[] areas = { 64, 16, 25, 4, 9 };
            //SelectionSort(areas);

            //Console.WriteLine("Sorted Areas using Selection Sort:");
            //foreach (var area in areas)
            //{
            //    Console.Write(area + " ");
            //}
            #endregion

        }
      


        }

    //Part01
    #region Problem01
    //public interface IVehicle
    //{
    //    void StartEngine();
    //    void StopEngine();
    //}
    //public class Car : IVehicle
    //{
    //    public void StartEngine()
    //    {
    //        Console.WriteLine("Car engine started.");
    //    }

    //    public void StopEngine()
    //    {
    //        Console.WriteLine("Car engine stopped.");
    //    }
    //}
    //public class Bike : IVehicle
    //{
    //    public void StartEngine()
    //    { 
    //        Console.WriteLine("Bike engine started.");
    //    }
    //    public void StopEngine() 
    //    { 
    //        Console.WriteLine("Bike engine stopped."); 
    //    }
    //} 
    #endregion

    #region Problem02
    //public abstract class Shape
    //{
    //    public abstract double GetArea();

    //    public void Display()
    //    {
    //        Console.WriteLine($"Shape Area: {GetArea()}");
    //    }
    //}
    //public class Rectangle : Shape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public Rectangle(double _width, double _height)
    //    {
    //        Width = _width;
    //        Height = _height;
    //    }

    //    public override double GetArea()
    //    {
    //        return Width * Height;
    //    }
    //}
    //public class Circle : Shape
    //{
    //    public double Radius { get; set; }

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public override double GetArea()
    //    {
    //        return Math.PI * Radius * Radius;
    //    }
    //} 
    #endregion

    #region Problem03
    //public class Product : IComparable
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public decimal Price { get; set; }


    //    public Product(int _id, string _name, decimal _price)
    //    {
    //        Id = _id;
    //        Name = _name;
    //        Price = _price;
    //    }


    //    public int CompareTo(object obj)
    //    {

    //        Product other = (Product)obj;


    //        if (this.Price > other.Price)
    //        {
    //            return 1;  
    //        }
    //        else if (this.Price < other.Price)
    //        {
    //            return -1; 
    //        }
    //        else
    //        {
    //            return 0;  
    //        }
    //    }


    //    public override string ToString()
    //    {
    //        return $"{Name} - Price: {Price}";
    //    }
    //} 
    #endregion

    #region Problem04
    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Grade { get; set; }

    //    // 1. المشيد العادي لتجهيز الطالب أول مرة
    //    public Student(int _id, string _name, double _grade)
    //    {
    //        Id = _id;
    //        Name = _name;
    //        Grade = _grade;
    //    }


    //    public Student(Student other)
    //    {
    //        if (other != null)
    //        {
    //            this.Id = other.Id;
    //            this.Name = other.Name;
    //            this.Grade = other.Grade;
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        return $"Student [Id={Id}, Name={Name}, Grade={Grade}]";
    //    }
    //} 
    #endregion

    #region problem05
    //public interface IWalkable
    //{
    //    void Walk();
    //}
    //public class Robot : IWalkable
    //{

    //    public void Walk()
    //    {
    //        Console.WriteLine("Robot is walking using internal tracks.");
    //    }
    //    void IWalkable.Walk()
    //    {
    //        Console.WriteLine("IWalkable explicit step.");
    //    }
    //} 
    #endregion

    #region Problem06
    //public struct Account
    //{
    //    private int accountId;
    //    private string accountHolder;
    //    private decimal balance;

    //    public int AccountId
    //    {
    //        get { return accountId; }
    //        set { accountId = value; }
    //    }

    //    public string AccountHolder
    //    {
    //        get { return accountHolder; }
    //        set { accountHolder = value; }
    //    }

    //    public decimal Balance
    //    {
    //        get { return balance; }
    //        set
    //        {
    //            if (value >= 0)
    //                balance = value;
    //        }
    //    }

    //    public Account(int accountId, string accountHolder, decimal balance)
    //    {
    //        this.accountId = accountId;
    //        this.accountHolder = accountHolder;
    //        this.balance = balance >= 0 ? balance : 0;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Account [ID={accountId}, Holder={accountHolder}, Balance={balance:C}]";
    //    }
    //} 
    #endregion

    #region Problem07
    //public class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }

    //    public Book(string title, string author)
    //    {
    //        Title = title;
    //        Author = author;
    //    }
    //    public Book(string title) : this(title, "Unknown")
    //    {
    //    }

    //    public Book() : this("Untitled", "Unknown")
    //    {
    //    }

    //    public override string ToString()
    //    {
    //        return $"Book [Title: '{Title}', Author: '{Author}']";
    //    }
    //} 
    #endregion

    //========================================
    // Part02
    //========================================
    #region Part02 Problem01
    //public interface IShapeSeries
    //{
    //    int CurrentShapeArea { get; set; }
    //    void GetNextArea();
    //    void ResetSeries();
    //}
    //public class SquareSeries : IShapeSeries
    //{
    //    private int sideLength = 1;
    //    public int CurrentShapeArea { get; set; }

    //    public SquareSeries()
    //    {
    //        CurrentShapeArea = sideLength * sideLength;
    //    }

    //    public void GetNextArea()
    //    {
    //        sideLength++;
    //        CurrentShapeArea = sideLength * sideLength;
    //    }

    //    public void ResetSeries()
    //    {
    //        sideLength = 1;
    //        CurrentShapeArea = sideLength * sideLength;
    //    }
    //}
    //public class CircleSeries : IShapeSeries
    //{
    //    private int radius = 1;
    //    public int CurrentShapeArea { get; set; }

    //    public CircleSeries()
    //    {
    //        CurrentShapeArea = (int)(Math.PI * radius * radius);
    //    }

    //    public void GetNextArea()
    //    {
    //        radius++;
    //        CurrentShapeArea = (int)(Math.PI * radius * radius);
    //    }

    //    public void ResetSeries()
    //    {
    //        radius = 1;
    //        CurrentShapeArea = (int)(Math.PI * radius * radius);
    //    }
    //} 
    #endregion

    #region Part02 Problem02
    //public class Shape : IComparable
    //{
    //    public string Name { get; set; }
    //    public double Area { get; set; }

    //    public Shape(string name, double area)
    //    {
    //        Name = name;
    //        Area = area;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        Shape other = (Shape)obj;
    //        if (this.Area > other.Area) return 1;
    //        if (this.Area < other.Area) return -1;
    //        return 0;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} - Area: {Area}";
    //    }
    //} 
    #endregion

    #region Part02 _Problem03
    //public abstract class GeometricShape
    //{
    //    public double Dimension1 { get; set; }
    //    public double Dimension2 { get; set; }

    //    public abstract double CalculateArea();
    //    public abstract double Perimeter { get; }
    //}
    //public class Triangle : GeometricShape
    //{
    //    public Triangle(double baseLength, double height)
    //    {
    //        Dimension1 = baseLength; 
    //        Dimension2 = height;     
    //    }

    //    public override double CalculateArea()
    //    {
    //        return 0.5 * Dimension1 * Dimension2;
    //    }

    //    public override double Perimeter
    //    {
    //        get { return Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); }
    //    }
    //}
    //public class RectangleShape : GeometricShape
    //{
    //    public RectangleShape(double width, double height)
    //    {
    //        Dimension1 = width;
    //        Dimension2 = height;
    //    }

    //    public override double CalculateArea()
    //    {
    //        return Dimension1 * Dimension2;
    //    }

    //    public override double Perimeter
    //    {
    //        get { return 2 * (Dimension1 + Dimension2); }
    //    }
    //} 
    #endregion

 

    

    }
