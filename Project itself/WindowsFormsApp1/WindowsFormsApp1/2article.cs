using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Article
    {
        static int autoID = 100;
        public int id = 0;
        public User user = null;
        public string title = null;
        public string text = null;
        public List<Comment> comments = null;

        public Article(User user, string title, string text, List<Comment> comments)
        {
            this.user = user;
            this.title = title;
            this.text = text;
            this.comments = comments;
        }

        public string getEmail()
        {
            return user.getName();
        }
        public string getTitle()
        {
            return title;
        }
        public int getId()
        {
            return id;
        }
        public string getText()
        {
            return text;
        }
        public List<Comment> getComments()
        {
            return comments;
        }
        public void addComment(Comment comment)
        {
            comments.Add(comment);
        }
    }
}
