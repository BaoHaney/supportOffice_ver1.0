using System;
using System.Windows.Forms;

namespace supportOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertPage_Click(object sender, EventArgs e)
        {
            Convert convertPage = new Convert();
            convertPage.Show();

        }

        private void combinePage_Click(object sender, EventArgs e)
        {
            Combine combinePage = new Combine();
            combinePage.Show();
        }

        private void createFilePage_Click(object sender, EventArgs e)
        {
            Create createFilePage = new Create();
            createFilePage.Show();
        }

        private void createExcelPage_Click(object sender, EventArgs e)
        {
            Excel createExcelPage = new Excel();
            createExcelPage.Show();
        }

        private void renamePage_Click(object sender, EventArgs e)
        {
            Rename renamePage = new Rename();
            renamePage.Show();
        }

        private void splitFilePage_Click(object sender, EventArgs e)
        {
            SplitFile splitFilePage = new SplitFile();
            splitFilePage.Show();
        }
    }
}
