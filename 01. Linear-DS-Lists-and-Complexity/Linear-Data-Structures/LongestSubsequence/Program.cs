using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            int maxNum = 0;
            int maxCount = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                int currCount = 1;
                for (int j = i+1; j < nums.Count; j++)
                {
                    if (nums[j]==nums[i])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currCount>maxCount)
                {
                    maxNum = nums[i];
                    maxCount = currCount;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum+" ");
            }
            Console.WriteLine();
        }
    }
}
