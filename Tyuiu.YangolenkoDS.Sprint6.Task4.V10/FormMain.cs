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

using Tyuiu.YangolenkoDS.Sprint6.Task4.V10.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task4.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_YDS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_YDS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_YDS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_YDS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_YDS.Text = "";

                chartFunction_YDS.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_YDS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_YDS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введение неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-1 Янголенко Данил Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxResult_YDS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
