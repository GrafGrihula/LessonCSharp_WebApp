using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {

        [HttpGet("get")]
        public async Task<IActionResult> GetAllContracrts()
        {
            return Ok();
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetContractById([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterContract([FromBody] Contract contract)
        {
            return Ok();
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateContract([FromRoute] int id)
        {
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteContract([FromRoute] int id)
        {
            return Ok();
        }
    }
}
