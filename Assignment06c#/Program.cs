using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            ////default constructors
            //Point p01 = new Point();
            //Console.WriteLine(p01);
            //// constructors parameterized
            //Point p02 = new Point(3, 8);
            //Console.WriteLine(p02);

            #endregion

            #region Problem2

            //TypeA t01 = new TypeA();
            //Console.WriteLine(t01.G);
            //// 1. Inaccessible: 
            ////Console.WriteLine(t01.F); 

            //// 2. Accessible: 
            //Console.WriteLine(t01.G);

            //// 3. Accessible: 
            //Console.WriteLine(t01.H); 
            #endregion

            #region Problem3
            //Employee E01 = new Employee();
            //Console.WriteLine(E01);
            //Employee E02 = new Employee(1, "Mostafa", 1200);
            //Console.WriteLine(E02);  
            #endregion

            #region Probelm4 and Probelm5        
            //// ConstructorBuilder Overloding
            // Point P01 = new Point(4);
            // Console.WriteLine(P01);

            // Point P02 = new Point(4,8);
            // Console.WriteLine(P02); 
            #endregion

        }
    }


    #region Probem01
    //public struct Point
    //{
    //  public int y;
    //  public int x;


    //public Point(int _x, int _y)
    //    {
    //        x = _x;
    //        y = _y;
    //    }
    //    public override string ToString()
    //    {
    //        return $"First Coor is {x} and second Coor is  {y}";
    //    }


    //} 
    #endregion

    #region problem02
    //public class TypeA
    //{

    //    private int F;
    //    internal int G;
    //    public int H;


    //    public void Print()
    //    {
    //        Console.WriteLine(F);
    //        Console.WriteLine(G);
    //        Console.WriteLine(H);

    //    }
    //} 
    #endregion

    #region Problem03
    //public struct Employee
    //{
    //    private int EmpId;
    //    private string Name;
    //    private decimal Salary;

    //    // apply encapsualtion use Getter setter
    //    public string GetName()
    //    {
    //        return Name;
    //    }
    //    public int GetEmpId()
    //    {
    //        return EmpId;
    //    }
    //    public void SetName(string value)
    //    {
    //        Name = value.Length < 10 ? value : value.Substring(0, 10);

    //    }
    //    // apply Encapsualtion Using Property :
    //    // full property :
    //    public decimal EmpSalary
    //    {
    //        get { return Salary; }
    //        set { Salary = value < 5000 ? 5000 : value; }
    //    }


    //    public Employee(int _Id, string _Name, decimal _Salary)
    //    {
    //        EmpId = _Id;
    //        Name = _Name;
    //        Salary = _Salary;

    //    }

    //    public override string ToString()
    //    {
    //        return $"Emp Id is {EmpId}, Emp Name is {Name}, Salary is {Salary}";
    //    }
    //}
    #endregion

    #region Problem04 and Problem05
    //public struct Point
    //{
    //    int x,y;


    // public Point(int _x)
    //    {
    //        x= _x;
    //        y = 0;

    //    }
    // public Point(int _x,int _y)
    //    {
    //        x = _x;
    //        y = _y;

    //    }
    //    public override string ToString()
    //    {

    //        return $"first Coor is {x},second Coor is {y}";

    //    }

    //} 
    #endregion

  



}

