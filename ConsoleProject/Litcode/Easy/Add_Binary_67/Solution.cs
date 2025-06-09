namespace ConsoleProject.Litcode.Easy.Add_Binary_67;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        UInt32
            numA = Convert.ToUInt32(a, 2),
            numB = Convert.ToUInt32(b, 2);
        UInt32 result = numA + numB;
        
        return Convert.ToString(result, 2);
    }
}
