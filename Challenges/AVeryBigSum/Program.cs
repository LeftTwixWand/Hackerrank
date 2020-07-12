using System;
using System.IO;
using System.Linq;

namespace AVeryBigSum
{
    // https://www.hackerrank.com/challenges/a-very-big-sum
    class Program
    {

        // For situations with a vary big sum - ulong.
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar) => ar.Sum();

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}