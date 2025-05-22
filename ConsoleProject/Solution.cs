using System.Text;

namespace ConsoleProject;

public class Solution
{
    private readonly Dictionary<string, int> _intNumber = new Dictionary<string, int>()
    {
        {"I", 1 },
        {"V", 5 },
        {"X", 10 },
        {"L", 50 },
        {"C", 100 },
        {"D", 500 },
        {"M", 1000 }
    };

    private readonly Dictionary<string, int> _diff = new Dictionary<string, int>()
    {
        {"IV", 4},
        {"IX", 9},
        {"XL", 40},
        {"XC", 90},
        {"CD", 400},
        {"CM", 900}
    };

    private readonly Dictionary<int, string> _romans = new Dictionary<int, string>()
    {
        {0, ""},
        {1, "I"},
        {2, "II"},
        {3, "III"},
        {4, "IV"},
        {5, "V"},
        {6, "VI"},
        {7, "VII"},
        {8, "VIII"},
        {9, "IX"},

        {10, "X"},
        {20, "XX"},
        {30, "XXX"},
        {40, "XL"},
        {50, "L"},
        {60, "LX"},
        {70, "LXX"},
        {80, "LXXX"},
        {90, "XC"},

        {100, "C"},
        {200, "CC"},
        {300, "CCC"},
        {400, "CD"},
        {500, "D"},
        {600, "D"},
        {700, "DC"},
        {800, "DCC"},
        {900, "CM"},

        {1000, "M"},
        {2000, "MM"},
        {3000, "MMM"},
        {4000, "MMMM"},
        {5000, "MMMMM"},
        {6000, "MMMMMM"},
        {7000, "MMMMMMM"},
        {8000, "MMMMMMMM"},
        {9000, "MMMMMMMMM"},
    };

    public int RomanToInt(string s)
    {
        int sum = 0;
        const string compaer = "-";

        foreach (KeyValuePair<string, int> item in _diff)
        {
            if (s.Contains(item.Key) == false) continue;

            sum += item.Value;
            s = s.Replace(item.Key, compaer);
        }

        s = s.Replace(compaer, string.Empty);

        foreach (char romCh in s)
        {
            sum += _intNumber[romCh.ToString()];
        }

        return sum;
    }

    public string IntToRoman(int num)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int digits = (int)Math.Log10(num);
        int divider = (int)Math.Pow(10, digits);

        for (; divider > 0; divider /= 10)
        {
            int decNum = (num / divider) * divider;
            num = num % divider;
            string rom = _romans[decNum];
            stringBuilder.Append(rom);
        }

        return stringBuilder.ToString();
    }
}