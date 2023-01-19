using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance of random and create arrays
            Random r = new Random();
            int[] rollCount = new int[12];
            string[] histogram = new string[12];


            // print introductory info
            Console.WriteLine("Welcome to the Dice Throwing Simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            // get input for the number of rolls
            int numRolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS ");
            Console.WriteLine("Each ' * ' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);
            Console.WriteLine('\n');


            // loop to simulate rolls and populate the array of values
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = r.Next(6);
                int roll2 = r.Next(6);
                rollCount[roll1 + roll2]++;
            }


            // loop to print the histogram containing information about each number
            for (int j = 1; j < 12; j++)
            {
                float percent = rollCount[j - 1]  * 100 / numRolls;
                int counter = 0;
                histogram[j - 1] = "";
                // the inner loop adds * to an array in order to print them out
                while (counter < percent)
                {
                    histogram[j - 1] += '*';
                    counter++;
                }
                // the actual print line to make the histogram
                Console.WriteLine((j + 1) + ": " + histogram[j - 1]);
            }


            // closing line to end the simulation
            Console.WriteLine('\n');
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
