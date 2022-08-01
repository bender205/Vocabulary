namespace Vocabulary.Api.Services.Abstract
{
    public interface IWordService
    {
        IEnumerable<string> GetTodayWords(int count);
    }
}