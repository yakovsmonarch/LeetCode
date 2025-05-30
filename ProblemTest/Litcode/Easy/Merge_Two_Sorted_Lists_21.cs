using ConsoleProject.Litcode.Easy.Merge_Two_Sorted_Lists_21;

namespace ProblemTest.Litcode.Easy;

public class Merge_Two_Sorted_Lists_21
{
    private readonly DataListNode[] _dataNodes =
    {
        new DataListNode(
            new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, null)))))),
            new ListNode(1, new ListNode(2, new ListNode(4, null))),
            new ListNode(1, new ListNode(3, new ListNode(4, null)))
        ),
        new DataListNode(
            null,
            null,
            null
        ),
        new DataListNode(
            new ListNode(0, null),
            null,
            new ListNode(0, null)
        ),
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void MergeTwoSortedListsTest()
    {
        var solution = new Solution();

        foreach (DataListNode dataNode in _dataNodes)
        {
            ListNode result = solution.MergeTwoLists(dataNode.ListNode1, dataNode.ListNode2);
            bool isEqual = EqualsArr(result, dataNode.OutputListNode);
            Assert.That(isEqual, $"Результат не верен.");
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

    class DataListNode
    {
        public readonly ListNode OutputListNode;
        public readonly ListNode ListNode1;
        public readonly ListNode ListNode2;

        public DataListNode(ListNode outputListNode, ListNode listNode1, ListNode listNode2)
        {
            OutputListNode = outputListNode;
            ListNode1 = listNode1;
            ListNode2 = listNode2;
        }
    }
}
