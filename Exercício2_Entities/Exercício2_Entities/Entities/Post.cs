using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2_Entities.Entities
{
    public class Post
    {
        public DateTime moment { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int likes { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment> ();
        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            this.moment = moment;
            this.title = title;
            this.content = content;
            this.likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);
        }
        
        public override string ToString()
        {
            return "moment: " + moment + "\n" +
                "title: " + title + "\n" +
                "content: " + content + "\n" + 
                "likes: " + likes.ToString();
        }
    }
}
