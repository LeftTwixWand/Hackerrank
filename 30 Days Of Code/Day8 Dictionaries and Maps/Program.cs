using System;
using System.Collections.Generic;

namespace Day8_Dictionaries_and_Maps
{
    // https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Dictionary<string, string> phones = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                phones[line[0]] = line[1];
            }

            string name;
            while ((name = Console.ReadLine()) != null)
            {
                if (phones.ContainsKey(name))
                    Console.WriteLine(name + "=" + phones[name]);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}