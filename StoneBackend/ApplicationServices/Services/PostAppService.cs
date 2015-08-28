using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class PostAppService : BaseAppService<Post>, IPostAppService
    {
        public PostAppService(IBaseService<Post> service) : base(service)
        {
        }

        public int GetAllPostsCount()
        {
            throw new NotImplementedException();
        }

        public List<Post> GetFirstPostsOrderedByDate(int numberOfPosts, int startIndex)
        {
            throw new NotImplementedException();
        }
    }
}
