using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }

        public BlogContext() : base()
        {
            Database.Connection.ConnectionString = "Data Source=blog_server;Initial Catalog=bd_blog;Persist Security Info=True;User ID=myuser;Password=mypassword";
        }
    }
}
