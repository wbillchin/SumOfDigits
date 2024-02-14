/*
 * INFO 350 - Sum of Digits
 * 
 * Sum of Digits
 * 
 * Write a program in C# where user will input a positive integer and
 * the program will call a method that returns the sum of all the digits
 * in that integer. The program displays the result to the user in the main method.
 * 
 * 
 * Modify this code to complete this assignment
 */


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.WriteLine("Type in a number: ");

            // reads in a string from the console
            inputString = Console.ReadLine();

            // checks that we got a string back instead of a null
            // note we have not covered null yet
            if (inputString == null)
            {
                Console.WriteLine("Incorrect input, exiting");
                return;
            }

            // convert the input string to a number
            int inputNumber = Convert.ToInt32(inputString);
            int theSumOfDigits = 9999;


            /*
             * note that below, the " is escaped as \" such that the compiler
             * doesn't mistake it for the end of the string
             */
            Console.WriteLine("The sum of the digits is " + theSumOfDigits);
        }
    }
}