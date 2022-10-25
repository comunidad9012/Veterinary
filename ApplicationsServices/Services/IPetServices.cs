using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.DomainClass.Entity;

namespace ApplicationsServices.Services
{
    public interface IPetServices
    {
        public Task<int> Insert(Pet pet);

    }
}
