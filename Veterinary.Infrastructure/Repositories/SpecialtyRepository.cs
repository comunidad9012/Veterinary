
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpecialtyFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(SpecialtyFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(SpecialtyFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
