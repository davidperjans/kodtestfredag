namespace kodtestfredag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var result = GroupAnagram(input);

            // Skriv ut resultatet
            foreach (var group in result)
            {
                Console.WriteLine(string.Join(", ", group));
            }
        }

        public static List<List<string>> GroupAnagram(List<string> words)
        {
            // Dictionary (key = sorterade bokstäver, value = lista av ord som matchar key)
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach(var word in words)
            {
                // Sortera bokstäverna i order (användar Concat för att mergea ihop alla bokstäver till en sträng)
                var sortedWord = string.Concat(word.OrderBy(c => c));

                // Om key inte finns i dictionary, skapa en ny lista
                if (!anagramGroups.ContainsKey(sortedWord))
                {
                    anagramGroups[sortedWord] = new List<string>();
                }
                // Lägg till ordet i listan
                anagramGroups[sortedWord].Add(word);
            }
            // Returnera alla värden i dictionaryn
            return anagramGroups.Values.ToList();
        }

    }
}
