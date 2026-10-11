namespace Problems.Easy.RemoveDuplicatesFromSortedList_83;

public class Solution : ITask
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        if (head.next == null)
        {
            return new ListNode(head.val);
        }

        if (head.val != head.next.val)
        {
            return new ListNode(head.val, DeleteDuplicates(head.next));
        }
        else
        {
            return DeleteDuplicates(head.next);
        }
    }

    public void Run()
    {
        throw new NotImplementedException();
    }
}
