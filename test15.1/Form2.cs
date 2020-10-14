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

namespace test15._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        bool state = false;
        Random rm = new Random();
        string str = "";
        void GetTel1()
        {
            try
            {
                while (true)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append("1");
                    str.Append(rm.Next(0, 9));
                    str.Append(rm.Next(0, 9));
                    str.Append("*");
                    str.Append("*");
                    str.Append("*");
                    str.Append("*");
                    str.Append(rm.Next(0, 9));
                    str.Append(rm.Next(0, 9));
                    str.Append(rm.Next(0, 9));
                    str.Append(rm.Next(0, 9));
                    this.label1.Text = str.ToString();
                    Thread.Sleep(100);
                    Application.DoEvents();
                    Console.WriteLine("GetTel1");
                }
            }
            catch { }
        }
        void GetTel2()
        {
            try
            {
                while (true)
                {
                    str = "";
                    str += "1";
                    str += rm.Next(0, 9);
                    str += rm.Next(0, 9);
                    str += "****";
                    str += rm.Next(0, 9);
                    str += rm.Next(0, 9);
                    str += rm.Next(0, 9);
                    str += rm.Next(0, 9);
                    this.label2.Text = str;
                    Thread.Sleep(100);
                    Application.DoEvents();
                    Console.WriteLine("GetTel2");
                }
            }
            catch { }
        }
        void GetTel3() {
            while (true)
            {
                string[] list = { "138****2334", "123****4454", "173****0000", "193****7777", "145****8888", "156****5555", "126****9999", "195****1223", "182****4754" };
                int i = rm.Next(0, list.Length);
                this.label3.Text = list[i];
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }
        Thread T1;
        Thread T2;
        Thread T3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (state)
            {
                state = false;
                T1.Abort();
                T2.Abort();
                T3.Abort();
                this.button1.Text = "开始抽奖";
            }
            else {
                state = true;
                T1 = new Thread(GetTel1);
                T1.IsBackground = true;
                T1.Start();
                T2 = new Thread(GetTel2);
                T2.IsBackground = true;
                T2.Start();
                T3 = new Thread(GetTel3);
                T3.IsBackground = true;
                T3.Start();
                this.button1.Text = "停止抽奖";
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (state)
            {
                T1.Abort();
                T2.Abort();
                T3.Abort();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
