using System;
using System.Linq;
using System.Collections.Generic;

namespace EncoraInsperity
{
    public class Program
    {
        static readonly char EMPTY_CHAR = '\\';
        static void Main()
        {
            Console.WriteLine("Insert a string a custom string to be sort: ");
            var input = Console.ReadLine();
            var result = SortingOperations(input);
            Console.WriteLine($"Result: {result}");
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
