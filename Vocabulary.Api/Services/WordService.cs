using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Vocabulary.Api.Services.Abstract;

namespace Vocabulary.Api.Services
{
    public class WordService : IWordService
    {
        private readonly IWordGenerationService _wordGenerationService;

        public WordService(IWordGenerationService wordGenerationService)
        {
            _wordGenerationService = wordGenerationService;
        }
        public IEnumerable<string> GetTodayWords(int count)
        {
            var words = _wordGenerationService.GenerateRandomWords(count);
            return words;
        }
    }
}
