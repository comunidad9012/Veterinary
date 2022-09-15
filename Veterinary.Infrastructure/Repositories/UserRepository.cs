
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(UserFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
