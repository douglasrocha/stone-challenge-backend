using DomainModel.Entities;
using DomainModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
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
