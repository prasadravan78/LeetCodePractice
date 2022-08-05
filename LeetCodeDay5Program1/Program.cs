namespace LeetCodeDay5Program1
{
    internal class BuySellStock
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[] { 3, 2, 6, 5, 0, 3 }));
            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (min < prices[i])
                {
                    max = Math.Max(prices[i] - min, max);
                }
                else
                {
                    min = prices[i];
                }
            }

            return max;
        }
    }
}