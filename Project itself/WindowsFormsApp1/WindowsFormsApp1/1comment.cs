using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Comment
    {
        static int autoID = 200;
        int id = 0;
        User commentator = null;
        string text = "";
        int rating = 0;

        public Comment(string name, string password, string text, int rating)
        {
            id = autoID++;
            commentator = new User(name, password);
            this.text = text;
            this.rating = rating;
        }
        public Comment(User commentator, string text, int rating)
        {
            this.commentator = commentator;
            this.text = text;
            this.rating = rating;
        }

        public int getId()
        {
            return id;
        }
        public string getText()
        {
            return text;
        }
        public void setText(string text)
        {
            this.text = text;
        }
        public string getName()
        {
            return commentator.getName();
        }
        public string getRating()
        {
            return rating.ToString();
        }
        public void setRating(int rating)
        {
            this.rating = rating;
        }
    }
}
