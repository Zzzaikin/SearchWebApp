using DocumentParser;
using Microsoft.AspNetCore.Mvc;

namespace SearchWebAppService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParserController : ControllerBase
    {
        [HttpGet("GetStartupsWithPdfParser")]
        public IActionResult GetStartupsWithPdfParser(string fileName)
        {
            var result = GetParsedString(fileName, new PdfParser());
            return ValidateParsedString(result);
        }

        [HttpGet("GetStartupsWithPptxParser")]
        public IActionResult GetStartupsWithPptxParser(string fileName)
        {
            var result = GetParsedString(fileName, new PptxParser());
            return ValidateParsedString(result);
        }

        [HttpGet("GetStartupsWithWorldParser")]
        public IActionResult GetStartupsWithWorldParser(string fileName)
        {
            var result = GetParsedString(fileName, new WordParser());
            return ValidateParsedString(result);
        }

        private string GetParsedString(string fileName, IParser parser)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException($"{nameof(fileName)} can not be null or empty");
            }

            var result = parser.GetString(fileName);
            return result;
        }

        private IActionResult ValidateParsedString(string result)
        {
            if (result == null)
                return Problem("Parsing result is null");

            if (result == string.Empty)
                return Ok("File is empty");

            return Ok(result);
        }
    }
}
