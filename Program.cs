namespace kodtestfredag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatableChar("swiss")); // w
            Console.WriteLine(FirstNonRepeatableChar("racecars")); // e
            Console.WriteLine(FirstNonRepeatableChar("aabb")); // _
        }

        public static char FirstNonRepeatableChar(string text)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var character in text)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    charCount.Add(character, 1);
                }
            }

            foreach (var character in text)
            {
                if (charCount[character] == 1)
                {
                    return character;
                }
            }

            return '_';
        }
    }
}
