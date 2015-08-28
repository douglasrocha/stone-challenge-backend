using DomainModel.Entities;
using DomainServices.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class PostAppService : IBaseAppService<Post>, IPostAppService
    {
    }
}
