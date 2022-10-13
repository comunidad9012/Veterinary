using Veterinary.DomainClass.Entity;

namespace ApplicationsServices.Services
{
    public interface IClientServices
    {
        public Task<int> Insert(Client client);

    }
}
