using ApplicationsServices.Features.Commands.CreateCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Veterinary.WebApi.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class PetTypeController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreatePetTypeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
