using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class UserAppService : BaseAppService<User>, IUserAppService
    {
        public UserAppService(IBaseService<User> service) : base(service)
        {
        }
    }
}
