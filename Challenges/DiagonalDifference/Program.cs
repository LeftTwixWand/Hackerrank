using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace DiagonalDifference
{

    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int mainDiagonale = 0, secondatyDiagonale = 0, shift = 0, matrixSize = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.Count >)
                {

                }

            }

            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (arr[i].Count == arr.Count)
            //    {
            //        rightSize = 
            //    }
            //}

            //if (arr[i].Count == arr.Count)
            //{
            //    rightSize = arr.Count;
            //    break;
            //}
            //else 
            //{
            //    rightSize = arr[i].Count;
            //    shift++;

            //}

            //if (arr[i].Count == arr.Count)
            //{
            //    rightSize = arr.Count;
            //    break;
            //}
            //else
            //{
            //    rightSize = arr[i].Count;
            //    shift = i + 1;
            //}

            for (int i = 0; i < arr.Count; i++)
            {
                if ()
                {

                }
            }
            

            for (int i = 0; i < arr.Count; i++)
            {
                mainDiagonale += arr[i][i]; // Summ of main diadonale
                secondatyDiagonale += arr[i][arr[i].Count - 1 - i]; // Sum of secondary diagonale
            }

            return Math.Abs(mainDiagonale - secondatyDiagonale);
        }

    }

    // https://www.hackerrank.com/challenges/diagonal-difference
    class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>()
            {
                //new List<int>() { 3 },
                new List<int>() { 11, 2, 4 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 10, 8, -12 }
            };

           Console.WriteLine(Result.diagonalDifference(arr));
        }
    }
}
