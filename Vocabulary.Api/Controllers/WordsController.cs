using Microsoft.AspNetCore.Mvc;
using Vocabulary.Api.Services;
using Vocabulary.Api.Services.Abstract;

namespace Vocabulary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private readonly IWordService _wordService;

        public WordsController(IWordService wordService)
        {
            _wordService = wordService;
        }

        [HttpGet]
        public IActionResult Words(int count)
        {
            return Ok(_wordService.GetTodayWords(count).ToList());
        }

    }
}
