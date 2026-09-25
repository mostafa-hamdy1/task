using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_G01
{
    internal static class IntExtension
    {
        // 1- this Parameters(Extend to what ?)
        // 2- non generic class   3- Static

        // this ? 
        // caller of function 
        // signature of function >> as a parameter 
        public static int Reverse(this int Num)//12345
        {
            int ReversedNum = 0, Remainder;
            while (Num != 0) // 12
            {
                Remainder = Num % 10; // 3
                ReversedNum = ReversedNum * 10 + Remainder; // 543
                Num = Num / 10;  // 12
            }
            return ReversedNum; //54321
        }


        public static long Reverse(this long Num)//12345
        {
            long ReversedNum = 0, Remainder;
            while (Num != 0)
            {
                Remainder = Num % 10; //4
                ReversedNum = ReversedNum * 10 + Remainder; //54321
                Num = Num / 10;  //0.1
            }
            return ReversedNum; //54321
        }

        // 1- this Parameters(Extend to what ?)
        // 2- non generic class   3- Static

        // this ? 
        // caller of function 
        // signature of function >> as a parameter 

        // Design :  Class Parent , interface 
    }
}
