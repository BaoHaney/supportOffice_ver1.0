using System;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace supportOffice
{
    public partial class SplitFile : Form
    {
        int option;
        public SplitFile()
        {
            InitializeComponent();
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                saveAsText.Text = dialog.SelectedPath;
            }
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = @"All Files|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chooseFileText.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            }
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            switch (option) { 
                case 1:
                    
                    break;
                case 0:
                default:
                    using (PdfReader reader = new PdfReader(chooseFileText.Text))
                    {
                        Document document = new Document();
                        PdfCopy copy = new PdfCopy(document, new FileStream(saveAsText.Text + "\\" + $"{startPage.Value}-{endPage.Value}" + Path.GetFileName(chooseFileText.Text), FileMode.Create));
                        document.Open();

                        for (int pagenumber = (int)startPage.Value; pagenumber <= endPage.Value & pagenumber >= startPage.Value; pagenumber++)
                        {
                            MessageBox.Show(pagenumber.ToString());
                            if (reader.NumberOfPages >= pagenumber)
                            {
                                copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                            }
                            else
                            {
                                break;
                            }
                        }

                        document.Close();
                    }
                    break;
            }
        }

        private void optionP_CheckedChanged(object sender, EventArgs e)
        {
            option = 0;
            labelTitle.Text = "Split PDF";
        }

        private void optionW_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
            labelTitle.Text = "Split Word";
        }
    }
}
