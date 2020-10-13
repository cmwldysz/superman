using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton ctrl in this.groupBox2.Controls)
            {
                if (ctrl.Checked == true)
                {
                    switch (ctrl.Text)
                    {
                        case "红灯":
                            //this.pictureBox1.BackgroundImage = Image.FromFile("Red.png");
                            this.pictureBox1.Image = Image.FromFile("Red.png");
                            break;
                        case "黄灯":
                            //this.pictureBox1.BackgroundImage = Image.FromFile("Yellow.png");
                            this.pictureBox1.Image = Image.FromFile("Yellow.png");
                            break;
                        case "绿灯":
                            //this.pictureBox1.BackgroundImage = Image.FromFile("Green.png");
                            this.pictureBox1.Image = Image.FromFile("Green.png");
                            break;
                        default:
                            break;
                    }
                    return;
                }
            }
            GC.Collect();
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox1.BackColor);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox2.BackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 2;
            foreach (RadioButton ctrl in this.groupBox1.Controls)
            {
                if (ctrl.Checked == true)
                {
                    i = 0;
                    if (ctrl.Name == "radioButton6")
                    {
                        i = 1;
                    }
                }
            }
            if (i == 0)
            {
                MessageBox.Show("答案错误");
            }
            else if (i == 1)
            {
                MessageBox.Show("答案正确");
            }
            else if (i == 2)
            {

                MessageBox.Show("请选择答案");

            }
        }
    }
}
