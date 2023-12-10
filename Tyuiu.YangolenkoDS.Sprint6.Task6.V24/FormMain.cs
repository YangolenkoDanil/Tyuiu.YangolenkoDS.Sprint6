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

using Tyuiu.YangolenkoDS.Sprint6.Task6.V24.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_YDS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_YDS.ShowDialog();
            openFilePath = openFileDialogTask_YDS.FileName;
            textBoxInput_YDS.Text = File.ReadAllText(openFilePath);
            groupBoxInput_YDS.Text = groupBoxInput_YDS.Text + " " + openFileDialogTask_YDS.FileName;
            buttonDone_YDS.Enabled = true;
        }

        private void buttonDone_YDS_Click(object sender, EventArgs e)
        {
            textBoxOutPut_YDS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_YDS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
