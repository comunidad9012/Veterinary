﻿using ApplicationsServices.Interfaces;
using ApplicationsServices.Wrappers;
using AutoMapper;
using DomainClass.Common;
using MediatR;
using Veterinary.DomainClass.Entity;
namespace ApplicationsServices.Features.Commands.CreateCommands
{

    public class CreateClientCommand : IRequest<Response<long>>
    {
        public string clientName { get; set; }
        public string clientSurname { get; set; }
        public string clientAdress { get; set; }
        public string clientPhoneNum { get; set; }
        public string clientIdn { get; set; }
        public string clientEmail { get; set; }
    }
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Response<long>>
    {
        private readonly IRepository<Client> _repository;
        private readonly IMapper _mapper;

        public CreateClientCommandHandler(IRepository<Client> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<long>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            //request.Password = request.Password.Encriptar();
            var newRegister = _mapper.Map<Client>(request);
            var data = await _repository.AddAsync(newRegister);

            return new Response<long>(data.Id);
        }
    }
}
