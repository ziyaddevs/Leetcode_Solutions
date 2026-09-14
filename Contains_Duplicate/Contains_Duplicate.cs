public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seenMap = new HashSet<int>();

        foreach(var val in nums)
        {
            if(!seenMap.Contains(nums))
            {
                seenMap.Add(val);
            }
            return true;
        }
        return false;
    }
}



        // HashSet<int> numbers = new HashSet<int>();

        // foreach (int num in nums)
        // {
        //     if(numbers.Contains(num))
        //     {
        //         return true;
        //     }
        //     numbers.Add(num);
        // }
        // return false;