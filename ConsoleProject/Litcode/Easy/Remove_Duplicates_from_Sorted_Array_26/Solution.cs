namespace ConsoleProject.Litcode.Easy.Remove_Duplicates_from_Sorted_Array_26;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int count = 0;
        int temp = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (temp != nums[i])
            {
                temp = nums[i];
                nums[count++] = temp;
            }
        }
        
        return count;
    }
}
