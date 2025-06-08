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
            if (target < nums[start]) return start;
            if (target > nums[end]) return end + 1;

            if (target > nums[start]) return start + 1;
            if (target < nums[end]) return end - 1;

            if (nums[start] == target) return start;
            if (nums[end] == target) return end;
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
