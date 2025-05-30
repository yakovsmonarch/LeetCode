using ConsoleProject.Litcode.Easy.Merge_Two_Sorted_Lists_21;

namespace ProblemTest.Litcode.Easy;

public class Merge_Two_Sorted_Lists_21
{

    /*
        Input: list1 = [1,2,4], list2 = [1,3,4]
        Output: [1,1,2,3,4,4]
    */
    private readonly Dictionary<ListNode, ListNode[]> _nodes = new Dictionary<ListNode, ListNode[]>
    {
        {
            new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode())))))),
            new ListNode[]
            {
                new ListNode(0, new ListNode(1, null)),
                new ListNode(0, new ListNode(1, null)),
                new ListNode(0, new ListNode(1, null)),
            }

        }
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void MergeTwoSortedListsTest()
    {
        var solution = new Solution();

        foreach (var node in _nodes)
        {
            ListNode result = solution.MergeTwoLists(node.Value[0], node.Value[1]);
        }

        Assert.Pass();
    }

    private bool EqualsArr(ListNode resultNode, ListNode outputNode)
    {
        do
        {
            if (resultNode?.val != outputNode?.val)
            {
                return false;
            }

            resultNode = resultNode?.next;
            outputNode = outputNode?.next;
        }
        while (resultNode != null || outputNode != null);

        return true;
    }
}
