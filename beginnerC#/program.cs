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
            int runningTotal = 0;
            bool keepGoing = true;
            while (keepGoing) 
            {
                // Prompt user for minutes excerised 
                Console.Write("Enter how many minutes you exercised, or type quit: ");
                string entry = Console.ReadLine();
                // Repeat until user quits 
                if (entry == "quit")
                {
                    keepGoing = false;
                    Console.WriteLine("Goodbye.");
                }
                else
                {
                    // Add minutes exercised to running total
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;
                    // Display total minutes exercised to view
                    // "+" is used to concatenate strings
                    Console.WriteLine("You have exercised " + runningTotal + " minutes.");
                }
            }
        }
    }
}
