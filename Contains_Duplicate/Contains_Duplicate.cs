public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> numbers = new HashSet<int>();

        foreach (int num in nums)
        {
            if(numbers.Contains(num))
            {
                return true;
            }
            numbers.Add(num);
        }
        return false;
    }
}
