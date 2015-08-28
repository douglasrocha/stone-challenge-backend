using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        List<Post> Posts { get; set; }
    }
}
