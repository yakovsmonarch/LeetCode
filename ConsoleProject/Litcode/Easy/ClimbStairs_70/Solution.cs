namespace ConsoleProject.Litcode.Easy.ClimbStairs_70;

public class Solution
{
    /// <summary>
    /// You are climbing a staircase. 
    /// It takes n steps to reach the top. 
    /// Each time you can either climb 1 or 2 steps. 
    /// In how many distinct ways can you climb to the top?
    /// Constraints: 1 <= n <= 45
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int ClimbStairs(int n)
    {
        if (n == 1)
        {
            return n;
        }

        int maxNumberTwos = n / 2;
        int result = 1;

        for (int numberTwos = 1; numberTwos <= maxNumberTwos; numberTwos++)
        {
            int numberCells = numberTwos + n - (numberTwos * 2);
            int numberCombinations = (numberCells - numberTwos + 1) * numberCells / 2;

            if (numberCombinations == 0)
            {
                result += 1;
            }
            else
            {
                result += numberCombinations;
            }
        }

        return result;
    }

    // Input 4: 1111 211 22
}
