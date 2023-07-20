using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supportOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Convert page1 = new Convert();
            page1.Show();
        }

        private void Combine_Click(object sender, EventArgs e)
        {
            Combine page2 = new Combine();
            page2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Create page3 = new Create();
            page3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excel page4 = new Excel();
            page4.Show();
        }
    }
}
