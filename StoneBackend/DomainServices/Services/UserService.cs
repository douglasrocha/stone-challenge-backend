using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;
using DomainServices.Interfaces.DomainServices;

namespace DomainServices.Services
{
    public class UserService : IBaseService<User>, IUserService
    {
    }
}
