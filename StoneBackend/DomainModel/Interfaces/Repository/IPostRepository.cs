using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repository.Interfaces
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        int GetAllPostsCount();

        List<Post> GetFirstPostsOrderedByDate(int numberOfPosts, int startIndex);
    }
}
