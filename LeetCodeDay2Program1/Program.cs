namespace LeetCodeDay2Program1
{
    internal class IsomorphicString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphicString("bbbc", "babd"));
            Console.ReadLine();
        }

        public static bool IsIsomorphicString(string s, string t)
        {
            Dictionary<char, char> characterMaps = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                var keyValuePair = characterMaps.Where(k => k.Value == t[i]).FirstOrDefault();

                if (keyValuePair.Key != Char.MinValue && keyValuePair.Key != s[i])
                {
                    return false;
                }
                else if (keyValuePair.Key == Char.MinValue)
                {
                    var isSuccess = characterMaps.TryAdd(s[i], t[i]);

                    if (!isSuccess)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}