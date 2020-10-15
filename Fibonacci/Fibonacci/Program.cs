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
            int fibNumberPlace = 0;
            int firstNum = 0;
            int secondNum = 1;
            int result = 0;
            const int MAX_VALUE = 46; // Fibonacci numbers get very big fast, prevent overflows.
            bool isValid = false;
            
            //Get the input
            do
            {
                Console.Write("Select a fibonacci number up to a max of 46: ");
                try
                {
                    fibNumberPlace = int.Parse(Console.ReadLine());

                    //The program wont crash, the value will overflow and go negative
                    //Prevent out of range inputs
                    if (fibNumberPlace > MAX_VALUE || fibNumberPlace <= 0)
                    {
                        Console.WriteLine("Out of acceptable range");
                    }
                    else
                    {
                        //If this evaluates, the number is valid
                        isValid = true;
                        Console.Write("\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Not acceptable input");
                }
            } while (!isValid);
            
            //Print the first numbers 0 and 1 first
            Console.Write("|{0, 12} |{1, 12} ", firstNum, secondNum);

            //loop for how many fibonacci numbers user wants
            //first + second = result
            for (int i = 2; i <= fibNumberPlace ; i++)
            {
                //Print only 10 values to a line
                if (i % 5 == 0)
                {
                    //Format into a table
                    Console.Write("|\n");//column
                    for (int j = 71; j > 0; j--)
                    {
                        Console.Write("-");//table row
                    }
                    Console.Write("\n");
                }

                //add the 2 numbers and assign to result
                result = firstNum + secondNum;
                
                //swap the values
                firstNum = secondNum;
                secondNum = result;
                
                //print the result
                Console.Write("|{0, 12} ", result);
            }
            Console.Write("|\n"); //This is to make the table look complete, otherwise not important
        }
    }
}
