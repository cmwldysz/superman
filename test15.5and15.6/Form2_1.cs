using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test15._5and15._6
{
    public partial class Form2_1 : Form
    {
        string fileName = "";
        string directoryName = "";
        int totalSize;//源文件的大小
        int position = 0;//记录文件已复制的大小
        public Form2_1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public Form2_1(string fileN,string directN) : this() {
            this.fileName = fileN;
            this.directoryName = directN;
        }
        void Pro1() {
            
        }
    }
}
