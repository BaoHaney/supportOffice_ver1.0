using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace supportOffice
{
    public partial class Combine : Form
    {
        public Combine()
        {
            InitializeComponent();
        }

        private void inputcb1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = @"All Files|*.docx";
            open.Multiselect = true;
            open.Title = "Open Text Files";

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FileNames.Length < 2) return;
                listFilesText.Text = "";
                foreach (String file in open.FileNames)
                {
                    listFilesText.Text += $"{file},";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Savet3.Text = dialog.SelectedPath;
            }
        }
        public static void Merge(string[] filesToMerge, string outputFilename, bool insertPageBreaks)
        {
            object missing = System.Type.Missing;
            object pageBreak = Word.WdBreakType.wdSectionBreakNextPage;
            object outputFile = outputFilename;

            // Create a new Word application
            Word._Application wordApplication = new Word.Application();

            try
            {
                // Create a new file based on our template
                Word.Document wordDocument = wordApplication.Documents.Add(
                                              ref missing
                                            , ref missing
                                            , ref missing
                                            , ref missing);

                // Make a Word selection object.
                Word.Selection selection = wordApplication.Selection;

                //Count the number of documents to insert;
                int documentCount = filesToMerge.Length;

                //A counter that signals that we shoudn't insert a page break at the end of document.
                int breakStop = 0;

                // Loop thru each of the Word documents
                foreach (string file in filesToMerge)
                {
                    if (file != "")
                    {
                        breakStop++;
                        // Insert the files to our template
                        selection.InsertFile(
                                                    file
                                                , ref missing
                                                , ref missing
                                                , ref missing
                                                , ref missing);

                        //Do we want page breaks added after each documents?
                        if (insertPageBreaks && breakStop != documentCount)
                        {
                            selection.InsertBreak(ref pageBreak);
                        }
                    };

                }

                // Save the document to it's output file.
                wordDocument.SaveAs(
                                ref outputFile
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing);

                // Clean up!
                wordDocument = null;
            }
            catch (Exception ex)
            {
                //I didn't include a default error handler so i'm just throwing the error
                throw ex;
            }
            finally
            {
                // Finally, Close our Word application
                wordApplication.Quit(ref missing, ref missing, ref missing);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listFilesText.Text.Split(',').Length < 2) return;
            Merge(listFilesText.Text.Split(','), Savet3.Text + "\\mergeFile", true);
            MessageBox.Show("Combine successfully");
        }
    }
}
