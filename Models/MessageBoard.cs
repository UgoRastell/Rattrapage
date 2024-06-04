using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MessageBoard
    {
        public List<Post> Posts { get; set; }

        public MessageBoard()
        {
            Posts = new List<Post>();
        }

        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

        public IEnumerable<Post> GetPosts()
        {
            return Posts.OrderByDescending(p => p.PostedAt);
        }
    }

}
