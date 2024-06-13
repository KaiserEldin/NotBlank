using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Comment
    {
        static int autoID = 200;
        int id = 0;
        User commentator = null;
        string text = "";

        public Comment(string name, string password, string text)
        {
            id = autoID++;
            commentator = new User(name, password);
            this.text = text;
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
    }
}
