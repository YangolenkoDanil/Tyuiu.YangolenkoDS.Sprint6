﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.YangolenkoDS.Sprint6.Task1.V1.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_YDS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_YDS.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_YDS.Text = "";

                textBoxResult_YDS.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_YDS.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_YDS.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |{1, 8:f2}   |", startStep, valueArray[i]);
                    textBoxResult_YDS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_YDS.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-1 Янголенко Данил Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
