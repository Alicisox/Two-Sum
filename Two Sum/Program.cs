using System;
using System.Collections.Generic;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 2, 7, 11, 15 };
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;
            int[] tmp = TwoSum(nums, target);
            if (tmp != null)
            {
                foreach (int v in tmp)
                {
                    Console.WriteLine(v + ": " + nums[v]);
                }
            }
        }

        /// <summary>
        /// Return indices of the two numbers such that they add up to a target.
        /// </summary>
        /// <param>
        /// <c>nums</c> is an array of number to add up to the target.
        /// <c>target</c> is integer of the target.
        /// </param>
        /// <returns>
        /// The array of int indices of the two numbers such that they add up to the target.
        /// </returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new(); 
            for (int i = 0; i < nums.Length; i++)
            {
                // Find complement of target and num i 
                int complement = target - nums[i];
                // Find another complement in dictionary if found, return a pair of numbers in array
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                // Add a part of complement to dictitonary
                dict[nums[i]] = i;
            }
            throw new Exception("Not found two numbers that add up to the target.");
        }
    }
}
