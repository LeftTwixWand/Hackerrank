using System;
using System.IO;

namespace Day9_Recursion
{
    class Program
    {
        // Complete the factorial function below.
        static int factorial(int n) => n == 1 ? 1 : n * factorial(n - 1);

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
