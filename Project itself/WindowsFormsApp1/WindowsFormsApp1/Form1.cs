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

        }
    }
}
