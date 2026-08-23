using System;
using System.Transactions;

namespace Day01Giza02
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Problem1
            ///*
            //    -Program Purpose:
            //    -this code segment initialize two integer variables (x and y),
            //    - calculates their sum,and disblays the result on the console screen. 
            //*/

            //// Declare and initialize the first variable 'x' with value 10
            //int x = 10;
            //// Declare and initialize the second variable 'y' with value 120
            //int y = 20;
            //// Add x and y , then store the result in 'sum'
            //int sum = x + y;
            //// Print the final calculated sum to the console output
            //Console.WriteLine(sum);
            #endregion

            #region Problem2

            //// 1. Fixing the data type: remove quotes so it's an integer
            //int x = 10;

            //// 2. Declare and initialize 'y' before using it
            //int y = 20;

            //// 3. Fix 'Console' casing (Capital 'C')
            //Console.WriteLine(x + y); 
            #endregion

            #region Problem3
            //// 1. Full Name (string - camelCase)
            //string fullName = "Mustafa Hamdy Ismail";

            //// 2. Age 
            //int age = 20;

            //// 3. Monthly Salary (decimal is best )
            //decimal monthlySalary = 0000.00m; 

            //// 4. Whether you are a student (bool)
            //bool isStudent = true;
            ////Disblaying the variables value on the console screen
            //Console.WriteLine(fullName);
            //Console.WriteLine(age);
            //Console.WriteLine(monthlySalary);
            //Console.WriteLine(isStudent); 
            #endregion

            #region Problem4

            ///*
            // * Purpose: 
            // * Demonstrates that changing the value of a reference type
            // * affects all reference variables pointing to that same object on the Heap.
            // */

            //// Define a reference type
            //Person person1 = new Person();
            //person1.Name = "Mustafa";

            //// Copying reference: person2 now points to the SAME Heap object as person1
            //Person person2 = person1;

            //Console.WriteLine("--- Before Modification ---");
            //Console.WriteLine($"person1.Name: {person1.Name}"); // Output: Mustafa
            //Console.WriteLine($"person2.Name: {person2.Name}"); // Output: Mustafa

            //// Modify the object value using 'person2'
            //person2.Name = "Ahmed";

            //Console.WriteLine("\n--- After Modifying via person2 ---");
            //Console.WriteLine($"person1.Name: {person1.Name}"); // Output: Ahmed (Affected!)
            //Console.WriteLine($"person2.Name: {person2.Name}"); // Output: Ahmed

            #endregion

            #region Problem5

            ///*
            // * Purpose: 
            // * Calculates Sum, Difference, Product, Division result, and Remainder
            // * using x = 15 and y = 4.
            // */

            //int x = 15;
            //int y = 4;

            //// 1. Sum 
            //int sum = x + y;

            //// 2. Difference 
            //int difference = x - y;

            //// 3. Product 
            //int product = x * y;

            //// 4. Division result  -  للحصول على الناتح العشري المظبوط double  تحويل أحدهما لـ
            //double division = (double)x / y;

            //// 5. Remainder 
            //int remainder = x % y;

            //// Print Results
            //Console.WriteLine($"Sum: {sum}");            
            //Console.WriteLine($"Difference: {difference}"); 
            //Console.WriteLine($"Product: {product}");       
            //Console.WriteLine($"Division Result: {division}"); 
            //Console.WriteLine($"Remainder: {remainder}");  

            #endregion

            #region Problem6

            ///*
            // * Purpose: 
            // * Checks if a given number is both greater than 10 AND even
            // * using boolean expression directly.
            // */

            //int number = 14;


            //bool isGreaterThanTenAndEven = (number > 10) && (number % 2 == 0);

            //Console.WriteLine($"Is {number} greater than 10 and even? {isGreaterThanTenAndEven}");

            #endregion

            #region Problem7

            ///*
            // * Purpose: 
            // * Takes a double input from user and demonstrates explicit casting (double -> int)
            // * and implicit casting (int -> double).
            // */

            //Console.Write("Enter a double number (e.g. 15.75): ");
            //double userDouble = Convert.ToDouble(Console.ReadLine());

            //// 1. Explicit Casting (Narrowing: double -> int)
            //int explicitInt = (int)userDouble;

            //// 2. Implicit Casting (Widening: int -> double
            //double implicitDouble = explicitInt;

            //// Print Results
            //Console.WriteLine($"\nOriginal Input (double): {userDouble}");
            //Console.WriteLine($"Explicitly Cast to (int): {explicitInt}");
            //Console.WriteLine($"Implicitly Cast back to (double): {implicitDouble}");

            #endregion

            #region Problem8

            ///*
            // * Purpose: 
            // * Reads age as a string, converts it using int.Parse, 
            // * and validates if age > 0.
            // */

            //// 1. Prompt user for age as a string
            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();

            //// 2. Convert string to integer using Parse
            //int age = int.Parse(ageInput);

            //// 3. Check if age is valid (greater than 0)
            //bool isValidAge = age > 0;

            //// Print results
            //Console.WriteLine($"Age = {age}");
            //Console.WriteLine($"Is Age Valid? {isValidAge}");

            #endregion

            #region Problem9

            ///*
            // * Purpose: 
            // * Demonstrates the difference between Prefix (++x) and Postfix (x++)
            // * increment operators using variable x.
            // */

            //// 1. Postfix Increment (x++) -> Print then Increment
            //int x = 5;
            //Console.WriteLine("--- Postfix Demonstration (x++) ---");
            //Console.WriteLine($"Value used in expression (x++): {x++}"); // Output: 5
            //Console.WriteLine($"Actual value of x after line: {x}\n");     // Output: 6

            //// 2. Prefix Increment (++x) -> Increment then Print
            //x = 5; // Reset x back to 5
            //Console.WriteLine("--- Prefix Demonstration (++x) ---");
            //Console.WriteLine($"Value used in expression (++x): {++x}"); // Output: 6
            //Console.WriteLine($"Actual value of x after line: {x}");     // Output: 6

            #endregion


        }
    }
}
