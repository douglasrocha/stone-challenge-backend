using DomainModel.Entities;
using DomainModel.Repository.Interfaces;
using Infrastructure.Data;
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
            using (var context = new BlogContext())
            {
                return context.Posts.Count();
            }
        }

        public List<Post> GetFirstPostsOrderedByDate(int numberOfPosts, int startIndex)
        {
            using (var context = new BlogContext())
            {
                throw new NotImplementedException();           
            }
        }
    }
}
