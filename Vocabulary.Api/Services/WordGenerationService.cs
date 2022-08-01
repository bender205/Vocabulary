using Vocabulary.Api.Services.Abstract;

namespace Vocabulary.Api.Services
{
    public class WordGenerationService : IWordGenerationService
    {
        private const int MinWordLength = 1;
        private const int MaxWordLength = 20;

        private readonly Random _random = new();

        public IEnumerable<string> GenerateRandomWords(int count) =>
            Enumerable.Range(0, count)
            .Select(words =>
            {
                var range = Enumerable.Range(0, _random.Next(MinWordLength, MaxWordLength));
                var chars = range.Select(symbol => (char)_random.Next('a', 'z')).ToArray();
                var word = new string(chars);
                return word;
            });




    }
}
