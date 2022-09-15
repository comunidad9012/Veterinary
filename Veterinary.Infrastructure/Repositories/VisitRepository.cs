using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;
using Veterinary.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Veterinary.Infrastructure.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VisitFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(VisitFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(VisitFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
