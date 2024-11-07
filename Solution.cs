using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBeginner
{
    public class Solution
    {
        // #20. Dictionary

        // public int[] TwoSum(int[] nums, int target)
        // {
        //     for(int i = 0; i < nums.Length; i++)
        //     {
        //         for(int j = i + 1; j < nums.Length; j++)
        //         {
        //             if(nums[i] + nums[j] == target)
        //             {
        //                 return new int[] {i, j};
        //             }
        //         }
        //     }
        //     throw new ArgumentException("No solution");
        // }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(dict.ContainsKey(complement))
                {
                    return new int[] {dict[complement], i};
                }
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            throw new ArgumentException("No solution");
        }

        // #21. HashSet

        // public bool ContainsDuplicate(int[] nums)
        // {
        //     for(int i = 0; i < nums.Length; i++)
        //     {
        //         for(int j = i + 1; j < nums.Length; j++)
        //         {
        //             if(nums[i] == nums[j])
        //             {
        //                 return true;
        //             }
        //         }
        //     }
        //     return false;
        // }

        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if(set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;
        }
    }
}