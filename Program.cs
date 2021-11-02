using System.Collections;
using System.Collections.Generic;

namespace _14_days_of_DS
{
    internal class Program
    {
        // Day 1 - Contains Duplicate
        // Given an integer array nums, return true if any value appears
        // at least twice in the array, and return false if every element
        // is distinct.

        public static bool ContainsDuplicate(int[] nums)
        {
            int len = nums.Length;
            if (len == 1) return false;
            List<int> add_list = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if (!add_list.Contains(nums[i]))
                {
                    add_list.Add(nums[i]);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        // Using Hashtable
        public static bool ContainsDup(int[] nums)
        {
            Hashtable hash = new Hashtable();

            foreach (var item in nums)
                if (hash.Contains(item))
                    return true;
                else
                    hash.Add(item, null);

            return false;
        }

        private static void Main(string[] args)
        {
            // Contains Duplicate
            int[] testArrayOne = { 1, 5, -2, -4, 0 };
            ContainsDuplicate(testArrayOne);
        }
    }
}