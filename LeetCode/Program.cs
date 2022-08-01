namespace LeetCodeDay1Program1
{
    public static class RunningSumCalculator
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 1 };

            RunningSum(nums);

            foreach (var element in nums)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }

        public static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}