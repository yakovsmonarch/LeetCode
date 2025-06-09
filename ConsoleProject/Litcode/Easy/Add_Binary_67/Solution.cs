namespace ConsoleProject.Litcode.Easy.Add_Binary_67;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        return AddBinaryCastom(a, b);
    }

    private string AddBinaryStandart(string a, string b)
    {
        string resultStr = (
                System.Numerics.BigInteger.Parse("0" + a, System.Globalization.NumberStyles.AllowBinarySpecifier) +
                System.Numerics.BigInteger.Parse("0" + b, System.Globalization.NumberStyles.AllowBinarySpecifier)
            ).
            ToString("B");

        if (resultStr.Length == 1)
        {
            return resultStr;
        }

        return resultStr.TrimStart('0');
    }

    private string AddBinaryCastom(string a, string b)
    {
        if (a.Length < b.Length)
            (a, b) = (b, a);

        Func<char, int> charToInt = (char ch) =>
        {
            switch (ch)
            {
                case '0': return 0;
                case '1': return 1;
                default: throw new NotImplementedException();
            }
        };

        char[] resultChars = new char[a.Length + 1];
        int memory = 0;

        for (int i = a.Length - 1, j = b.Length - 1; i >= 0; i--, j--)
        {
            if (j >= 0)
            {
                memory = charToInt(a[i]) + charToInt(b[j]) + memory;
            }
            else
            {
                memory = charToInt(a[i]) + memory;
            }

            switch (memory)
            {
                case 0:
                    resultChars[i] = '0';
                    break;
                case 1:
                    resultChars[i] = '1';
                    memory = 0;
                    break;
                case 2:
                    resultChars[i] = '0';
                    memory = 1;
                    break;
                case 3:
                    resultChars[i] = '1';
                    memory = 1;
                    break;

                default: throw new NotImplementedException();
            }
        }

        if (resultChars[0] == '\0')
        {
            return string.Join(string.Empty, resultChars).Trim('\0');
        }

        // resultChars[0] = memory

        throw new NotImplementedException();

    }
}