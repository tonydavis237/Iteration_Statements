/*
Author: Anthony Davis
Date: 1/28/2020
Description: Project that uses Iteration Statements by asking the user to input 
                an interger and uses a loop to display until the number matches
*/
using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input an integer
            Console.WriteLine("Enter an integer value between 1 and 100");
            try
            {
                string input = Console.ReadLine();

                int value = int.Parse(input);
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100 and try again...");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            } // Eand of catch
        } // End of Main
    } // End of class
} // End of namespace
