namespace ConsoleProject.Litcode.Easy.Remove_Element_27;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 1)
        {
            return nums[0] != val ? 1 : 0;    
        }
        int result = 0;
        for (int i = 0, j = nums.Length; i < j; i++)
        {
            if (nums[i] != val)
            {
                result++;
                continue;   
            }

            while (i < j--)
            {
                if (nums[j] == val) continue;
                nums[i] = nums[j];
                result++;
                break;
            }
        }
        return result;
    }
}
