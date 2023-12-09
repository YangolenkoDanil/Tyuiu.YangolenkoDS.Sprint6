using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YangolenkoDS.Sprint6.Task5.V16.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\angol\source\repos\Tyuiu.YangolenkoDS.Sprint6\Tyuiu.YangolenkoDS.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";

        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_YDS.ColumnCount = 2;
            dataGridViewResult_YDS.Columns[0].Width = 20;
            dataGridViewResult_YDS.Columns[1].Width = 50;

            this.chartResult_YDS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_YDS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_YDS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_YDS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_YDS.Series[0].Points.AddXY(i, numsMass[i]);

            }
        }

        private void buttonOpen_YDS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1 Янголенко Данил Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
