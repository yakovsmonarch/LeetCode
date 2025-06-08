using ConsoleProject.Litcode.Easy.Length_of_Last_Word_58;

namespace ProblemTest.Litcode.Easy;

public class Length_of_Last_Word_58
{
    private readonly DataSet[] _dataSets =
    {
        new DataSet("Hello World", 5),
        new DataSet("   fly me   to   the moon  ", 4),
        new DataSet("luffy is still joyboy", 6),
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void LengthOfLastWordTest()
    {
        var solution = new Solution();

        foreach (DataSet item in _dataSets)
        {
            int result = solution.LengthOfLastWord(item.Input);
            Assert.That(result == item.Output);
        }

        Assert.Pass();
    }

    class DataSet
    {
        public readonly string Input;
        public readonly int Output;

        public DataSet(string input, int output)
        {
            Input = input;
            Output = output;
        }
    }
}
