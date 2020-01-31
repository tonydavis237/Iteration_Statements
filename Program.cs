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
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to run iterative statements
                int value = int.Parse(input);
                // for loop to display the users entered value and the current value in the loop
                if ((value >= 1) && (value <= 100))
                {
                     for (int count = 1; count <= value; count++)
                     {
                         // Display entered user value and current integer value in the loop
                         Console.WriteLine("You have entered " + value.ToString() + ". " + "This is the current integer value in the loop: " + count.ToString());
                         
                     }
                }

                else
                {
                            Console.WriteLine("You have entered an integer not in the restricted parameters");
                            Console.WriteLine("Please enter an integer between the values of 1 and 100 and try again");
                            Console.WriteLine("To try again, exit the program by pressing any key");
                }

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
