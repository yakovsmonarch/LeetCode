using System.IO.Pipelines;

namespace ConsoleProject.Litcode.Easy.Valid_Parentheses_20;

public class Solution
{
    private readonly Dictionary<char, char> _openKeys = new Dictionary<char, char> {
        {'{', '}'},
        {'(', ')'},
        {'[', ']'}
    };

    public bool IsValid(string s)
    {
        // return Variant1(s);
        return Variant2(s);
    }

    private bool Variant1(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 > 0) return false;

        var validId = new Dictionary<int, int>();

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (_openKeys.ContainsKey(s[i]) == false) continue;

            char close = _openKeys[s[i]];
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

    private bool Variant2(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 > 0) return false;

        var stack = new Stack<char>();

        foreach (Char ch in s)
        {
            if (GetClose(ch).result)
            {
                stack.Push(ch);
                continue;
            }

            if (stack.Count == 0) return false;
            
            if (GetClose(stack.Pop()).content != ch)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    private (bool result, char content) GetClose(char ch)
    {
        return ch switch
        {
            '(' => (true, ')'),
            '{' => (true, '}'),
            '[' => (true, ']'),
            _ => (false, '\0')
        };
    }
}
