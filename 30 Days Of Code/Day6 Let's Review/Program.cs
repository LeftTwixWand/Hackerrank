using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6_Let_s_Review
{
    // https://www.hackerrank.com/challenges/30-review-loop
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            List<char> chars = new List<char>();
            int amount;
            int.TryParse(Console.ReadLine(), out amount);

            for (int i = 0; i < amount; i++)
            {
                text = Console.ReadLine();
                chars.Clear();
                chars.Add(' ');

                for (int j = 0; j < text.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        chars.Insert(chars.IndexOf(' '), text[j]);
                    }
                    else
                    {
                        chars.Add(text[j]);
                    }
                }
                Console.WriteLine(chars.ToArray());
            }
        }
    }
}