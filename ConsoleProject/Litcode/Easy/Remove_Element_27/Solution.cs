namespace ConsoleProject.Litcode.Easy.Remove_Element_27;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0;
        for (int j = nums.Length - 1; i < j; i++)
        {
            if (nums[i] != val) continue;

            while (i < j--)
            {
                if (nums[j] == val) continue;
                nums[i] = nums[j];
                break;
            }
        }
        return i;
    }
}
