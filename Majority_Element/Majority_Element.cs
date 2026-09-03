
public class Solution
{
    public static void Main(string[] args)
    {
        int[] nums = { 3, 2, 3 };
        Solution solution = new Solution();
        int result = solution.MajorityElement(nums);
        Console.WriteLine($"Majority element is: {result}");
    }

    public int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (candidate == num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return candidate;
    }
}