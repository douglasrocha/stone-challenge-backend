using DomainModel.Entities;
using DomainServices.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class PostService : IBaseService<Post>, IPostService
    {
    }
}
