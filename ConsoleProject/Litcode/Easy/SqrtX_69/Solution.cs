namespace ConsoleProject.Litcode.Easy.SqrtX_69;

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 1 || x == 0)
        {
            return x;
        }

        return SqrtInt((ulong)x, 0, x);
    }

    private int SqrtInt(ulong x, int start, int end)
    {
        if (end - start == 1)
        {
            return start;
        }

        int b = (end - start) / 2 + start;
        ulong result = (ulong)(b * b);

        if (result == x)
        {
            return b;
        }

        if (result > x)
        {
            return SqrtInt(x, start, b);
        }
        else
        {
            return SqrtInt(x, b, end);
        }
    }
}
