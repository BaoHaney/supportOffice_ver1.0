using System;
using System.Windows.Forms;
using System.IO;

namespace supportOffice
{
    public partial class Rename : Form
    {
        string newName;
        public Rename()
        {
            InitializeComponent();
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = @"All Files|*.*";
            open.FileName = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Savet1.Text = System.IO.Path.GetFullPath(open.FileName);
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            // Source file to be renamed  
            string sourceFile = Savet1.Text;
            string fileName = Path.GetFileNameWithoutExtension(sourceFile);

            // Create a FileInfo  
            System.IO.FileInfo fi = new System.IO.FileInfo(sourceFile);

            // Check if file is there  
            if (fi.Exists)
            {
                // Move file with a new name. Hence renamed.
                if (textBoxBrowser.Text == "")
                {
                    fi.MoveTo(sourceFile.Replace(fileName, newName));
                }
                else
                {
                    string pathSaveAs = textBoxBrowser.Text;
                    fi.MoveTo(pathSaveAs + "\\" + Path.GetFileName(sourceFile).Replace(fileName, newName));
                }
                labelNoti.Text = "File Renamed Success.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newName = textBox1.Text;
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxBrowser.Text = dialog.SelectedPath;
            }
        }
    }
}
