using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox1.BackColor);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox6.Checked)
            {
                checkedChanged(true);
            }
            else
            {
                checkedChanged(false);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox7.Checked)
            {
                checkedChanged(false);
            }
        }
        private void checkedChanged(bool state)
        {
            if (state)
            {
                foreach (CheckBox item in this.groupBox1.Controls)
                {
                    item.Checked = true;
                }
                this.checkBox6.Checked = true;
                this.checkBox7.Checked = false;
            }
            else
            {
                foreach (CheckBox item in this.groupBox1.Controls)
                {
                    item.Checked = false;
                }
                this.checkBox6.Checked = false;
            }
        }
        private void G_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (CheckBox item in this.groupBox1.Controls)
            {
                if (item.Checked)
                {
                    i++;
                }
            }
            if (i == this.groupBox1.Controls.Count)
            {
                this.checkBox6.Checked = true;
            }
            else
            {
                this.checkBox6.Checked = false;
            }
            this.checkBox7.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "您选择的权限如下\n";
            foreach (CheckBox item in this.groupBox1.Controls)
            {
                if (item.Checked)
                {
                    msg += item.Text + "\n";
                }
            }
            MessageBox.Show(msg);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(checkedListBox1, checkBox8);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(checkedListBox2, checkBox9);
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(checkedListBox3, checkBox10);
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(checkedListBox4, checkBox11);
        }
        public void CheckAll(CheckedListBox ckl, CheckBox box)
        {
            ckl.Visible = box.Checked;
            for (int i = 0; i < ckl.Items.Count; i++)//遍历控件中的项并赋值
            { ckl.SetItemChecked(i, box.Checked); }
        }
    }
}
