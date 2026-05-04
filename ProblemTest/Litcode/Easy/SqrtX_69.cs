using ConsoleProject.Litcode.Easy.SqrtX_69;

namespace ProblemTest.Litcode.Easy;

public class SqrtX_69
{
    private List<DataSet> _dataSets;

    [SetUp]
    public void Setup()
    {
        _dataSets = DataSet.GenerateDataSets(100, int.MaxValue);
        _dataSets.Add(new DataSet(8, 2));
        _dataSets.Add(new DataSet(2147395599, 46339));
    }

    [Test]
    public void SqrtXTest()
    {
        Solution solution = new Solution();

        foreach (DataSet data in _dataSets)
        {
            int result = solution.MySqrt(data.Number);
            Assert.That(result == data.SquareNumber, 
            $"data.Number = {data.Number}, data.SquareNumber = {data.SquareNumber}, solution.MySqrt(data.Number) = '{result}'.");
        }

        Assert.Pass();
    }

    class DataSet
    {
        public static List<DataSet> GenerateDataSets(int numberDataSets, int maxValue)
        {
            Random random = new Random();
            var list = new List<DataSet>();

            for (int i = 0; i < numberDataSets; i++)
            {
                int number = random.Next(1, maxValue);
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
