namespace ConsoleProject.Litcode.Easy.Longest_Common_Prefix_14;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = "";
        string word = strs[0];

        for (int i = 1; i <= word.Length; i++)
        {
            prefix = word.Substring(0, i);

            for (int j = 0; j < strs.Length; j++)
            {
                if (prefix.Length > strs[j].Length || prefix != strs[j].Substring(0, i))
                {
                    return prefix.Substring(0, i - 1);
                }
            }
        }

        return prefix;
    }
}
