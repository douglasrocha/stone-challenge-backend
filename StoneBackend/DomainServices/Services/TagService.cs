using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using DomainModel.Repository.Interfaces;

namespace DomainServices.Services
{
    public class TagService : BaseService<Tag>, ITagService
    {
        public TagService(IBaseRepository<Tag> repository) : base(repository)
        {

        }
    }
}
