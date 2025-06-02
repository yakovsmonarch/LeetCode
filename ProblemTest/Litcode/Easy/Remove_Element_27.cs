using ConsoleProject.Litcode.Easy.Remove_Element_27;

namespace ProblemTest.Litcode.Easy;

public class Remove_Element_27
{
    private readonly DataSet[] _dataSets =
    {
        new DataSet(2, 3, new int[]{3,2,2,3}, new int[]{2,2}),
        new DataSet(5, 2, new int[]{0,1,2,2,3,0,4,2}, new int[]{0,1,4,0,3}),
        // new DataSet(1, 3, new int[]{2}, new int[]{2}),
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void RemoveElementTest()
    {
        /*
            Input: nums = [3,2,2,3], val = 3
            Output: 2, nums = [2,2,_,_]

            Input: nums = [0,1,2,2,3,0,4,2], val = 2
            Output: 5, nums = [0,1,4,0,3,_,_,_]
        */
        var solution = new Solution();

        foreach (DataSet dataSet in _dataSets)
        {
            int result = solution.RemoveElement(dataSet.Nums, dataSet.Val);
            Assert.That(result == dataSet.Result);

            int[] arrNums = dataSet.Nums.Take(dataSet.Result).ToArray();
            Array.Sort(arrNums);
            
            int[] arrOutput = dataSet.OutputNums.Take(dataSet.Result).ToArray();
            Array.Sort(arrOutput);

            Assert.That(arrNums.SequenceEqual(arrOutput));
        }

        Assert.Pass();
    }
    
    class DataSet
    {
        public readonly int Result;
        public readonly int Val;
        public readonly int[] Nums;
        public readonly int[] OutputNums;

        public DataSet(int result, int val, int[] nums, int[] outputNums)
        {
            Result = result;
            Val = val;
            Nums = nums;
            OutputNums = outputNums;
        }
    }
}
