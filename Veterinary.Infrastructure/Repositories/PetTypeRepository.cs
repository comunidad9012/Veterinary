﻿using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PetTypeFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PetTypeFullDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(PetTypeFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(PetTypeFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
