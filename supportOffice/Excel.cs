using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Exceln = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace supportOffice
{
    public partial class Excel : Form
    {
        Exceln.Application Create = new Exceln.Application();
        public Excel()
        {
            InitializeComponent();
        }

        private void Excel_Load(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEX_Click(object sender, EventArgs e)
        {
            Exceln.Workbook xlWorkBook;
            Exceln.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = Create.Workbooks.Add(misValue);
            xlWorkSheet = (Exceln.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1,1] = input11.Text;
            xlWorkSheet.Cells[2, 1] = input12.Text;
            xlWorkSheet.Cells[3, 1] = input13.Text;
            xlWorkSheet.Cells[4, 1] = input14.Text;
            xlWorkSheet.Cells[5, 1] = input15.Text;
            xlWorkSheet.Cells[6, 1] = input16.Text;
            xlWorkSheet.Cells[7, 1] = input17.Text;
            xlWorkSheet.Cells[8, 1] = input18.Text;
            xlWorkSheet.Cells[1, 2] = input21.Text;
            xlWorkSheet.Cells[2, 2] = input22.Text;
            xlWorkSheet.Cells[3, 2] = input23.Text;
            xlWorkSheet.Cells[4, 2] = input24.Text;
            xlWorkSheet.Cells[5, 2] = input25.Text;
            xlWorkSheet.Cells[6, 2] = input26.Text;
            xlWorkSheet.Cells[7, 2] = input27.Text;
            xlWorkSheet.Cells[8, 2] = input28.Text;
            xlWorkSheet.Cells[1, 3] = input31.Text;
            xlWorkSheet.Cells[2, 3] = input32.Text;
            xlWorkSheet.Cells[3, 3] = input33.Text;
            xlWorkSheet.Cells[4, 3] = input34.Text;
            xlWorkSheet.Cells[5, 3] = input35.Text;
            xlWorkSheet.Cells[6, 3] = input36.Text;
            xlWorkSheet.Cells[7, 3] = input37.Text;
            xlWorkSheet.Cells[8, 3] = input38.Text;
            xlWorkSheet.Cells[1, 4] = input41.Text;
            xlWorkSheet.Cells[2, 4] = input42.Text;
            xlWorkSheet.Cells[3, 4] = input43.Text;
            xlWorkSheet.Cells[4, 4] = input44.Text;
            xlWorkSheet.Cells[5, 4] = input45.Text;
            xlWorkSheet.Cells[6, 4] = input46.Text;
            xlWorkSheet.Cells[7, 4] = input47.Text;
            xlWorkSheet.Cells[8, 4] = input48.Text;
            string temp = textBox1.Text + "/" + textBox2.Text + ".xls";
            xlWorkBook.SaveAs(temp, Exceln.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Exceln.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            Create.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(Create);
            MessageBox.Show("Create successful");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
