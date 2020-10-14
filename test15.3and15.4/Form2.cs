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

namespace test15._3and15._4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        bool state = false;
        void DoWork() {
            while (true)
            {
                    this.BackColor = Color.Yellow;
                    this.label1.ForeColor = Color.FromArgb(0, 0, 192);
                Thread.Sleep(3000);
                    this.BackColor = Color.Black;
                    this.label1.ForeColor = Color.Red;
                Thread.Sleep(3000);
            }
        }
        Thread t;
        private void Form2_Load(object sender, EventArgs e)
        {
            t = new Thread(DoWork);
            t.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }
    }
}
