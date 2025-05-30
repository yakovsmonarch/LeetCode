using ConsoleProject.Litcode.Easy.Remove_Duplicates_from_Sorted_Array_26;

namespace ProblemTest.Litcode.Easy;

public class Remove_Duplicates_from_Sorted_Array_26
{
    private readonly DataSet[] _dataSet =
    {
        new DataSet(2, new int[]{1,1,2}, new int[]{1,2}),
        new DataSet(5, new int[]{0,0,1,1,1,2,2,3,3,4}, new int[]{0,1,2,3,4})
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void RemoveDuplicatesTest()
    {
        var solution = new Solution();

        foreach (DataSet item in _dataSet)
        {
            int[] nums = item.Numbers;
            int result = solution.RemoveDuplicates(nums);
            
            Assert.That(result == item.Count);
            Assert.That(nums.Take(result).SequenceEqual(item.OutNumbers.Take(result)));
        }

        Assert.Pass();
    }

    class DataSet
    {
        public readonly int Count;
        public int[] Numbers;
        public readonly int[] OutNumbers;

        public DataSet(int count, int[] numbers, int[] outNumbers)
        {
            Count = count;
            Numbers = numbers;
            OutNumbers = outNumbers;
        }
    }
}
