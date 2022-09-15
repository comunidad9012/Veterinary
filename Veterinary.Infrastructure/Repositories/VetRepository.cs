using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class VetRepository : IVetRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VetFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(VetFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(VetFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
