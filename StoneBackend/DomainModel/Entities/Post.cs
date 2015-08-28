using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        public User Author { get; set; }
        public List<Tag> Tags { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
