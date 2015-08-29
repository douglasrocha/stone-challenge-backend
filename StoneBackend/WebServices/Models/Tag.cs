using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Post> Posts { get; set; }
    }
}