using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Day11_2D_Arrays
{
    static class Program
    {   
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int[,] newArr = new int[6,6];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    newArr[i, j] = arr[i][j];
                }
            }

            Console.WriteLine(Enumerable.Max(GetMatrices(newArr, 3).Select(item => item.Cast<int>().MySum())));
        }

        public static int MySum(this IEnumerable<int> source)
        {
            var array = source.ToArray();

            return array[0] + array[1] + array[2] + array[4] + array[6] + array[7] + array[8];
        }

        public static IEnumerable<int[,]> GetMatrices(int[,] array, int blockSize)
        {
            for (int i = 0; i <= array.GetLength(0) - blockSize; i++)
                for (int j = 0; j <= array.GetLength(1) - blockSize; j++)
                    yield return GetBlock(array, i, j, blockSize);
        }
       
        static int[,] GetBlock(int[,] array, int i, int j, int size)
        {
            int[,] block = new int[size, size];

            for (int bi = 0; bi < size; bi++)
                for (int bj = 0; bj < size; bj++)
                    block[bi, bj] = array[i + bi, j + bj];

            return block;
        }
    }
}
