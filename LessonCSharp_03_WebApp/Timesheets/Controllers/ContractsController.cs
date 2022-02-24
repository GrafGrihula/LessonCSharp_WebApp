using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    [Route("api/contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContractsController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
