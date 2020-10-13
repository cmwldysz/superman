using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test9._1
{
    public partial class Form1 : Form
    {
        Random rnum = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter触发确定按钮");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esc触发退出按钮");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = rnum.Next(1, this.Width - 109);
            int y = rnum.Next(1, this.Height - 31);
            Button button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            button.Name = "button3";
            button.Size = new System.Drawing.Size(109, 31);
            button.TabIndex = 2;
            button.Text = "动态添加按钮&A";
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(this.button3_Click);
            this.Controls.Add(button);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBox2.Text == "请输入内容") {
                this.textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                this.textBox2.Text = "请输入内容";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox2.Font = new Font("宋体",9,FontStyle.Underline);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("仅支持输入数字","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
    }
}
