namespace ConsoleProject.Litcode.Easy.Plus_One_66;

public class Solution
{
    /*
    You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
    The digits are ordered from most significant to least significant in left-to-right order. 
    The large integer does not contain any leading 0's.
    Increment the large integer by one and return the resulting array of digits.
    */

    public int[] PlusOne(int[] digits)
    {
        int counter = 1;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int sum = digits[i] + counter;
            if (sum > 9)
            {
                digits[i] = 0;
                counter = 1;
            }
            else
            {
                digits[i] = sum;
                counter = 0;
                break;
            }
        }

        if (digits[0] == 0)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
        
        return digits;
    }
}