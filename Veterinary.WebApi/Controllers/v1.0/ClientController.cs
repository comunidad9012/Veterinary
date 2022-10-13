using ApplicationsServices.Features.Commands.CreateCommands;
using Microsoft.AspNetCore.Mvc;

namespace Veterinary.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClientController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateClientCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
