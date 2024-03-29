﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ForoDellaDevs.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public virtual Forum Forum { get; set; }

        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}