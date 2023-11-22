using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurcach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 b;
        private void button1_Click(object sender, EventArgs e)
        {
            b = new Form2();
            b.Visible = true;
        }
        private Form4 table;
        private void button2_Click(object sender, EventArgs e)
        {
            table = new Form4();
            table.Visible = true;
        }
        private Form6 ta;
        private void button3_Click(object sender, EventArgs e)
        {
            ta = new Form6();
            ta.Visible = true;
        }
        private Form7 tat;
        private void button4_Click(object sender, EventArgs e)
        {
            tat= new Form7();
            tat.Visible = true;
        }
    }
}
