using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CompareTheTriplets
{
    // https://www.hackerrank.com/challenges/compare-the-triplets
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (!a[i].Equals(b[i]))
                {
                    if (a[i] > b[i])
                    {
                        result[0]++;
                    }
                    else
                    {
                        result[1]++;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
             TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
