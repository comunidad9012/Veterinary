﻿using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;
using Veterinary.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Veterinary.Infrastructure.Repositories
{
    public class PetRepository : IPetRepository
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PetFullDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PetFullDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(PetFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(PetFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
