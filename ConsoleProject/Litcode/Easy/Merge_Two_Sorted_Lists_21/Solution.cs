namespace ConsoleProject.Litcode.Easy.Merge_Two_Sorted_Lists_21;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        if (list1.val <= list2.val)
            return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
        
        return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
    }
}
