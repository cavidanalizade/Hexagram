using Hexagram.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.Core.Entities
{
    public class Post:BaseEntity
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        //Relations
        public int UserId { get; set; }
        public List<Like_Post> Post_Likes { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
