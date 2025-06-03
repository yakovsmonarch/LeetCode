using System.Data;

namespace ConsoleProject.Litcode.Easy.Find_the_Index_of_the_First_Occurrence_in_a_String_28;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int charNeedleId = needle[0];
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] != charNeedleId) continue;

            bool ok = true;
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[j] != needle[j])
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
