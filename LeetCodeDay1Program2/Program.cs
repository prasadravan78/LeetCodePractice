namespace LeetCodeDay1Program2
{
    public static class PivotFinder
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, -1 };

            Console.WriteLine(PivotIndex(nums));

            Console.ReadLine();
        }

        public static int PivotIndex(int[] nums)
        {
            int totalSum = 0, leftSum = 0;

            foreach (var element in nums)
            {
                totalSum += element;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (totalSum - nums[i] == leftSum)
                {
                    return i;
                }
                else
                {
                    totalSum -= nums[i];
                    leftSum += nums[i];
                }
            }

            return -1;
        }
    }
}