// Pattern: Two Sum
// Dictionary / Hash Map
// Idea: for each number, calculate target - current number. If I've already seen that number, return the indices.
// complexity: O(n) time, O(n) space

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int res = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                res = nums[i] + nums[j];
                if(res == target)
                {
                    return new int[] {i,j};
                }
            }
        }

        throw new ArgumentException("No two sum solution exists.");
    }


        public static void Main(string[] args)
        {
            int[] nums = {2,7,11,15};
            int target = 9;
            Solution solution = new Solution();
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
}