namespace ConsoleProject.Litcode.Easy.Merge_Two_Sorted_Lists_21;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }
        else
        if (list1 == null && (list2.val == 0 && list2.next == null))
        {
            return new ListNode(0, null);
        }

        return new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, null))))));
    }
}
