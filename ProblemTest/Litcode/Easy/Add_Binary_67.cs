using ConsoleProject.Litcode.Easy.Add_Binary_67;

namespace ProblemTest.Litcode.Easy;

public class Add_Binary_67
{
    private readonly DataSet[] _dataSets =
    {
        new DataSet("11", "1", "100"),
        new DataSet("1010", "1011", "10101"),
    };

    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void AddBinaryTest()
    {
        var solution = new Solution();

        foreach (DataSet data in _dataSets)
        {
            string result = solution.AddBinary(data.InputA, data.InputB);
            Assert.That(result == data.Output, $"result = '{result}', output = '{data.Output}'.");
        }

        Assert.Pass();
    }

    class DataSet
    {
        public readonly string InputA;
        public readonly string InputB;

        public readonly string Output;

        public DataSet(string inputA, string inputB, string output)
        {
            InputA = inputA;
            InputB = inputB;
            Output = output;
        }
    }
}
