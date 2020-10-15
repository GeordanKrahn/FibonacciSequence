//Author: Geordan Krahn
//Date: October 14 2020
//Purpose: A fun demonstration of the fibonacci sequence
using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Variables
            //Need a number1 number2 and result
                //Number place to count fib to a certain place
            int fibNumberPlace;
            int firstNum = 0;
            int secondNum = 1;
            int result = 0;

            //Get the input
            Console.WriteLine("How many fibonacci numbers?: ");
            fibNumberPlace = int.Parse(Console.ReadLine());

            //Print the first numbers 0 and 1 first
            Console.Write(firstNum + ", " + secondNum);

            //loop for how many fibonacci numbers user wants
            //first + second = result
            for (int i = 0; i < fibNumberPlace; i++)
            {
                //add the 2 numbers and assign to result
                result = firstNum + secondNum;
                
                //swap the values
                    //number1 = number2
                    //number2 = result
                firstNum = secondNum;
                secondNum = result;

                //print the result
                Console.Write($", {result}");
            }
        }
    }
}
