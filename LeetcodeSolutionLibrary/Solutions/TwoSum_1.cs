using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolutionLibrary.Solutions
{
    public class TwoSum_1 : LeetcodeSolutionBase, ILeetcodeSolution
    {
        public int Number => 1;
        public string Title => "Two Sum";

        public string Description => @"
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.";

        public string GenerateSampleResults()
        {
            string results = "";
            getResults(new int[] { 2, 7, 11, 15 }, 9);
            getResults(new int[] { 3, 2, 4 }, 6);
            getResults(new int[] { 3, 3 }, 6);

            void getResults(int[] nums, int target)
            {
                results += $"{getArrayForDisplay(nums)}, {target}: {getArrayForDisplay(TwoSum(nums, target))}\n";
            }

            return results;
        }

        private int[] TwoSum(int[] nums, int target)
        {
            for (int i1 = 0; i1 < nums.Length - 1; i1++)
            {
                for (int i2 = i1 + 1; i2 < nums.Length; i2++)
                {
                    if (nums[i1] + nums[i2] == target)
                        return new int[] { i1, i2 };
                }
            }

            return null;
        }
    }
}
