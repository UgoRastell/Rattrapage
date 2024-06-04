using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PostedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
