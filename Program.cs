namespace TwoSum
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = solution.TwoSum(nums1, target1);
            Console.WriteLine($"Example 1: [{result1[0]}, {result1[1]}]");

            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            int[] result2 = solution.TwoSum(nums2, target2);
            Console.WriteLine($"Example 2: [{result2[0]}, {result2[1]}]");

            int[] nums3 = { 3, 3 };
            int target3 = 6;
            int[] result3 = solution.TwoSum(nums3, target3);
            Console.WriteLine($"Example 3: [{result3[0]}, {result3[1]}]");



            int[] nums4 = { 3, 3, 4, 6, 3, 2, 10, 1 };
            int target4 = 11;
            int[] result4 = solution.TwoSum2(nums3, target3);
            Console.WriteLine($"Example 3: [{result3[0]}, {result3[1]}]");

        }
    }

    public class Solution
    {
        /// <summary>
        /// Finds two numbers within the 'nums' array that add up to the 'target', and return the indices of these two numbers.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            // This dictionary will be used to store the complement of each element in the array along with its index.
            Dictionary<int, int> result = new Dictionary<int, int>();

            // For each element nums[i], calculate its complement, which is target - nums[i].
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement of the current element
                int complement = target - nums[i];
                // Check if the comlement exists in the dictionary. Of it does, it means we have found the two numbers that sum up to the target, and we can return their indices.
                if (result.ContainsKey(complement))
                {
                    // If the complement is found in the dictionary, return the indices
                    return new int[] { result[complement], i};
                }
                // Otherwise, add the current element along with its index to the dictionary
                // This step effectively stores the complement of each element seen so far
                // This allows us to quickly check if the complement of the current element exists in the array
                result[nums[i]] = i;
            }
            // If no solution is found, return an empty array
            return new int[0];
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { nums[i], nums[j] };
                    }
                }
            }
            return new int[0];
        }
    }
}
