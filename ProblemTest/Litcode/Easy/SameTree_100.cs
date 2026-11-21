using Problems.Easy.SameTree_100;
using Utils.Tree;

namespace ProblemTest.Litcode.Easy;

public class SameTree_100
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SameTreeTest()
    {
        var solution = new Solution();

        foreach (var dataSet in DataSet.GenetateData())
        {
            bool result = solution.IsSameTree(dataSet.TreeNode1, dataSet.TreeNode2);
            Assert.That(result == dataSet.Output, $"result: {result}, output: {dataSet.Output}");
        }

        Assert.Pass();
    }

    class DataSet
    {
        public static DataSet[] GenetateData()
        {
            return new DataSet[]
            {
                new DataSet(new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                    new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                    true),
                    
                new DataSet(new TreeNode(1, new TreeNode(2)),
                    new TreeNode(1, null, new TreeNode(2)),
                    false),

                new DataSet(new TreeNode(1, new TreeNode(2), new TreeNode(1)),
                    new TreeNode(1, new TreeNode(1), new TreeNode(2)),
                    false)
                    
            };
        }

        public readonly TreeNode TreeNode1;
        public readonly TreeNode TreeNode2;
        public readonly bool Output;

        public DataSet(TreeNode treeNode1, TreeNode treeNode2, bool output)
        {
            TreeNode1 = treeNode1;
            TreeNode2 = treeNode2;
            Output = output;
        }
    }
}
