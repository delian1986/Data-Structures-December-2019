using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurences
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToList();

            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurrences.ContainsKey(numbers[i]))
                {
                    occurrences.Add(numbers[i], 0);
                }

                occurrences[numbers[i]] += 1;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (occurrences[numbers[i]] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
