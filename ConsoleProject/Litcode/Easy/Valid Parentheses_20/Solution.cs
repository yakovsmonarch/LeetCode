namespace ConsoleProject.Litcode.Easy.Valid_Parentheses_20;

public class Solution
{
    private readonly Dictionary<char, char> _dict = new Dictionary<char, char> {
        {'{', '}'},
        {'(', ')'},
        {'[', ']'}
    };

    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 > 0) return false;

        var validId = new Dictionary<int, int>();

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (_dict.ContainsKey(s[i]) == false) continue;

            char close = _dict[s[i]];
            bool ok = false;

            for (int j = i + 1; j < s.Length; j++)
            {
                if (validId.ContainsKey(j)) continue;

                if (s[j] == close)
                {
                    validId.Add(i, j);
                    ok = true;
                    break;
                }
            }

            if (ok == false) return false;
        }

        return true;
    }
}
