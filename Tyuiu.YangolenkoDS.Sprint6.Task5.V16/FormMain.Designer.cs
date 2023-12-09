namespace Tyuiu.YangolenkoDS.Sprint6.Task5.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_YDS = new System.Windows.Forms.Panel();
            this.panelLeft_YDS = new System.Windows.Forms.Panel();
            this.panelRight_YDS = new System.Windows.Forms.Panel();
            this.groupBoxTask_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_YDS = new System.Windows.Forms.GroupBox();
            this.labelTask_YDS = new System.Windows.Forms.Label();
            this.dataGridViewResult_YDS = new System.Windows.Forms.DataGridView();
            this.chartResult_YDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_YDS = new System.Windows.Forms.Button();
            this.buttonOpen_YDS = new System.Windows.Forms.Button();
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.panelTop_YDS.SuspendLayout();
            this.panelLeft_YDS.SuspendLayout();
            this.panelRight_YDS.SuspendLayout();
            this.groupBoxTask_YDS.SuspendLayout();
            this.groupBoxOutPutData_YDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_YDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_YDS
            // 
            this.panelTop_YDS.Controls.Add(this.buttonHelp_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonOpen_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonDone_YDS);
            this.panelTop_YDS.Controls.Add(this.groupBoxTask_YDS);
            this.panelTop_YDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_YDS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_YDS.Name = "panelTop_YDS";
            this.panelTop_YDS.Size = new System.Drawing.Size(924, 100);
            this.panelTop_YDS.TabIndex = 0;
            // 
            // panelLeft_YDS
            // 
            this.panelLeft_YDS.Controls.Add(this.groupBoxOutPutData_YDS);
            this.panelLeft_YDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_YDS.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_YDS.Name = "panelLeft_YDS";
            this.panelLeft_YDS.Size = new System.Drawing.Size(226, 429);
            this.panelLeft_YDS.TabIndex = 1;
            // 
            // panelRight_YDS
            // 
            this.panelRight_YDS.Controls.Add(this.chartResult_YDS);
            this.panelRight_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_YDS.Location = new System.Drawing.Point(226, 100);
            this.panelRight_YDS.Name = "panelRight_YDS";
            this.panelRight_YDS.Size = new System.Drawing.Size(698, 429);
            this.panelRight_YDS.TabIndex = 2;
            // 
            // groupBoxTask_YDS
            // 
            this.groupBoxTask_YDS.Controls.Add(this.labelTask_YDS);
            this.groupBoxTask_YDS.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_YDS.Name = "groupBoxTask_YDS";
            this.groupBoxTask_YDS.Size = new System.Drawing.Size(429, 90);
            this.groupBoxTask_YDS.TabIndex = 0;
            this.groupBoxTask_YDS.TabStop = false;
            this.groupBoxTask_YDS.Text = "Условие:";
            // 
            // groupBoxOutPutData_YDS
            // 
            this.groupBoxOutPutData_YDS.Controls.Add(this.dataGridViewResult_YDS);
            this.groupBoxOutPutData_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_YDS.Name = "groupBoxOutPutData_YDS";
            this.groupBoxOutPutData_YDS.Size = new System.Drawing.Size(226, 429);
            this.groupBoxOutPutData_YDS.TabIndex = 0;
            this.groupBoxOutPutData_YDS.TabStop = false;
            this.groupBoxOutPutData_YDS.Text = "Вывод данных:";
            // 
            // labelTask_YDS
            // 
            this.labelTask_YDS.AutoSize = true;
            this.labelTask_YDS.Location = new System.Drawing.Point(7, 22);
            this.labelTask_YDS.Name = "labelTask_YDS";
            this.labelTask_YDS.Size = new System.Drawing.Size(401, 48);
            this.labelTask_YDS.TabIndex = 0;
            this.labelTask_YDS.Text = "Прочитать данные из файла InPutFileTask5V16.txt. \r\nВывести в dataGridView. Вывест" +
    "и все положительные числа. \r\nПостроить диаграмму по этим значениям. ";
            // 
            // dataGridViewResult_YDS
            // 
            this.dataGridViewResult_YDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_YDS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResult_YDS.Name = "dataGridViewResult_YDS";
            this.dataGridViewResult_YDS.RowHeadersWidth = 51;
            this.dataGridViewResult_YDS.RowTemplate.Height = 24;
            this.dataGridViewResult_YDS.Size = new System.Drawing.Size(220, 408);
            this.dataGridViewResult_YDS.TabIndex = 0;
            // 
            // chartResult_YDS
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult_YDS.ChartAreas.Add(chartArea3);
            this.chartResult_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult_YDS.Legends.Add(legend3);
            this.chartResult_YDS.Location = new System.Drawing.Point(0, 0);
            this.chartResult_YDS.Name = "chartResult_YDS";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_YDS.Series.Add(series3);
            this.chartResult_YDS.Size = new System.Drawing.Size(698, 429);
            this.chartResult_YDS.TabIndex = 0;
            this.chartResult_YDS.Text = "chart1";
            // 
            // buttonDone_YDS
            // 
            this.buttonDone_YDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_YDS.Location = new System.Drawing.Point(478, 19);
            this.buttonDone_YDS.Name = "buttonDone_YDS";
            this.buttonDone_YDS.Size = new System.Drawing.Size(129, 65);
            this.buttonDone_YDS.TabIndex = 1;
            this.buttonDone_YDS.Text = "Выполнить";
            this.buttonDone_YDS.UseVisualStyleBackColor = false;
            this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
            // 
            // buttonOpen_YDS
            // 
            this.buttonOpen_YDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpen_YDS.Location = new System.Drawing.Point(613, 19);
            this.buttonOpen_YDS.Name = "buttonOpen_YDS";
            this.buttonOpen_YDS.Size = new System.Drawing.Size(129, 65);
            this.buttonOpen_YDS.TabIndex = 2;
            this.buttonOpen_YDS.Text = "Открыть файл";
            this.buttonOpen_YDS.UseVisualStyleBackColor = false;
            this.buttonOpen_YDS.Click += new System.EventHandler(this.buttonOpen_YDS_Click);
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp_YDS.Location = new System.Drawing.Point(779, 19);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(129, 65);
            this.buttonHelp_YDS.TabIndex = 3;
            this.buttonHelp_YDS.Text = "Справка";
            this.buttonHelp_YDS.UseVisualStyleBackColor = false;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 529);
            this.Controls.Add(this.panelRight_YDS);
            this.Controls.Add(this.panelLeft_YDS);
            this.Controls.Add(this.panelTop_YDS);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Янголенко Д. С.";
            this.panelTop_YDS.ResumeLayout(false);
            this.panelLeft_YDS.ResumeLayout(false);
            this.panelRight_YDS.ResumeLayout(false);
            this.groupBoxTask_YDS.ResumeLayout(false);
            this.groupBoxTask_YDS.PerformLayout();
            this.groupBoxOutPutData_YDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_YDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_YDS;
        private System.Windows.Forms.GroupBox groupBoxTask_YDS;
        private System.Windows.Forms.Label labelTask_YDS;
        private System.Windows.Forms.Panel panelLeft_YDS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YDS;
        private System.Windows.Forms.DataGridView dataGridViewResult_YDS;
        private System.Windows.Forms.Panel panelRight_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
        private System.Windows.Forms.Button buttonOpen_YDS;
        private System.Windows.Forms.Button buttonDone_YDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_YDS;
    }
}

