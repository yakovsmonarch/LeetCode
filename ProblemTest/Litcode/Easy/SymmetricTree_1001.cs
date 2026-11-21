using Problems.Easy.SymmetricTree_1001;
using Utils.Tree;

namespace ProblemTest.Litcode.Easy;

public class SymmetricTree_1001
{
    private DataSet[] _dataSets;

    [SetUp]
    public void Setup()
    {
        _dataSets = DataSet.GenetateData();
    }

    [Test]
    public void SymmetricTreeTest()
    {
        var solution = new Solution();

        foreach (var data in _dataSets)
        {
            bool output = solution.IsSymmetric(data.Input);
            Assert.That(output == data.Output, $"result: {output}, output: {data.Output}");
        }

        Assert.Pass();
    }

    class DataSet
    {
        public static DataSet[] GenetateData()
        {
            BinaryTree binaryTree = new BinaryTree();

            return new DataSet[]
            {
                new DataSet(binaryTree.ArrayToTree(new int?[]{1,2,2,3,4,4,3}),
                    true),

                new DataSet(binaryTree.ArrayToTree(new int?[]{1,2,2,null,3,null,3}),
                    false)
            };
        }

        public readonly TreeNode Input;
        public readonly bool Output;

        public DataSet(TreeNode input, bool output)
        {
            Input = input;
            Output = output;
        }
    }
}
