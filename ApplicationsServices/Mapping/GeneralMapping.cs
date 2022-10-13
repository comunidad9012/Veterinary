using ApplicationsServices.Features.Commands.CreateCommands;
using AutoMapper;
using Veterinary.DomainClass.Entity;

namespace ApplicationsServices.Mapping
{
    public class GeneralMaping : Profile
    {
        public GeneralMaping()
        {
            CreateMap<CreateClientCommand, Client>();
        }
    }
}
