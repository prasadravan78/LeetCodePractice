namespace LeetCodeDay5Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("accca"));
            Console.ReadLine();
        }

        public static int LongestPalindrome(string s)
        {
            HashSet<char> chars = new HashSet<char>();
            var longestPalindrome = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (chars.Contains(s[i]))
                {
                    longestPalindrome += 2;
                    chars.Remove(s[i]);
                }
                else
                {
                    chars.Add(s[i]);
                }
            }

            if (chars.Count() > 0)
            {
                longestPalindrome++;
            }

            return longestPalindrome;
        }
    }
}