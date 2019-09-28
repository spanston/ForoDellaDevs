using System;
using System.Collections.Generic;
using System.Text;

namespace ForoDellaDevs.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string Imageurl { get; set; }

        //lazy load for EF core
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
