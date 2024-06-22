using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public GroupBox createArticle(Article article, Point point)
        {
            GroupBox groupBox5 = new System.Windows.Forms.GroupBox();
            Label label1 = new System.Windows.Forms.Label();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Panel panel1 = new System.Windows.Forms.Panel();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();


            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(this.panel1);
            groupBox5.Location = point;
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(775, 258);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = article.getTitle();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 13);
            label1.TabIndex = 0;
            label1.Text = "By: " + article.getEmail();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(3, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Size = new System.Drawing.Size(739, 80);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(this.textBox1);
            panel1.Controls.Add(this.label1);
            panel1.Location = new System.Drawing.Point(7, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(762, 224);
            panel1.TabIndex = 2;
            createListOfComments(article.getComments(), new Point(15, 250));


            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();

            return groupBox5;
        }

        private GroupBox createComment(Comment comment, Point point)
        {
            GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
            Label label2 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();


            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = point;
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(773, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = comment.getName();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(7, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(762, 20);
            textBox1.TabIndex = 0;
            textBox1.Text = comment.getText();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 1;
            label1.Text = "Rating:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 13);
            label2.TabIndex = 2;
            label2.Text = comment.getRating();

            return groupBox1;
        }
        
        private void createListOfComments(List<Comment> comments, Point point)
        {
            foreach (Comment comment in comments)
            {
                this.Controls.Add(createComment(comment, point));
                point.Y += 80;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User gay = new User("goy", "zhid");
            List<Comment> comments = new List<Comment>();
            Comment commentee = new Comment(gay, "azazazaz", 4);
            comments.Add(commentee);
            Article art = new Article(gay, "poschalkoo", "skibidi toilet", comments);

            this.Controls.Add(createArticle(art, new Point(15,15)));
        }
    }
}
