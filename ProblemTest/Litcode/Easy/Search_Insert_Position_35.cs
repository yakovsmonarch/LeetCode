using ConsoleProject.Litcode.Easy.Search_Insert_Position_35;

namespace ProblemTest.Litcode.Easy;

public class Search_Insert_Position_35
{
    private readonly DataSet[] _dataSets =
    {
        new DataSet(new int[]{1,3,5,6}, 5, 2),
        new DataSet(new int[]{1,3,5,6}, 2, 1),
        new DataSet(new int[]{1,3,5,6}, 7, 4),
        
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void SearchInsertTest()
    {
        var solution = new Solution();

        foreach (DataSet item in _dataSets)
        {
            int output = solution.SearchInsert(item.Nums, item.Target);
            Assert.That(output == item.Output);
        }

        Assert.Pass();
    }

    class DataSet
    {
        public readonly int[] Nums;
        public readonly int Target;
        public readonly int Output;

        public DataSet(int[] nums, int target, int output)
        {
            Nums = nums;
            Target = target;
            Output = output;
        }
    }
}
