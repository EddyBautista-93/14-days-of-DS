using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        //------------------------------------------------------------------
        //Day 2 - Two Sum
        // Given an array of integers nums and an integer target,
        // return indices of
        // the two numbers such that they add up to target.
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numberAndComplement = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - (int)nums[i];

                if (numberAndComplement.ContainsValue(complement))
                {
                    int[] vs = { numberAndComplement.FirstOrDefault(x => x.Value == complement).Key, i };
                    return vs;
                }
                numberAndComplement.Add(i, nums[i]);
            }
            return new int[] { 0, 0 };
        }
    

    private static void Main(string[] args)
    {
        // Contains Duplicate
        int[] testArrayOne = { 1, 5, -2, -4, 0 };
        ContainsDuplicate(testArrayOne);

        //Two Sum
        int[] twoSumArr = { 2, 7, 11, 15 };
        TwoSum(twoSumArr, 9);
    }
}
}