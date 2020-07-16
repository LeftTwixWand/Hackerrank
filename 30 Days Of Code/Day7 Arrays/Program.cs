using System;
using System.Collections;
using System.Linq;

namespace Day7_Arrays
{
    // https://www.hackerrank.com/challenges/30-arrays
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Array.ForEach(Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp)).Reverse().ToArray(), item => Console.Write($"{item} "));
        }
    }
}