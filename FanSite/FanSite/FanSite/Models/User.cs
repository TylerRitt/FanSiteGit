﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class User
    {
        private List<Comment> comments = new List<Comment>();

        public string Name { get; set; }
        public string Email { get; set; }

        public List<Comment> Comments { get { return comments; } }

    }
}
