using Problems.Easy.BinaryTreeInorderTraversal_94;
using Utils.Tree;

namespace ProblemTest.Litcode.Easy;

public class BinaryTreeInorderTraversal_94
{
    private Solution _solution;
    private DataSet[] _dataSets;

    [SetUp]
    public void Setup()
    {
        _solution = new Solution();
        _dataSets = DataSet.GenetateData();
    }

    [Test]
    public void BinaryTreeInorderTraversalTest()
    {
        foreach (var dataSet in _dataSets)
        {
            IList<int> result = _solution.InorderTraversal(dataSet.Input);
            bool equal = result.SequenceEqual(dataSet.Output);
            Assert.That(equal, $" result = {string.Join(" ", result)}; output = {string.Join(" ", dataSet.Output)}");
        }

        Assert.Pass();
    }

    class DataSet
    {
        /// <summary>
        /// 1. Input: root = [1,null,2,3] Output: [1,3,2]
        /// 2. Input: root = [1,2,3,4,5,null,8,null,null,6,7,9] Output: [4,2,6,5,7,1,3,9,8]
        /// 3. Input: root = [] Output: []
        /// 4. Input: root = [1]  Output: [1]
        /// The number of nodes in the tree is in the range [0, 100].
        /// -100 <= Node.val <= 100
        /// </summary>
        /// <returns></returns>
        public static DataSet[] GenetateData()
        {
            return new DataSet[]
            {
                new DataSet
                (
                    new TreeNode(1, null, new TreeNode(2, new TreeNode(3))),
                    new List<int>{1, 3, 2}
                ),

                new DataSet
                (
                    new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))), new TreeNode(3, null, new TreeNode(8, new TreeNode(9)))),
                    new List<int>{4,2,6,5,7,1,3,9,8}
                ),

                new DataSet
                (
                    null,
                    new List<int>{}
                ),

                new DataSet
                (
                    new TreeNode(1),
                    new List<int>{1}
                ),
            };
        }

        public readonly TreeNode Input;
        public readonly IList<int> Output;

        public DataSet(TreeNode input, IList<int> output)
        {
            Input = input;
            Output = output;
        }
    }
}
