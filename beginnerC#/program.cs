////////////////////
// general notes //
//////////////////

// mcs compiles code into exe
// mono runs the .exe file
// namespace.class.method = order of names in a method call, such as System.Console.Write

/////////////////

///////////////////
// Fitness Frog //
/////////////////

// removes the need to type system in every method call
using System;

namespace Tutorial.FitnessFrog
{
    class program
    {
        static void Main()
        {
            // Prompt user for minutes excerised 
            Console.Write("Enter how many minutes you exercised: ");
            string entry = Console.ReadLine();

            // Add minutes exercised to running total

            // Display total minutes exercised to view
            // "+" is used to concatenate strings
            Console.WriteLine("You have exercised " + entry + " minutes.");

            // Repeat until user quits
        }
    }
}
