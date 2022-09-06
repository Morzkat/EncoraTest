using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static readonly char EMPTY_CHAR = '\\';
        static void Main()
        {
            //CASE 1
            Console.WriteLine("-------------- CASE 1 ---------------");
            Console.WriteLine($"result: {SortingOperations("xyzxy")}");
            Console.WriteLine($"result: {SortingOperations("abaccadcc")}");

            // CASE 2
            Console.WriteLine("-------------- CASE 2 ---------------");
            Console.WriteLine($"result: {SortingOperations("dulgvgzwqg")}");
            Console.WriteLine($"result: {SortingOperations("gxtjtmtywr")}");
            Console.WriteLine($"result: {SortingOperations("hnlnxiupgt")}");

            //CASE 3
            Console.WriteLine("-------------- CASE 3 ---------------");
            Console.WriteLine($"result: {SortingOperations("wzenwebuau")}");
            Console.WriteLine($"result: {SortingOperations("vokfxzynwl")}");

            //CASE 4
            Console.WriteLine("-------------- CASE 4 ---------------");
            Console.WriteLine($"result: {SortingOperations("qakmc")}");
            Console.WriteLine($"result: {SortingOperations("rrtbk")}");
        }

        public static string SortingOperations(string input)
        {
            input = String.Concat(input.OrderBy(x => x));
            var lettersCount = new Dictionary<char, int>();
            var result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (lettersCount.ContainsKey(input[i]))
                    lettersCount[input[i]] += 1;
                else lettersCount.Add(input[i], 1);
            }

            var currentLargestCount = new KeyValuePair<char, int>(EMPTY_CHAR, 0);
            var maxCounter = lettersCount.Count;

            int counter = 0;
            while (lettersCount.Count > 0)
            {
                
                if (counter == maxCounter)
                {
                    result += "".PadLeft(currentLargestCount.Value, currentLargestCount.Key);

                    lettersCount.Remove(currentLargestCount.Key);
                    currentLargestCount = new KeyValuePair<char, int>(EMPTY_CHAR, 0);
                    counter = 0;
                    maxCounter--;
                    continue;
                }

                if (lettersCount.ElementAt(counter).Value > currentLargestCount.Value)
                    currentLargestCount = lettersCount.ElementAt(counter);

                counter++;
            }

            return result;
        }
    }
}
