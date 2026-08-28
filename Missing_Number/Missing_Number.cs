// Uses a HashSet to store the numbers, 
// then loops from 0 to n to find which number is missing. 
// Pattern: HashSet + Contains() for fast lookups. Time: O(n), Space: O(n).
using System;
using System.Collections.Generic;

public class Solution {
    public int MissingNumber(int[] nums)
    {
        HashSet<int> numbers = new HashSet<int>(nums);

        int n = nums.Length;
        for(int i = 0; i <= n; i++)
        {
            if(!numbers.Contains(i))
            {
                return i;
            }   
        }

        return -1;
    }

        public static void Main(string[] args)
        {
            int[] nums = {3,0,1};
            Solution solution = new Solution();
            int result = solution.MissingNumber(nums);
            Console.WriteLine($"Missing number is: {result}");
        }

}