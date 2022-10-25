using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.DomainClass.Entity;

namespace ApplicationsServices.Services
{
    public interface IPetTypeServices
    {
        public Task<int> Insert(PetType petType);
    }
}
