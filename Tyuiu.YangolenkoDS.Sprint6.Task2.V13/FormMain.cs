﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.YangolenkoDS.Sprint6.Task2.V13.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds  = new DataService();
        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_YDS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_YDS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_YDS.Titles.Add("График функции");
                this.chartFunction_YDS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_YDS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_YDS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_YDS.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_YDS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_YDS.BackColor = Color.Red;
        }

        private void buttonDone_YDS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_YDS.BackColor = Color.Blue;
        }

        private void buttonDone_YDS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_YDS.BackColor = Color.Green;
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Янголенко Данил Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
