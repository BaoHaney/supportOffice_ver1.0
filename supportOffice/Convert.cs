using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Word = Microsoft.Office.Interop.Word;
using Spire.Pdf;

namespace supportOffice
{
    public partial class Convert : Form
    {
        int option1, option2;
        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }
        public Convert()
        {
            InitializeComponent();
        }

        private void browser1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"All Files|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Savet1.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            }
        }

        private void save1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Savet2.Text = dialog.SelectedPath;
            }
        }

        private void optionPtW_CheckedChanged(object sender, EventArgs e)
        {
            option2 = 1;
            label1.Text = "PDF to PDF";
        }

        private void convert1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            if (option1 == 1)
            {
                string temp = Savet1.Text.Replace(".docx", ".pdf");
                string urlSave = Savet2.Text + "/" + Path.GetFileName(temp);
                wordDoc = app.Documents.Open(Savet1.Text);
                wordDoc.ExportAsFixedFormat(urlSave, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                wordDoc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                app.Quit();
                Marshal.ReleaseComObject(wordDoc);
                Marshal.ReleaseComObject(app);
                if (File.Exists(Path.GetFileName(temp)) == true)
                {
                    Process.Start(Path.GetFileName(temp));
                    MessageBox.Show("Convert Word to PDF successfully");
                }
            }
            else
            {
                string urlOpen = Savet1.Text.Replace(".pdf", ".docx");
                string urlSave = Savet2.Text + "/" + Path.GetFileName(urlOpen);
                PdfDocument obj = new PdfDocument();
                obj.LoadFromFile(Savet1.Text);
                obj.SaveToFile(urlSave, FileFormat.DOCX);
                if (File.Exists(Path.GetFileName(urlSave)) == true)
                {
                    Process.Start(Path.GetFileName(urlSave));
                    MessageBox.Show("Convert PDF to PDF successfully");
                }

            }
        }
            private void optionWtP_CheckedChanged(object sender, EventArgs e)
        {
            option1 = 1;
            label1.Text = "Word to PDF";
        }
    }
}
