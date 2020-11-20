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

namespace test15_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        class Rabbit
        {
            public void Run(TextBox textBox)
            {
                int num = 0;
                for (int i = 0; i < 10; i++)
                {
                    num += 10;
                    textBox.Text += "\r\n 兔子跑了" + num + "米";
                    if (i == 9)
                    {
                        textBox.Text += "\r\n 兔子在睡觉";
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                textBox.Text += "\r\n 兔子到达终点";
            }
            public void Run(RichTextBox textBox)
            {
                int num = 0;
                for (int i = 0; i < 10; i++)
                {
                    num += 10;
                    textBox.Text += "\n 兔子跑了" + num + "米";
                    if (i == 9)
                    {
                        textBox.Text += "\n 兔子在睡觉";
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                textBox.Text += "\n 兔子到达终点";
            }
        }
        class Tortoise
        {
            public void Run(TextBox textBox)
            {
                int num = 0;
                for (int i = 0; i < 10; i++)
                {
                    num += 10;
                    textBox.Text += "\r\n 乌龟跑了" + num + "米";
                    Thread.Sleep(200);
                }
                textBox.Text += "\r\n 乌龟到达终点";
            }
            public void Run(RichTextBox textBox)
            {
                int num = 0;
                for (int i = 0; i < 10; i++)
                {
                    num += 10;
                    textBox.Text += "\n 乌龟跑了" + num + "米";
                    Thread.Sleep(200);
                }
                textBox.Text += "\n 乌龟到达终点";
            }
        }
        class RunMatch
        {
            private object thisLock = new object();
            public void Run()
            {
                int num = 0;
                lock (thisLock)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        num += 10;
                        if (Thread.CurrentThread.Name == "兔子")
                        {
                            if (num >= 90)
                            {
                                //this.text
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                Thread.Sleep(100);
                            }
                        }
                        else
                        {
                            Thread.Sleep(200);
                        }
                    }
                }
            }
        }
        public void Run(TextBox textBox)
        {
            int num = 0;
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    num += 10;
                    textBox.Text += Thread.CurrentThread.Name + "跑了" + num + "米\n\n";
                    if (Thread.CurrentThread.Name == "兔子")
                    {
                        if (i == 8)
                        {
                            textBox.Text += "兔子在睡觉\n\n";
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Thread.Sleep(100);
                        }
                    }
                    else
                    {
                        Thread.Sleep(200);
                    }
                }
                textBox.Text += Thread.CurrentThread.Name + "到达终点\n\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Thread t1 = new Thread(() => Run(this.textBox1));
            //t1.Name = "兔子";
            //Thread t2 = new Thread(() => Run(this.textBox2));
            //t2.Name = "乌龟";
            //t1.Start();
            //t2.Start();
            Rabbit rabbit = new Rabbit();
            Tortoise tortoise = new Tortoise();
            Thread t1 = new Thread(() => rabbit.Run(this.textBox1));
            Thread t2 = new Thread(() => tortoise.Run(this.textBox2));
            t1.Start();
            t2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rabbit rabbit = new Rabbit();
            Tortoise tortoise = new Tortoise();
            Thread t1 = new Thread(() => rabbit.Run(this.richTextBox1));
            Thread t2 = new Thread(() => tortoise.Run(this.richTextBox2));
            t1.Start();
            t2.Start();
        }
    }
}
