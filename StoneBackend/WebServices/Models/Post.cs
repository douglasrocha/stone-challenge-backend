using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class Post
    {
        public Int16 Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        public User Author { get; set; }
        public List<Tag> Tags { get; set; }
    }
}