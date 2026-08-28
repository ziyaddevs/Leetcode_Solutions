// Uses a HashSet to store all numbers in the array, 
// then loops from 1 to n and checks which numbers are missing. 
// If a number isn’t in the HashSet, it gets added to the result list.
// Pattern: HashSet for fast Contains() checks. Time: O(n), Space: O(n).
using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        
        HashSet<int> numbers = new HashSet<int>();
        List<int> result = new List<int>();

        foreach(int number in nums)
        {
            numbers.Add(number);
        }

        for(int i = 1; i <= nums.Length; i++)
        {
            if(!numbers.Contains(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
    
    public static void Main(string[] args)
    {
        int[] nums = {4,3,2,7,8,2,3,1};
        Solution solution = new Solution();
        IList<int> result = solution.FindDisappearedNumbers(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    
    }
}