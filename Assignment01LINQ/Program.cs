using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace Task01
{

    #region Class Extensions
    public static class Extensions
    {
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            string cleanStr = str.ToLower();

            int left = 0;
            int right = cleanStr.Length - 1;

            while (left < right)
            {
                if (cleanStr[left] != cleanStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;

            if (number == 2) return true;

            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
    #endregion

    #region class Employee
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string _name, double _salary)
        {
            Name = _name;
            Salary = _salary;
        }
    } 
    #endregion
    internal class Program
    {

        #region  Helper Method
        // Helper Method to print the list using a loop
        private static void PrintList(List<string> list)
        {
            foreach (string name in list)
            {
                Console.WriteLine($"- {name}");
            }
        } 
        #endregion
        static void Main(string[] args)
        {
            //Part 1 — Implicitly Typed Local Variables (var)
            #region Problem01
            ////decler five variabules using 'var'
            //var i = 5;      //int 
            //var s = "Mostafa";  // string
            //var d = 33.6;  //  double
            //var arra = new int[]{ 1,2,3,4}; //array
            //var b = true;  //bool

            //// 2:Print the type of each using GetType()
            //Console.WriteLine($"int type: {i.GetType()}");
            //Console.WriteLine($"text type: {s.GetType()}");
            //Console.WriteLine($"Double  type: {d.GetType()}");
            //Console.WriteLine($"Bool type: {b.GetType()}");
            //Console.WriteLine($"numbersArray type: {arra.GetType()}"); 
            #endregion

            #region Problem02
            //// 1. Explicitly Typed Variables
            //int ageExplicit = 20;
            //string nameExplicit = "Mostafa";
            //double salaryExplicit = 7500.50;
            //bool isEmployedExplicit = true;

            //// 2. Implicitly Typed Variables (using var)
            //var ageImplicit = 20;
            //var nameImplicit = "Mostafa";
            //var salaryImplicit = 7500.50;
            //var isEmployedImplicit = true;

            ///*
            // * Explanation:
            // * The result is exactly the same at compile time because C# is a statically-typed language.
            // * When using 'var', the compiler automatically infers (deduces) the variable's type 
            // * based on the right-hand side value during compilation.
            // * Therefore, both approaches generate the exact same IL (Intermediate Language) code.
            // */

            //Console.WriteLine($"Explicit Type: {ageExplicit.GetType()} | Implicit Type: {ageImplicit.GetType()}"); 
            #endregion

            //Part 2 — Anonymous Types:
            #region Probelm01
            //// 1. Create an anonymous type representing a Product
            //var product = new
            //{ 
            //  Name = "LapTop",
            //  Price =18000.00,
            //  Quantity = 4,
            //};
            //Console.WriteLine($" Product Name :{ product.Name}");
            //Console.WriteLine($"Product Price :{product.Price}");
            //Console.WriteLine($"Product Quantity: {product.Quantity}"); 
            #endregion

            #region Problem02
            //// 1. Create an array of 3 anonymous objects representing students
            //var students = new[]
            //{
            //    new { Name = "Mostafa", Grade = 95 },
            //    new { Name = "Ahmed", Grade = 88 },
            //    new { Name = "Ali", Grade = 92 }
            //};

            //// 2. print each student's details
            //Console.WriteLine("Students List:");
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Name: {student.Name} :: Grade: {student.Grade}");
            //} 
            #endregion

            // Part 3 — Extension Methods
            #region Problem01
            //string word1 = "madam";
            //string word2 = "racecar";
            //string word3 = "hello";

            //Console.WriteLine($"Is '{word1}' Palindrome? {word1.IsPalindrome()}");
            //Console.WriteLine($"Is '{word2}' Palindrome? {word2.IsPalindrome()}");
            //Console.WriteLine($"Is '{word3}' Palindrome? {word3.IsPalindrome()}");
            #endregion

            #region Problem02
            //int num1 = 7;
            //int num2 = 12;
            //int num3 = 1;
            //int num4 = 29;

            //Console.WriteLine($"Is {num1} Prime? {num1.IsPrime()}");
            //Console.WriteLine($"Is {num2} Prime? {num2.IsPrime()}");
            //Console.WriteLine($"Is {num3} Prime? {num3.IsPrime()}");
            //Console.WriteLine($"Is {num4} Prime? {num4.IsPrime()}"); 
            #endregion

            // Part 4 — Collections: List, Hashtable, Dictionary

            #region Problem01
            //// 1. Create a List<string> for employee names and Add items
            //List<string> employeeNames = new List<string>();
            //employeeNames.Add("Mostafa");
            //employeeNames.Add("Ahmed");
            //employeeNames.Add("Ali");
            //employeeNames.Add("Sara");

            //Console.WriteLine("Initial Employees List:");
            //PrintList(employeeNames);

            //Console.WriteLine("\n-----------------------------\n");

            //// 2. Remove a name from the list
            //string nameToRemove = "Ali";
            //employeeNames.Remove(nameToRemove);
            //Console.WriteLine($"Removed '{nameToRemove}' from the list.");

            //Console.WriteLine("\n-----------------------------\n");

            //// 3. Search for a name using a loop 
            //string searchName = "Mostafa";
            //bool isFound = false;

            //foreach (string name in employeeNames)
            //{
            //    if (name == searchName)
            //    {
            //        isFound = true;
            //        break;
            //    }
            //}

            //if (isFound)
            //{
            //    Console.WriteLine($"Search Result: Employee '{searchName}' was found in the list.");
            //}
            //else
            //{
            //    Console.WriteLine($"Search Result: Employee '{searchName}' was not found.");
            //}

            //Console.WriteLine("\n-----------------------------\n");

            //// 4. Print the final list
            //Console.WriteLine("Final Employees List:");
            //PrintList(employeeNames); 
            #endregion

            #region Problem02
            //// 1. Create a List of Employee objects
            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee("Mostafa", 8500.0),
            //    new Employee("Ahmed", 4500.0),
            //    new Employee("Sara", 6200.0),
            //    new Employee("Omar", 3800.0)
            //};

            //double targetSalary = 5000.0;

            //Console.WriteLine($"Employees with salary above {targetSalary}:");
            //Console.WriteLine("----------------------------------------");

            //// 2. Loop through the list and filter using foreach loop 
            //foreach (Employee emp in employees)
            //{
            //    if (emp.Salary > targetSalary)
            //    {
            //        Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary} EGP");
            //    }
            //} 
            #endregion

            //  Short Write-Ups
            #region Part-5
            //1.In your own words, what is the difference
            //between a delegate and a lambda expression?

            //Answer:
            // A Delegate is a type definition that specifies
            // a method signature. 
            //A Lambda Expression is a concise syntax used
            //to write inline anonymous functions that
            //fulfill a delegate's signature.

            //---------------------------------------------- -

            //2.Why is var still statically typed
            //even though the type isn't written explicitly?

            //Answer:
            //`var` is statically typed because the C# compiler 
            //infers the exact variable type at compile time
            //based on the assigned value. 
            //Once assigned, the type is fixed and cannot be
            //changed at runtime.

            //-----------------------------------------------

            //3.Give one real scenario where an anonymous
            //type is more convenient than creating a full class.

            //Answer:
            //When shaping temporary data for a single display
            //or projection(such as combining a Product Name
            //and Total Price to print to the console)
            //without needing to reuse the structure across
            //other methods or files. 
            #endregion






        }
    }
}
