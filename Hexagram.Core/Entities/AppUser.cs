using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.Core.Entities
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ProfilePic_Url { get; set; }
        public string Biography { get; set; }


        //Relations
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like_Post> Liked_Posts { get; set; }
        public List<Like_Comment> Liked_Comments { get; set; }


    }
}
