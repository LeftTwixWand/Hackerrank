using System;
using System.Linq;

namespace Day10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).Split('0').Max().Length);
        }
    }
}