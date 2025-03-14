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
            // Dictionary (key = bokstäverna från texterna, value = antal gånger bokstäverna förekommer)
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var character in text)
            {
                // Om bokstaven redan finns som nyckel så ökar vi bara värdet på den
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    // Finns inte nyckeln, då lägger vi till bokstaven som en nyckel och lägger värde på 1
                    charCount.Add(character, 1);
                }
            }

            // Gå igenom alla bokstäver igen i texterna
            foreach (var character in text)
            {
                // Om bokstaven har värde 1 i dictionaryn då returnerar vi den bokstaven
                if (charCount[character] == 1)
                {
                    return character;
                }
            }

            // Om ingen bokstav har värde 1 i dictionaryn då returnerar vi _
            return '_';
        }
    }
}
