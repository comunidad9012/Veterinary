using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Core.Entities;

namespace ApplicationsServices.Services.IServices
{
    public interface IUserServices
    {
        public Task<int> Insert(User user);

    }
}
