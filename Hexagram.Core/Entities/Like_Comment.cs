using Hexagram.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.Core.Entities
{
    public class Like_Comment:BaseEntity
    {
        //Relations
        public int UserId { get; set; }
        public int CommentId { get; set; }
    }
}
