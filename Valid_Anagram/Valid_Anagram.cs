public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        
        Dictionary<char, int> countMap = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(!countMap.ContainsKey(c))
            {
                countMap[c] = 1;
            }
            else
            {
                countMap[c]++;
            }
        }

        foreach(char c in t)
        {
            if(!countMap.ContainsKey(c) || countMap[c] == 0)
            {
                return false;
            }
            countMap[c]--;
        }
        return true;
    }
}