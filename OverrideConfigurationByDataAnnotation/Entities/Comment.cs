using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationByConvention.Entities
{
    [Table("tblComments")]
    public class Comment
    {
        [Column("CommentId")]
        public int Id { get; set; }
        public int UserId { get; set; }

        public int TweetId { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

    }
}
