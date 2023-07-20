using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace supportOffice
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = fileName.Text;
            var word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;
            word.WindowState = WdWindowState.wdWindowStateNormal;
            Microsoft.Office.Interop.Word.Document doc = word.Documents.Add();
            Microsoft.Office.Interop.Word.Paragraph paragraph = doc.Paragraphs.Add();
            paragraph.Range.Text = TextBox1.Text;
            doc.SaveAs2(temp+".doc");
            MessageBox.Show("Create successfully");
        }

        private void save1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Savet2.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text2 = Savet2.Text + "/"+ fileName.Text+".txt";
            var myCreate = File.Create(text2);
            myCreate.Close();
            using (StreamWriter text = new StreamWriter(text2))
            {
                text.WriteLine(TextBox1.Text);
            }
            MessageBox.Show("Write file successfully");
            //File.WriteAllText(text2, TextBox1.Text);
            MessageBox.Show("Create file successfully");
        }
    }
}
