using Hexagram.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.Core.Entities
{
    public class Comment:BaseEntity
    {
        public string CommentText { get; set; }

        //Relations
        public int UserId { get; set; }
        public int PostId { get; set; }
        public List<Like_Comment> Comment_Likes { get; set; }

    }
}
