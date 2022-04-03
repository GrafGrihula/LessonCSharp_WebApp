using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Timesheets.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        // получить список всех клиентов
        [HttpGet("get/all")]
        public async Task<IActionResult> GetAllClients()
        {
            return Ok();
        }

        // получить информацию о клиенте по ID
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            return Ok();
        }

        // регистрация нового клиента
        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return Ok();
        }

        // изменение данных о клиенте
        [HttpPut("change/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // удаление клиента по ID
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
