using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationByConvention.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }

        public int TweetId { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

    }
}
