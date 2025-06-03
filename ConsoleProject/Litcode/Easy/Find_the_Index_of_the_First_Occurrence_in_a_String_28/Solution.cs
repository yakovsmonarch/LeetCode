using System.Data;

namespace ConsoleProject.Litcode.Easy.Find_the_Index_of_the_First_Occurrence_in_a_String_28;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length) return -1;

        int charNeedleId = needle[0];
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] != charNeedleId) continue;
            if (haystack.Length - i + 1 < needle.Length) continue;

            bool ok = true;
            for (int id = i, j = 0; j < needle.Length; id++, j++)
            {
                if (haystack[id] != needle[j])
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                return i;
            }
        }
        return -1;
    }
}
