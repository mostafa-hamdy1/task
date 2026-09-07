using System;

namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test Problem 1
            // --- Test Problem 1 ---
            Car c1 = new Car();
            Car c2 = new Car(101);
            Car c3 = new Car(102, "Toyota");
            Car c4 = new Car(103, "BMW", 50000m);
            #endregion

            #region Testing Calculator
            //// 2. Testing Calculator Overloading
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Sum(10, 20));
            //Console.WriteLine(calc.Sum(10, 20, 30));
            //Console.WriteLine(calc.Sum(10.5, 20.5));
            #endregion

            #region  Testing Problem 3, 4 & 5: Parent & Child Classes 
            // 3. Testing Parent and Child Chaining & Polymorphism
            Parent p1 = new Parent(3, 4);
            Child ch1 = new Child(3, 4, 5);

            Console.WriteLine(p1.ToString());  // Output: (3, 4)
            Console.WriteLine(ch1.ToString()); // Output: (3, 4, 5)

            // Dynamic / Static Binding Test with 'new'
            Parent pRef = new Child(2, 3, 4);
            Console.WriteLine(pRef.Product()); // Calls Parent's Product -> Output: 6 
            #endregion
        }
    }

    #region Problem01
    // Problem 1: Car Class with Overloaded Constructors
    // ==========================================
    public class Car
    {
        #region attributes
        private int id;
        private string brand;
        private decimal price;
        #endregion

        #region Properties
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Constructors

        // 1. General Constructor (Full parameters)
        public Car(int _Id, string _Brand, decimal _Price)
        {
            id = _Id;
            brand = _Brand;
            price = _Price;
        }

        // 2. Constructor with 2 parameters (Id, Brand) 
        public Car(int _Id, string _Brand) : this(_Id, _Brand, 0)
        {
            id = _Id;
            brand = _Brand;
            price = 0;
        }

        // 3. Constructor with 1 parameter (Id) 
        public Car(int _Id) : this(_Id, "Toyota", 200000)
        {
            id = _Id;
            brand = "Toyota";
            price = 200000;
        }

        // 4. Default Constructor (No parameters) -> calls General Constructor with default values
        public Car() : this(0, "Unknown", 0)
        {
        }

        #endregion

        #region Methods
        // Methos
        public override string ToString()
        {
            return $"Id is {id}, Name brand is {brand}, price is {price}";
        }
        #endregion

    }
    #endregion

    #region Problem02
    //// ==========================================
    //// Problem 2: Calculator Class (Method Overloading)
    //public class Calculator
    //{
    //    // Overload 1: Add two integers
    //    public int Sum(int _Num1, int _Num2)
    //    {
    //        return _Num1 + _Num2;
    //    }

    //    // Overload 2: Add three integers
    //    public int Sum(int _Num1, int _Num2, int _Num3)
    //    {
    //        return _Num1 + _Num2 + _Num3;
    //    }

    //    // Overload 3: Add two doubles
    //    public double Sum(double _Num1, double _Num2)
    //    {
    //        return _Num1 + _Num2;
    //    }
    //} 
    #endregion

    #region Problem 3, 4 & 5: Parent & Child Classes
    // ==========================================
    // Problem 3, 4 & 5: Parent & Child Classes
    public class Parent
    {
        #region attributes
        private int x;
        private int y;
        #endregion

        #region Properties
        public int X
        { get => x; set => x = value; }
        public int Y
        { get => y; set => y = value; }
        #endregion

        #region Parent Constructors

        // General Constructor
        public Parent(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        }

        // Default Constructor chaining
        public Parent() : this(0, 0)
        {
        }

        #endregion

        #region Method
        // Methods
        public virtual int Product()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
        #endregion
    }

    public class Child : Parent
    {
        #region attributes
        private int z;
        #endregion

        #region Properties
        public int Z
        { get => z; set => z = value; }
        #endregion

        #region Child Constructors (Base Chaining)

        // General Constructor -> Chaining to Parent General Constructor
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            z = _Z;
        }

        // Constructor Chaining locally then to Base
        public Child(int _X, int _Y) : this(_X, _Y, 0)
        {
            // z = 0;
        }

        #endregion

        #region Method
        // 1. Method Hiding using 'new'
        public new int Product()
        {
            return X * Y * z;
        }
        // 2. ToString Overriding
        public override string ToString()
        {
            return $"({X}, {Y}, {z})";
        }
        #endregion


    } 
    #endregion

}
