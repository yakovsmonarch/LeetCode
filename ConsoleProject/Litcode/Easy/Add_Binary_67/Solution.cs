using System.Numerics;

namespace ConsoleProject.Litcode.Easy.Add_Binary_67;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        string resultStr = (
                BigInteger.Parse("0" + a, System.Globalization.NumberStyles.AllowBinarySpecifier) +
                BigInteger.Parse("0" + b, System.Globalization.NumberStyles.AllowBinarySpecifier)
            ).
            ToString("B");

        if (resultStr.Length == 1)
        {
            return resultStr;
        }

        return resultStr.TrimStart('0');
    }
}