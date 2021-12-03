using Microsoft.AspNetCore.Mvc;
using Models;

namespace SearchWebAppService.Controllers
{
    interface IStartupDataController
    {
        [HttpGet("GetStartupById")]
        public IActionResult GetStartupById(Guid id);

        [HttpPut("CreateStartup")]
        public IActionResult CreateStartup(Startup startup);

        [HttpPost("UpdateStartupById")]
        public IActionResult UpdateStartupById(Guid id, Startup startup);

        [HttpDelete("DeleteStartupById")]
        public IActionResult DeleteStartupById(Guid id);
    }
}
