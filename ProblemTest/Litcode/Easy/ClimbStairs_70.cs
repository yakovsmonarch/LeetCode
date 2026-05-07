using ConsoleProject.Litcode.Easy.ClimbStairs_70;

namespace ProblemTest.Litcode.Easy;

public class ClimbStairs_70
{
    private DataSet[] _dataSets;

    [SetUp]
    public void Setup()
    {
        _dataSets = DataSet.GenetateData();
    }

    [Test]
    public void AddBinaryTest()
    {
        var solution = new Solution();

        foreach (DataSet dataSet in _dataSets)
        {
            int result = solution.ClimbStairs(dataSet.Input);
            Assert.That(result == dataSet.Output, $"Ожидается: {dataSet.Output}, получено: {result}");
        }

        Assert.Pass();
    }

    class DataSet
    {
        public static DataSet[] GenetateData()
        {
            return new DataSet[]
            {
                new DataSet(1, 1),
                new DataSet(2, 2),
                new DataSet(3, 3)
            };
        }

        public readonly int Input;
        public readonly int Output;

        public DataSet(int input, int output)
        {
            Input = input;
            Output = output;
        }
    }
}
