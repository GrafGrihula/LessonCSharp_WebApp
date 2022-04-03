using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {


        // получить список всех клиентов
        [HttpGet("get")]
        public async Task<IActionResult> GetAllCustomers()
        {
            return Ok();
        }

        // получить информацию о клиенте по ID
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            return Ok();
        }

        // регистрация нового клиента
        [HttpPost("register")]
        public async Task<IActionResult> RegisterCustomer([FromBody] Customer customer)
        {
            return Ok();
        }

        // изменение данных о клиенте
        [HttpPut("update/{id}")]
        public async Task<IActionResult> EditCustomer([FromBody] Customer customer)
        {
            return Ok();
        }

        // удаление клиента по ID
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            return Ok();
        }
    }
}
