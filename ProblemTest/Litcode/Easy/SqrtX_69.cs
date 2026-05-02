using ConsoleProject.Litcode.Easy.SqrtX_69;

namespace ProblemTest.Litcode.Easy;

public class SqrtX_69
{
    private List<DataSet> _dataSets;

    [SetUp]
    public void Setup()
    {
        _dataSets = DataSet.GenerateDataSets(10);
    }

    [Test]
    public void SqrtXTest()
    {
        Solution solution = new Solution();

        foreach (DataSet data in _dataSets)
        {
            Assert.That(solution.MySqrt(data.Number) == data.SquareNumber);
        }

        Assert.Pass();
    }

    class DataSet
    {
        public static List<DataSet> GenerateDataSets(int numberDataSets)
        {
            Random random = new Random();
            var list = new List<DataSet>();

            for (int i = 0; i < numberDataSets; i++)
            {
                int number = random.Next(1, int.MaxValue);
                int squareNumber = (int)Math.Sqrt(number);
                list.Add(new DataSet(number, squareNumber));
            }

            return list;
        }

        public readonly int Number;
        public readonly int SquareNumber;

        public DataSet(int number, int squareNumber)
        {
            Number = number;
            SquareNumber = squareNumber;
        }
    }
}
