using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetAllInvoices()
        {
            return Ok();
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetInvoiceById([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterInvoice([FromBody] Invoice invoice)
        {
            return Ok();
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateInvoice([FromRoute] int id)
        {
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteInvoice([FromRoute] int id)
        {
            return Ok();
        }
    }
}
