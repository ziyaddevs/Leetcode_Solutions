public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Initialize the Two Pointers
        int left = 0;
        int right = numbers.Length - 1;

        // Loop while left pointer hasn't crossed the right pointer
        while(left < right)
        {
            int currentSum = numbers[left] + numbers[right];

            if(currentSum == target)
            {
                return new int[] {left + 1, right + 1};
            }
            else if (currentSum < target)
            {
                left++; // need a bigger sum
            }
            else
            {
                right--; // need a smaller sum
            }
        }
        return new int[0];
    }
}