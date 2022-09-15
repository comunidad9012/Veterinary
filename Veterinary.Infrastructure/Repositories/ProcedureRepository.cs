using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class ProcedureRepository : IProcedureRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProcedureFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(ProcedureFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProcedureFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
