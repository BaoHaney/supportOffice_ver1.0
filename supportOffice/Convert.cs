using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IronPdf;
using Spire.Pdf;

namespace supportOffice
{
    public partial class Convert : Form
    {
        int option;
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
            option = 0;
            label1.Text = "PDF to Word";
        }

        private void convert1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string urlSave;
            string urlOpen;
            switch (option)
            {
                case 1:
                    urlOpen = Savet1.Text.Replace(".docx", ".pdf");
                    urlSave = Savet2.Text + "/" + Path.GetFileName(urlOpen);
                    wordDoc = app.Documents.Open(Savet1.Text);
                    wordDoc.ExportAsFixedFormat(urlSave, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                    wordDoc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                    app.Quit();
                    Marshal.ReleaseComObject(wordDoc);
                    Marshal.ReleaseComObject(app);
                    break;
                case 2:
                    urlOpen = Savet1.Text;
                    urlSave = Savet2.Text + "/" + Path.GetFileNameWithoutExtension(urlOpen) + ".pdf";
                    IronPdf.PdfDocument doc = ImageToPdfConverter.ImageToPdf(Savet1.Text, IronPdf.Imaging.ImageBehavior.CropPage);
                    doc.SaveAs(urlSave);
                    break;
                case 0:
                default:
                    urlOpen = Savet1.Text.Replace(".pdf", ".docx");
                    urlSave = Savet2.Text + "/" + Path.GetFileName(urlOpen);
                    Spire.Pdf.PdfDocument obj = new Spire.Pdf.PdfDocument();
                    obj.LoadFromFile(Savet1.Text);
                    obj.SaveToFile(urlSave, FileFormat.DOCX);
                    break;
            }
        }
        private void optionWtP_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
            label1.Text = "Word to PDF";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            option = 2;
            label1.Text = "Image to PDF";
        }
    }
}
