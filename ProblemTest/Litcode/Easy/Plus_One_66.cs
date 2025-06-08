using ConsoleProject.Litcode.Easy.Plus_One_66;

namespace ProblemTest.Litcode.Easy;

public class Plus_One_66
{
    private readonly DataSet[] _dataSets =
    {
        new DataSet(new int[]{1,2,3}, new int[]{1,2,4}),
        new DataSet(new int[]{4,3,2,1}, new int[]{4,3,2,2}),
        new DataSet(new int[]{9}, new int[]{1,0}),
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void PlusOneTest()
    {
        var solution = new Solution();
        foreach (DataSet item in _dataSets)
        {
            int[] result = solution.PlusOne(item.Input);
            Assert.That(result.SequenceEqual(item.Output),
            $"Result: '{String.Join('-', result)}', output: '{String.Join('-', item.Output)}'.");
        }
        Assert.Pass();
    }

    class DataSet
    {
        public readonly int[] Input;
        public readonly int[] Output;

        public DataSet(int[] input, int[] output)
        {
            Input = input;
            Output = output;
        }
    }
}
