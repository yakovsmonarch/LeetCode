namespace ProblemTest;

public class ProblemTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ConvertRomanTest()
    {
        var solution = new ConsoleProject.Litcode.Easy.Roman_to_integer_13.Solution();
        int numLimin = 3999;

        for (int i = 1; i <= numLimin; i++)
        {
            string romanNum = solution.IntToRoman(i);
            int num = solution.RomanToInt(romanNum);

            bool result = num == i;
            Assert.That(result, $"Error: i = {i}, num = {num}.");
        }
        Assert.Pass();
    }
}
