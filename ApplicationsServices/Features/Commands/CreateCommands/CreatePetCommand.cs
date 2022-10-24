﻿using ApplicationsServices.Interfaces;
using ApplicationsServices.Wrappers;
using AutoMapper;
using MediatR;
using Veterinary.DomainClass.Entity;

namespace ApplicationsServices.Features.Commands.CreateCommands
{
    public class CreatePetCommand : IRequest<Response<long>>
    {
        public string? petName { get; set; }
        public long clientId { get; set; }
        public long typeId { get; set; }

        //Foreing keys
        public ICollection<PetType>? petType { get; set; }
        public ICollection<Client>? client { get; set; }
    }
    public class CreatePetCommandHandler : IRequestHandler<CreatePetCommand, Response<long>>
    {
        private readonly IRepository<Pet> _repository;
        private readonly IMapper _mapper;

        public CreatePetCommandHandler(IRepository<Pet> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<long>> Handle(CreatePetCommand request, CancellationToken cancellationToken)
        {
            //request.Password = request.Password.Encriptar();
            var newRegister = _mapper.Map<Pet>(request);
            var data = await _repository.AddAsync(newRegister);

            return new Response<long>(data.Id);
        }
    }
}
