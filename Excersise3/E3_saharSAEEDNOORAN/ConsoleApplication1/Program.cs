/* 
* CST8333-350 Programming Language Research Project
* Author: Sahar Saeednooran
* Exercise3 : sample syntax
*/
using System;
namespace Exersise3
{
    /// <summary>
    /// Sample class program that shows the syntax for 
    /// variable declaration
    /// primitive vs reference types
    /// decision structures
    /// repetition structures
    /// arithmetic, comparison, and logic operators
    /// Memory management is not coverd since .Net's garbage collector automaticly manages it.
    /// https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/
    /// </summary>
    public class Exercise3
    {
        const int MAX_VALUE = 50; // constant declaration
        /// <summary>
        /// Calculates factorial using for loop repetition.
        /// </summary>
        /// <param name="num"> input Integer </param>
        /// <returns> Factorial of input number </returns>
        public long CalculateFactorial(int num) // pass parameter by value
        {
            long factorial = 0;
            if (num < 0) // decision structure
            {
                Console.WriteLine("Factorial is undefined for negative number");
            }
            else if (num >= 0 && num < MAX_VALUE) // comparison, and logical operations
            {
                factorial = 1;
                for (int i = 1; i <= num; i++)
                    factorial = factorial * i; // arithmetic operators
            }
            else
                Console.WriteLine("I'm just a simple program, {0} is too big for me", num);

            return factorial;
        }
        /// <summary>
        /// calculates square of input number
        /// numer passed by Reference
        /// </summary>
        /// <param name="num"></param>
        public void squareByRefrence(ref int num) // pass parameter by reference

        {
            int temp = num;
            num *= num;
            Console.WriteLine("{0} Square = {1}", temp, num);
        }
        /// <summary>
        /// calculates square of input number
        /// numer passed by value
        /// </summary>
        /// <param name="num"></param>
        public void squareByValue(int num) // pass parameter by value

        {
            int temp = num;
            num *= num;
            Console.WriteLine("{0} Square = {1}", temp, num);
        }
    }
    /// <summary>
    /// Class containing the Main method to execute the program
    /// </summary>
    class ExecuteExersise3
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // local variables
            int userInt;
            int userOption;
            bool repeat = true;
            Console.WriteLine(" \n\t Sahar Saeednooran ");
            Exercise3 e3 = new Exercise3(); //reference variable
            while (repeat) // while repeat structure
            {
                Console.WriteLine("Enter a number");
                userInt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("what do you want to know about {0}", userInt);
                Console.WriteLine(" 1: {0}!\n 2: {0} Square (by ref)\n 3: {0} Square (by val)\n 4: Exit ", userInt);
                userOption = Convert.ToInt32(Console.ReadLine());
                switch (userOption) // switch decision structure
                {
                    case 1:
                        Console.WriteLine("{0}! = {1}", userInt, e3.CalculateFactorial(userInt));
                        break;
                    case 2:
                        e3.squareByRefrence(ref userInt);
                        break;
                    case 3:
                        e3.squareByValue(userInt);
                        break;
                    case 4:
                        repeat = false;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("your input number was {0}", userInt); // to demonstrate by ref or by value
            }
        }

    }

}
