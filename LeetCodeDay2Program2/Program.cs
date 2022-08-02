namespace LeetCodeDay2Program2
{
    internal class Subsequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("aaaaaaa","bbaaaa"));
            Console.ReadLine();
        }

        public static bool IsSubsequence(string s, string t)
        {
            int sl = 0;

            foreach (char c in t)
            {
                if (sl < s.Length && s[sl] == c)
                {
                    sl++;
                }
            }

            return sl == s.Length;
        }
    }
}