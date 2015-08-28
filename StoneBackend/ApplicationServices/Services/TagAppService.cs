using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class TagAppService : BaseAppService<Tag>, ITagAppService
    {
        public TagAppService(IBaseService<Tag> service) : base(service)
        {
        }
    }
}
