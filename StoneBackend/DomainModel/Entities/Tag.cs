using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Tag : BaseEntity
    {
        public int Id { get; set; }
        List<Post> Posts { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
