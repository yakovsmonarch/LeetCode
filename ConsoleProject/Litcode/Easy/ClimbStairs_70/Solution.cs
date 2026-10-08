namespace ConsoleProject.Litcode.Easy.ClimbStairs_70;

public class Solution : ITask
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
            int emptySteps = n - (numberTwos - 1) * 2;
            result += (int)Math.Pow(emptySteps - 1, numberTwos);
        }

        return result;
    }

    public void Run()
    {
        const string Range = "1 до 45 включительно";
        bool isExit = false;

        while (isExit == false)
        {
            Console.Write($"Введите число ступенек от {Range} (выход - 'q'): ");

            string? userInput = Console.ReadLine();
            isExit = userInput?.ToLower() == "q".ToLower();

            if (isExit)
            {
                continue;
            }

            if (int.TryParse(userInput, out int numberSteps) == false)
            {
                Console.WriteLine("Ошибка ввода. Введите еще раз.");
                continue;
            }

            if (numberSteps < 1 || numberSteps > 45)
            {
                Console.WriteLine($"Число '{numberSteps}' не входит в диапазон: {Range}.");
                continue;
            }

            Console.WriteLine($"Вариантов взобраться по лестнице: '{new Solution().ClimbStairs(numberSteps)}'");
        }
    }

    // Input 4: 22 1111 112 211 121
}
