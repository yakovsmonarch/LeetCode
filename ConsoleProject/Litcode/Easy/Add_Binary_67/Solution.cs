using System.Numerics;

namespace ConsoleProject.Litcode.Easy.Add_Binary_67;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        BigInteger
            bigA = BigInteger.Parse("0" + a, System.Globalization.NumberStyles.AllowBinarySpecifier),
            bigB = BigInteger.Parse("0" + b, System.Globalization.NumberStyles.AllowBinarySpecifier);
        BigInteger res = bigA + bigB;

        return res.ToString("B").TrimStart('0');
    }
}