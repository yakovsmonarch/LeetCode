using Problems.Easy.RemoveDuplicatesFromSortedList_83;

namespace ProblemTest.Litcode.Easy;

public class RemoveDuplicatesFromSortedList_83
{
    private DataSet[] _dataSets;

    [SetUp]
    public void Setup()
    {
        _dataSets = DataSet.GenetateData();
    }

    [Test]
    public void RemoveDuplicatesFromSortedListTest()
    {
        var solution = new Solution();

        foreach (DataSet dataSet in _dataSets)
        {
            ListNode result = solution.DeleteDuplicates(dataSet.Input);
            bool isEqual = false;

            while (result != null && dataSet.Output != null)
            {
                isEqual = result.val == dataSet.Output.val;

                if (isEqual == false)
                {
                    Assert.That(isEqual, $"Ожидается: {dataSet.Output.val}, получено: {result.val}");
                    break;
                }

                result = result.next;
                dataSet.Output = dataSet.Output.next;
            }

            Assert.That(result == null && dataSet.Output == null, $"Связанные списки разной длины.");
        }

        Assert.Pass();
    }
}

class DataSet
{
    // Input: head = [1,1,2]
    // Input: head = [1,1,2,3,3]
    public static DataSet[] GenetateData()
    {
        return new DataSet[]
        {
            new DataSet(new ListNode(1, new ListNode(1, new ListNode(2))),
                new ListNode(1, new ListNode(2))),

            new DataSet(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))),
                new ListNode(1, new ListNode(2, new ListNode(3)))),
        };
    }

    public ListNode Input;
    public ListNode Output;

    public DataSet(ListNode input, ListNode output)
    {
        Input = input;
        Output = output;
    }
}
