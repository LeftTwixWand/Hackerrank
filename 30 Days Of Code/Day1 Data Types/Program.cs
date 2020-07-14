using System;

namespace Day1_Data_Types
{
    class Program
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int myInt;
            double myDouble;
            string myString;

            // Read and save an integer, double, and String to your variables.
            int.TryParse(Console.ReadLine(), out myInt);
            myDouble = double.Parse(Console.ReadLine());
            myString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(myInt + i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine((myDouble + d).ToString("F1"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + myString);
        }
    }
}