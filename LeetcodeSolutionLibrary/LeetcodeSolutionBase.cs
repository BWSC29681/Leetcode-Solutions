namespace LeetcodeSolutionLibrary
{
    public class LeetcodeSolutionBase
    {
        protected string getArrayForDisplay(int?[] nums)
        {
            return "[" + string.Join(',', nums) + "]";
        }

        protected string getArrayForDisplay(int[] nums)
        {
            int?[] newNums = new int?[nums.Length];
            for (int i = 0; i < nums.Length; i++) newNums[i] = nums[i];
            return getArrayForDisplay(newNums);
        }
    }
}