using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // получить список всех работников
        [HttpGet("get/all")]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok();
        }

        // получить информацию о работнике по ID
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            return Ok();
        }

        // регистрация нового работника
        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody] Employee employeeInfo)
        {
            return Ok();
        }

        // изменение данных о работнике
        [HttpPut("change/{id}")]
        public async Task<IActionResult> Put(int id)
        {
            return Ok();
        }

        // удаление работника по ID
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
