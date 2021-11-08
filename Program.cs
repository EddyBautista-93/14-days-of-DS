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

        //--------------------------------------------------------------
        // Day 3 - Intersect
        // Given two integer arrays nums1 and nums2, return an
        // array of their intersection.Each element in the
        // result must appear as many times as it shows in
        // both arrays and you may return the result in any
        // order.
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> intersectedList = new List<int>();
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            foreach (int x in nums1)
            {
                try
                {
                    myDict.Add(x, 1);
                }
                catch
                {
                    myDict[x]++;
                }
            }

            foreach (int x in nums2)
            {
                if (myDict.ContainsKey(x) && myDict[x] > 0)
                {
                    myDict[x]--;
                    intersectedList.Add(x);
                }
            }

            return intersectedList.ToArray();
        }


        // Day 4 Best Time to Buy and Sell Stock
        // You are given an array prices where prices[i] is the price of a given stock on the ith day.

        // You want to maximize your profit by choosing a single day to buy one stock and choosing a 
        // different day in the future to sell that stock.

        // Return the maximum profit you can achieve from this transaction. If you cannot achieve any 
        // profit, return 0.
        public int MaxProfit(int[] prices)
        {

            return 0;
        }

        private static void Main(string[] args)
        {
            // Contains Duplicate
            int[] testArrayOne = { 1, 5, -2, -4, 0 };
            //ContainsDuplicate(testArrayOne);

            //Two Sum
            int[] twoSumArr = { 2, 7, 11, 15 };
            //TwoSum(twoSumArr, 9);

            //Intersect
            int[] intersectArr1 = { 1, 2, 2, 1 };
            int[] intersectArr2 = { 2, 2, 5, 1 };
            Intersect(intersectArr1, intersectArr2);
        }
    }
}