using System;

namespace Day3_Conditional_Statements
{
    // https://www.hackerrank.com/challenges/30-conditional-statements
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (!(N % 2 == 0))
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (N > 20)
                {
                    Console.WriteLine("Not Weird");
                    return;
                }

                if (N >= 6 && N < 20)
                {
                    Console.WriteLine("Weird");
                    return;
                }

                switch (N)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Not Weird");
                        break;
                    default:
                        Console.WriteLine("Weird");
                        break;
                }
            }
        }
    }
}