namespace Vocabulary.Api.Services.Abstract
{
    public interface IWordGenerationService
    {
        IEnumerable<string> GenerateRandomWords(int count);
    }
}