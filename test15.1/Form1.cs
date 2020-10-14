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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        int x = 12,y=10;
        Thread t;
        void Roll() {
            while (x<=this.Width)
            {
                this.button1.Location = new Point(x, y);
                Thread.Sleep(500);
                Application.DoEvents();
                x += 12;
                y += 10;
                if (x>=this.Width)
                {
                    x = 12;
                    y = 10;
                }
                //Console.WriteLine("x={0},y={1}", x, y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(t.ThreadState);
            switch (t.ThreadState)
            {
                case ThreadState.Running:
                    break;
                case ThreadState.StopRequested:
                    break;
                case ThreadState.SuspendRequested:
                    break;
                case ThreadState.Background:
                    break;
                case ThreadState.Unstarted:
                    break;
                case ThreadState.Stopped:
                    break;
                case ThreadState.WaitSleepJoin:
                    Console.WriteLine("WaitSleepJoin");
                    t.Abort();
                    break;
                case ThreadState.Suspended:
                    break;
                case ThreadState.AbortRequested:
                    break;
                case ThreadState.Aborted:
                    Console.WriteLine("Running");
                    t = new Thread(new ThreadStart(Roll));
                    t.Start();
                    break;
                default:
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Roll));
            t.Start();
        }
    }
}
