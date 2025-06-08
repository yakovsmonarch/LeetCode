namespace ConsoleProject.Litcode.Easy.Search_Insert_Position_35;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int result = Search(nums, 0, nums.Length - 1, target);
        return result;
    }

    private int Search(int[] nums, int start, int end, int target)
    {
        if (end - start <= 1)
        {
            if (start == end) return nums[start] == target ? start : start + 1;

            if (nums[start] != target && nums[end] != target)
            {
                return target > nums[end] ? end + 1 : start + 1;
            }
        }

        int average = (end - start) / 2 + start;
        if (nums[average] < target)
        {
            start = average;
        }
        else if (nums[average] > target)
        {
            end = average;
        }
        else
        {
            end = start = average;
        }

        return Search(nums, start, end, target);
    }
}
