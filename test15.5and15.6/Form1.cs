using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test15._5and15._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        void BeiYong() {
            for (int i = 1; i < 6; i++)
            {
                Thread.Sleep(1000);
                label1.Text += "\n\n旅游旺季：备用" + i + "号车出发！";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(BeiYong));
            t.Start();
            for (int i = 1; i < 6; i++)
            {
                Thread.Sleep(1000);
                label1.Text += "\n\n旅游淡、旺季：" + i + "号车出发！";
                //t.Join();
            }
        }
    }
}
