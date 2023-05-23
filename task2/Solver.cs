class Solver
{
    public static void Main(string[] args)
    {
        string[] words;

        words = Console.ReadLine().Split(' ');
        Dictionary<string, int> wordsDict = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordsDict.ContainsKey(word))
            {
                wordsDict[word]++;
            }
            else
            {
                wordsDict.Add(word, 1);
            }
        }

        var wordsDictSortedByAscending = from word in wordsDict orderby word.Value ascending select word;
        int countUnderscore = 0;
        int maxCountOfWords = wordsDict.Values.Max();
        foreach (var word in wordsDictSortedByAscending)
        {
            double frequencyRelativeMax = ((float)wordsDict[word.Key] * 10) / maxCountOfWords;
            int roundedFrequencyRelativeMax = (int)Math.Round(frequencyRelativeMax);
            Console.WriteLine($"{String.Concat(Enumerable.Repeat("_", countUnderscore))}{word.Key} {String.Concat(Enumerable.Repeat(".", roundedFrequencyRelativeMax))}");
            countUnderscore++;
        }

    }
}