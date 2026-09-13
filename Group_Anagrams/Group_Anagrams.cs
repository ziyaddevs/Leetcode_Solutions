public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> key = new Dictionary<string, List<string>>();
        List<IList<string>> result = new List<IList<string>>();

        foreach(string s in strs)
        {
            char[] sort = s.ToCharArray();
            Array.Sort(sort);
            string sortedKey = new string(sort);

            if(!key.ContainsKey(sortedKey))
            {
                key[sortedKey] = new List<string>();
            }
            key[sortedKey].Add(s);
        }
        
        foreach(var k in key.Values)
        {
            result.Add(k);
        }
        return result;
    }
    
}
 
 
        // // 1. Create our Dictionary: key is the sorted string, Value is the list of original words.
        // //    Sorted string,  Original words
        // Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        // foreach(string s in strs)
        // {
        //     // 2. convert string to char array, sort it, and return it back into a string
        //     char[] charArray = s.ToCharArray();
        //     Array.Sort(charArray);
        //     string sortedKey = new string(charArray);
        //     // 3. If the sorted string is not in the dictionary, create a new list for it
        //     if(!map.ContainsKey(sortedKey))
        //     {
        //         map[sortedKey] = new List<string>();
        //     }
        //     // 4. Add the original word into its corresponding "drawer" list
        //     map[sortedKey].Add(s);
        // }

        // return new List<IList<string>>(map.Values);
