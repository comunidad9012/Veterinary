using ApplicationsServices.Interfaces;
using ApplicationsServices.Wrappers;
using MediatR;
using Veterinary.DomainClass.Entity;

namespace ApplicationsServices.Features.Commands.DeleteCommands
{
    public class DeleteClientCommand : IRequest<Response<long>>
        {
            public long Id { get; set; }
        }
    public class DeleteClientCommandHandle : IRequestHandler<DeleteClientCommand, Response<long>>
    {
        private readonly IRepository<Client> _repository;

        public DeleteClientCommandHandle(IRepository<Client> repository)
        {
            _repository = repository;
        }

        public async Task<Response<long>> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            //Obtiene el registro en base al Id enviado.
            var register = await _repository.GetByIdAsync(request.Id);
            //Consulta si se regreso algún registro desde la base de datos.
            if (register == null)
            {
                throw new KeyNotFoundException($"No se encontro el registro con el Id: {request.Id}");
            }
            else
            {
                await _repository.DeleteAsync(register);
                return new Response<long>(register.Id);
            }



        }
    }
}
