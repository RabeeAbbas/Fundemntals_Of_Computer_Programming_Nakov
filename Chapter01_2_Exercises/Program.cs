using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_2_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1 - Get familiar with MSDN 

            /*
             * Install and make yourself familiar with Microsoft Visual Studio and 
             * Microsoft Developer Network (MSDN) Library Documentation.
             */

            #endregion

            #region Exercise 2 - System.Console documentaion (API)

            /* Find the description of the System.Console class in the standard.NET
             * API documentation (MSDN Library).
             */

            /* documentation is found on the following link 
             * https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0
             */
            #endregion

            #region Exercise 3 _ Console.WriteLine() Overloads

            /*Find the description of the System.Console.WriteLine() method and its 
             * different possible parameters in the MSDN Library.
             */


            /*
             * WriteLine()  ==>   Writes the current line terminator to the standard output stream.
             * WriteLine(Boolean) ==> Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream.
             * WriteLine(Char) ==> Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.
             * WriteLine(Char[]) ==> Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.
             * WriteLine(Char[], Int32, Int32) ==> Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.
             * WriteLine(Decimal) ==> Writes the text representation of the specified Decimal value, followed by the current line terminator, to the standard output stream.
             * WriteLine(Double) ==> Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream.
             * WriteLine(Int32)	==> Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.
             * WriteLine(Int64) ==> Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream.
             * WriteLine(Object) ==> Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
             * WriteLine(Single) ==> Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream.
             * WriteLine(String) ==> Writes the specified string value, followed by the current line terminator, to the standard output stream.
             * WriteLine(String, Object) ==> Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.
             * WriteLine(String, Object, Object) ==> Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.
             * WriteLine(String, Object, Object, Object) ==> Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.
             * WriteLine(String, Object[]) ==> Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.
             * WriteLine(UInt32) ==> Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream.
             * WriteLine(UInt64) ==> Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream.
             */


            #endregion

            #region Exercsise 4 _ Compile And Execute 

            /*Compile and execute the sample program from this chapter using the 
             * command prompt (the console) and Visual Studio.
             */

            #endregion region 

            #region Exercise 5 _ Modify to "Good Day"

            ///*Modify the sample program to print a different greeting, for example "Good Day!".
            // */

            //Console.WriteLine("Good Day");

            #endregion

            #region Exercise 6 _ Print Name

            ///* Write a console application that prints your first and last name on the console.
            // */

            //Console.WriteLine("Hello Rabee Abbas");


            #endregion

            #region Exercise 7 _ Print Numbers

            ///*
            // * Write a program that prints the following numbers on the console 1, 
            // * 101, 1001, each on a new line
            // * 
            // */

            //Console.WriteLine(1);
            //Console.WriteLine(101);
            //Console.WriteLine(1001);


            #endregion

            #region Exercise 8 _ Current Date and Time

            ///* Write a program that prints on the console the current date and time.
            // */

            //Console.WriteLine(DateTime.Now);

            #endregion

            #region Exercise 9 _ Square Root

            ////9. Write a program that prints the square root of 12345.


            //Console.WriteLine(Math.Sqrt(12345));  //111.108055513541

            #endregion

            #region Exercise 10 _ Print first 100 members of sequence

            ///*  10. Write a program that prints the first 100 members of the sequence 2, 
            // *       - 3, 4, -5, 6, -7, 8.
            // */

            //// solution : 
            //int num = 2;

            //for (int i = 0; i < 100; i++)
            //{
            //    //print number 
            //    Console.WriteLine($"{num,4}");

            //    //increase number 
            //    num = num > 0 ? num + 1 : num - 1;

            //    //change sign
            //    num *= -1;
            //}


            #endregion

            #region Exercise 11 _ Print Age After 10 years

            ///*11. Write a program that reads your age from the console and prints your age after 10 years.
            // */


            //// solution : 
            ////===========
            //Console.Write("Enter your age ");
            //int age = int.Parse(Console.ReadLine());
            //int ageAfter10Years = age + 10;
            //Console.WriteLine("your age after 10 years is : " + ageAfter10Years);


            #endregion

            #region Exercise 12 _ Difference C# and .Net

            /*
             * 11. Write a program that reads your age from the console and prints your age after 10 years.
             */



            #endregion

            #region Exercise 13 _ Most Popular Programming Languages

            /*
             * 13. Make a list of the most popular programming languages. How are they different from C#?
             */

            #endregion

            #region Exercise 14 _ Decompile

            /*
             * 14. Decompile the example program from exercise 5.
             */

            #endregion


        }
    }
}
