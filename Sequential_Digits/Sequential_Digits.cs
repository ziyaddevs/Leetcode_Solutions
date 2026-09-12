public class Solution {
    public IList<int> SequentialDigits(int low, int high)
    {
        var digits = "123456789";
        List<int> result = new List<int>();

        for(int length = 1; length <= 9; length++)
        {
            for(int i = 0; i + length <= digits.Length; i++)
            {
                var sub = digits.Substring(i, length);
                var num = int.Parse(sub);
                if(num >= low && num <= high)
                {
                    result.Add(num);
                }
                else if(num > high)
                {
                    break;
                }
            }
        }
        return result;
    }
}
