using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Lib;
using System.IO;

namespace Tyuiu.YangolenkoDS.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_YDS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatix_YDS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int col;
        static string openFilePath;
        private void groupBoxInput_YDS_Enter(object sender, EventArgs e)
        {

        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string filedata = File.ReadAllText(filePath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            col = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, col];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < col; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;

        }
        private void buttonOpenFile_YDS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_YDS.ShowDialog();
            openFilePath = openFileDialogTask_YDS.FileName;

            int[,] arrayValues = new int[rows, col];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInput_YDS.ColumnCount = col;
            dataGridViewInput_YDS.RowCount = rows;
            dataGridViewOutput_YDS.ColumnCount = col;
            dataGridViewOutput_YDS.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewInput_YDS.Columns[i].Width = 25;
                dataGridViewOutput_YDS.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewInput_YDS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_YDS.Enabled = true;
        }

        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, col];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewOutput_YDS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_YDS.Enabled = true;
        }

        private void buttonSaveFile_YDS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatix_YDS.FileName = "OutPutFileTask7V25.csv";
            saveFileDialogMatix_YDS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatix_YDS.ShowDialog();

            string path = saveFileDialogMatix_YDS.FileName;
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutput_YDS.RowCount;
            int col = dataGridViewOutput_YDS.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col - 1)
                    {
                        str = str + dataGridViewOutput_YDS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_YDS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void File_Load_YDS(object sender, EventArgs e)
        {
            dataGridViewInput_YDS.ColumnCount = 50;
            dataGridViewOutput_YDS.ColumnCount = 50;

            dataGridViewOutput_YDS.RowCount = 50;
            dataGridViewInput_YDS.RowCount = 50;
            panelLeft_YDS.Width = this.Width / 2;
            panelRight_YDS.Width = this.Width / 2;
        }
    }
}
