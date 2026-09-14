// Pattern: Two Sum
// Dictionary / Hash Map
// Idea: for each number, calculate target - current number. If I've already seen that number, return the indices.
// complexity: O(n) time, O(n) space

public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seenMap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int currentNum = num[i];
            int complement = target - num[i];

            if(!seenMap.ContainsKey(complement))
            {
                seenMap[CurrentNum] = i;
            }
            else
            {
                return new int[] {seenMap[complement], i};
            }
            return new int[] {};
        }

    }
    
}



        // Dictionary<int, int> seenMap = new Dictionary<int, int>();

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     int currentNum = nums[i];
        //     int complement =  target - currentNum;

        //     if(!seenMap.ContainsKey(complement))
        //     {
        //         // no
        //         seenMap[currentNum] = i;
        //     }
        //     else
        //     // yes
        //     return new int[] {seenMap[complement], i};
        //     }
        //     return new int[] {};







        // int res = 0;
        // for(int i = 0; i < nums.Length; i++)
        // {
        //     for(int j = i + 1; j < nums.Length; j++)
        //     {
        //         res = nums[i] + nums[j];
        //         if(res == target)
        //         {
        //             return new int[] {i,j};
        //         }
        //     }
        // }

        // throw new ArgumentException("No two sum solution exists.");