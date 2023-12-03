namespace Tyuiu.YangolenkoDS.Sprint6.Task2.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxVars_YDS = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_YDS = new System.Windows.Forms.PictureBox();
            this.dataGridViewFunction_YDS = new System.Windows.Forms.DataGridView();
            this.labelStart_YDS = new System.Windows.Forms.Label();
            this.labelStop_YDS = new System.Windows.Forms.Label();
            this.labelResult_YDS = new System.Windows.Forms.Label();
            this.textBoxStart_YDS = new System.Windows.Forms.TextBox();
            this.textBoxStop_YDS = new System.Windows.Forms.TextBox();
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.buttonDone_YDS = new System.Windows.Forms.Button();
            this.chartFunction_YDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_YDS.SuspendLayout();
            this.groupBoxResult_YDS.SuspendLayout();
            this.groupBoxVars_YDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_YDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_YDS
            // 
            this.groupBoxCondition_YDS.Controls.Add(this.pictureBoxCondition_YDS);
            this.groupBoxCondition_YDS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_YDS.Name = "groupBoxCondition_YDS";
            this.groupBoxCondition_YDS.Size = new System.Drawing.Size(698, 310);
            this.groupBoxCondition_YDS.TabIndex = 1;
            this.groupBoxCondition_YDS.TabStop = false;
            this.groupBoxCondition_YDS.Text = "Условие";
            // 
            // groupBoxResult_YDS
            // 
            this.groupBoxResult_YDS.Controls.Add(this.chartFunction_YDS);
            this.groupBoxResult_YDS.Controls.Add(this.labelResult_YDS);
            this.groupBoxResult_YDS.Controls.Add(this.dataGridViewFunction_YDS);
            this.groupBoxResult_YDS.Location = new System.Drawing.Point(718, 13);
            this.groupBoxResult_YDS.Name = "groupBoxResult_YDS";
            this.groupBoxResult_YDS.Size = new System.Drawing.Size(632, 425);
            this.groupBoxResult_YDS.TabIndex = 2;
            this.groupBoxResult_YDS.TabStop = false;
            this.groupBoxResult_YDS.Text = "Вывод данных";
            // 
            // groupBoxVars_YDS
            // 
            this.groupBoxVars_YDS.Controls.Add(this.textBoxStop_YDS);
            this.groupBoxVars_YDS.Controls.Add(this.textBoxStart_YDS);
            this.groupBoxVars_YDS.Controls.Add(this.labelStop_YDS);
            this.groupBoxVars_YDS.Controls.Add(this.labelStart_YDS);
            this.groupBoxVars_YDS.Location = new System.Drawing.Point(13, 330);
            this.groupBoxVars_YDS.Name = "groupBoxVars_YDS";
            this.groupBoxVars_YDS.Size = new System.Drawing.Size(262, 100);
            this.groupBoxVars_YDS.TabIndex = 3;
            this.groupBoxVars_YDS.TabStop = false;
            this.groupBoxVars_YDS.Text = "Ввод данных";
            // 
            // pictureBoxCondition_YDS
            // 
            this.pictureBoxCondition_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task2.V13.Properties.Resources.Task2V13;
            this.pictureBoxCondition_YDS.Location = new System.Drawing.Point(7, 22);
            this.pictureBoxCondition_YDS.Name = "pictureBoxCondition_YDS";
            this.pictureBoxCondition_YDS.Size = new System.Drawing.Size(685, 282);
            this.pictureBoxCondition_YDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCondition_YDS.TabIndex = 0;
            this.pictureBoxCondition_YDS.TabStop = false;
            // 
            // dataGridViewFunction_YDS
            // 
            this.dataGridViewFunction_YDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_YDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_YDS.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewFunction_YDS.Name = "dataGridViewFunction_YDS";
            this.dataGridViewFunction_YDS.RowHeadersVisible = false;
            this.dataGridViewFunction_YDS.RowHeadersWidth = 51;
            this.dataGridViewFunction_YDS.RowTemplate.Height = 24;
            this.dataGridViewFunction_YDS.Size = new System.Drawing.Size(169, 367);
            this.dataGridViewFunction_YDS.TabIndex = 0;
            // 
            // labelStart_YDS
            // 
            this.labelStart_YDS.AutoSize = true;
            this.labelStart_YDS.Location = new System.Drawing.Point(7, 22);
            this.labelStart_YDS.Name = "labelStart_YDS";
            this.labelStart_YDS.Size = new System.Drawing.Size(83, 16);
            this.labelStart_YDS.TabIndex = 0;
            this.labelStart_YDS.Text = "Старт шага:";
            // 
            // labelStop_YDS
            // 
            this.labelStop_YDS.AutoSize = true;
            this.labelStop_YDS.Location = new System.Drawing.Point(138, 22);
            this.labelStop_YDS.Name = "labelStop_YDS";
            this.labelStop_YDS.Size = new System.Drawing.Size(84, 16);
            this.labelStop_YDS.TabIndex = 1;
            this.labelStop_YDS.Text = "Конец шага:";
            // 
            // labelResult_YDS
            // 
            this.labelResult_YDS.AutoSize = true;
            this.labelResult_YDS.Location = new System.Drawing.Point(6, 28);
            this.labelResult_YDS.Name = "labelResult_YDS";
            this.labelResult_YDS.Size = new System.Drawing.Size(80, 16);
            this.labelResult_YDS.TabIndex = 1;
            this.labelResult_YDS.Text = "Результат:";
            // 
            // textBoxStart_YDS
            // 
            this.textBoxStart_YDS.Location = new System.Drawing.Point(10, 42);
            this.textBoxStart_YDS.Name = "textBoxStart_YDS";
            this.textBoxStart_YDS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_YDS.TabIndex = 2;
            // 
            // textBoxStop_YDS
            // 
            this.textBoxStop_YDS.Location = new System.Drawing.Point(141, 41);
            this.textBoxStop_YDS.Name = "textBoxStop_YDS";
            this.textBoxStop_YDS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_YDS.TabIndex = 3;
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_YDS.Location = new System.Drawing.Point(281, 345);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(180, 93);
            this.buttonHelp_YDS.TabIndex = 4;
            this.buttonHelp_YDS.Text = "Справка";
            this.buttonHelp_YDS.UseVisualStyleBackColor = false;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // buttonDone_YDS
            // 
            this.buttonDone_YDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_YDS.Location = new System.Drawing.Point(477, 345);
            this.buttonDone_YDS.Name = "buttonDone_YDS";
            this.buttonDone_YDS.Size = new System.Drawing.Size(228, 93);
            this.buttonDone_YDS.TabIndex = 5;
            this.buttonDone_YDS.Text = "Выполнить";
            this.buttonDone_YDS.UseVisualStyleBackColor = false;
            this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
            this.buttonDone_YDS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_YDS_MouseDown);
            this.buttonDone_YDS.MouseEnter += new System.EventHandler(this.buttonDone_YDS_MouseEnter);
            this.buttonDone_YDS.MouseLeave += new System.EventHandler(this.buttonDone_YDS_MouseLeave);
            // 
            // chartFunction_YDS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_YDS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_YDS.Legends.Add(legend1);
            this.chartFunction_YDS.Location = new System.Drawing.Point(198, 48);
            this.chartFunction_YDS.Name = "chartFunction_YDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_YDS.Series.Add(series1);
            this.chartFunction_YDS.Size = new System.Drawing.Size(428, 369);
            this.chartFunction_YDS.TabIndex = 2;
            this.chartFunction_YDS.Text = "chart1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 450);
            this.Controls.Add(this.buttonDone_YDS);
            this.Controls.Add(this.buttonHelp_YDS);
            this.Controls.Add(this.groupBoxVars_YDS);
            this.Controls.Add(this.groupBoxResult_YDS);
            this.Controls.Add(this.groupBoxCondition_YDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Янголенко Д. С.";
            this.groupBoxCondition_YDS.ResumeLayout(false);
            this.groupBoxResult_YDS.ResumeLayout(false);
            this.groupBoxResult_YDS.PerformLayout();
            this.groupBoxVars_YDS.ResumeLayout(false);
            this.groupBoxVars_YDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_YDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_YDS;
        private System.Windows.Forms.PictureBox pictureBoxCondition_YDS;
        private System.Windows.Forms.GroupBox groupBoxResult_YDS;
        private System.Windows.Forms.GroupBox groupBoxVars_YDS;
        private System.Windows.Forms.Label labelResult_YDS;
        private System.Windows.Forms.DataGridView dataGridViewFunction_YDS;
        private System.Windows.Forms.TextBox textBoxStop_YDS;
        private System.Windows.Forms.TextBox textBoxStart_YDS;
        private System.Windows.Forms.Label labelStop_YDS;
        private System.Windows.Forms.Label labelStart_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
        private System.Windows.Forms.Button buttonDone_YDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

