namespace Tyuiu.YangolenkoDS.Sprint6.Task7.V25
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_YDS = new System.Windows.Forms.Panel();
            this.panelTop2_YDS = new System.Windows.Forms.Panel();
            this.panelRight_YDS = new System.Windows.Forms.Panel();
            this.panelLeft_YDS = new System.Windows.Forms.Panel();
            this.groupBoxTask_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_YDS = new System.Windows.Forms.GroupBox();
            this.labelTask_YDS = new System.Windows.Forms.Label();
            this.dataGridViewInput_YDS = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_YDS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_YDS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatix_YDS = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_YDS = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSaveFile_YDS = new System.Windows.Forms.Button();
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.buttonDone_YDS = new System.Windows.Forms.Button();
            this.buttonOpenFile_YDS = new System.Windows.Forms.Button();
            this.panelTop_YDS.SuspendLayout();
            this.panelTop2_YDS.SuspendLayout();
            this.panelRight_YDS.SuspendLayout();
            this.panelLeft_YDS.SuspendLayout();
            this.groupBoxTask_YDS.SuspendLayout();
            this.groupBoxInput_YDS.SuspendLayout();
            this.groupBoxOutput_YDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_YDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_YDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_YDS
            // 
            this.panelTop_YDS.Controls.Add(this.buttonSaveFile_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonHelp_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonDone_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonOpenFile_YDS);
            this.panelTop_YDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_YDS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_YDS.Name = "panelTop_YDS";
            this.panelTop_YDS.Size = new System.Drawing.Size(893, 100);
            this.panelTop_YDS.TabIndex = 0;
            // 
            // panelTop2_YDS
            // 
            this.panelTop2_YDS.Controls.Add(this.groupBoxTask_YDS);
            this.panelTop2_YDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2_YDS.Location = new System.Drawing.Point(0, 100);
            this.panelTop2_YDS.Name = "panelTop2_YDS";
            this.panelTop2_YDS.Size = new System.Drawing.Size(893, 100);
            this.panelTop2_YDS.TabIndex = 1;
            // 
            // panelRight_YDS
            // 
            this.panelRight_YDS.Controls.Add(this.groupBoxOutput_YDS);
            this.panelRight_YDS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_YDS.Location = new System.Drawing.Point(509, 200);
            this.panelRight_YDS.Name = "panelRight_YDS";
            this.panelRight_YDS.Size = new System.Drawing.Size(384, 390);
            this.panelRight_YDS.TabIndex = 1;
            // 
            // panelLeft_YDS
            // 
            this.panelLeft_YDS.Controls.Add(this.groupBoxInput_YDS);
            this.panelLeft_YDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_YDS.Location = new System.Drawing.Point(0, 200);
            this.panelLeft_YDS.Name = "panelLeft_YDS";
            this.panelLeft_YDS.Size = new System.Drawing.Size(494, 390);
            this.panelLeft_YDS.TabIndex = 2;
            // 
            // groupBoxTask_YDS
            // 
            this.groupBoxTask_YDS.Controls.Add(this.labelTask_YDS);
            this.groupBoxTask_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_YDS.Name = "groupBoxTask_YDS";
            this.groupBoxTask_YDS.Size = new System.Drawing.Size(893, 100);
            this.groupBoxTask_YDS.TabIndex = 0;
            this.groupBoxTask_YDS.TabStop = false;
            this.groupBoxTask_YDS.Text = "Условие:";
            // 
            // groupBoxInput_YDS
            // 
            this.groupBoxInput_YDS.Controls.Add(this.dataGridViewInput_YDS);
            this.groupBoxInput_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_YDS.Name = "groupBoxInput_YDS";
            this.groupBoxInput_YDS.Size = new System.Drawing.Size(494, 390);
            this.groupBoxInput_YDS.TabIndex = 0;
            this.groupBoxInput_YDS.TabStop = false;
            this.groupBoxInput_YDS.Text = "Ввод:";
            this.groupBoxInput_YDS.Enter += new System.EventHandler(this.groupBoxInput_YDS_Enter);
            // 
            // groupBoxOutput_YDS
            // 
            this.groupBoxOutput_YDS.Controls.Add(this.dataGridViewOutput_YDS);
            this.groupBoxOutput_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_YDS.Name = "groupBoxOutput_YDS";
            this.groupBoxOutput_YDS.Size = new System.Drawing.Size(384, 390);
            this.groupBoxOutput_YDS.TabIndex = 1;
            this.groupBoxOutput_YDS.TabStop = false;
            this.groupBoxOutput_YDS.Text = "Вывод:";
            // 
            // labelTask_YDS
            // 
            this.labelTask_YDS.AutoSize = true;
            this.labelTask_YDS.Location = new System.Drawing.Point(4, 22);
            this.labelTask_YDS.Name = "labelTask_YDS";
            this.labelTask_YDS.Size = new System.Drawing.Size(774, 48);
            this.labelTask_YDS.TabIndex = 0;
            this.labelTask_YDS.Text = resources.GetString("labelTask_YDS.Text");
            // 
            // dataGridViewInput_YDS
            // 
            this.dataGridViewInput_YDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_YDS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInput_YDS.Name = "dataGridViewInput_YDS";
            this.dataGridViewInput_YDS.RowHeadersWidth = 51;
            this.dataGridViewInput_YDS.RowTemplate.Height = 24;
            this.dataGridViewInput_YDS.Size = new System.Drawing.Size(488, 369);
            this.dataGridViewInput_YDS.TabIndex = 0;
            // 
            // dataGridViewOutput_YDS
            // 
            this.dataGridViewOutput_YDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_YDS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutput_YDS.Name = "dataGridViewOutput_YDS";
            this.dataGridViewOutput_YDS.RowHeadersWidth = 51;
            this.dataGridViewOutput_YDS.RowTemplate.Height = 24;
            this.dataGridViewOutput_YDS.Size = new System.Drawing.Size(378, 369);
            this.dataGridViewOutput_YDS.TabIndex = 1;
            // 
            // openFileDialogTask_YDS
            // 
            this.openFileDialogTask_YDS.FileName = "openFileDialog1";
            // 
            // toolTipButton_YDS
            // 
            this.toolTipButton_YDS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_YDS.ToolTipTitle = "Подсказка";
            // 
            // buttonSaveFile_YDS
            // 
            this.buttonSaveFile_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Properties.Resources.page_save;
            this.buttonSaveFile_YDS.Location = new System.Drawing.Point(192, 12);
            this.buttonSaveFile_YDS.Name = "buttonSaveFile_YDS";
            this.buttonSaveFile_YDS.Size = new System.Drawing.Size(84, 81);
            this.buttonSaveFile_YDS.TabIndex = 3;
            this.toolTipButton_YDS.SetToolTip(this.buttonSaveFile_YDS, "Сохранить файл\r\nНажмите, чтобы сохранить файл");
            this.buttonSaveFile_YDS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_YDS.Click += new System.EventHandler(this.buttonSaveFile_YDS_Click);
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Properties.Resources.help;
            this.buttonHelp_YDS.Location = new System.Drawing.Point(797, 12);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(84, 81);
            this.buttonHelp_YDS.TabIndex = 2;
            this.toolTipButton_YDS.SetToolTip(this.buttonHelp_YDS, "Сведение о программе");
            this.buttonHelp_YDS.UseVisualStyleBackColor = true;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // buttonDone_YDS
            // 
            this.buttonDone_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Properties.Resources.page_go;
            this.buttonDone_YDS.Location = new System.Drawing.Point(102, 12);
            this.buttonDone_YDS.Name = "buttonDone_YDS";
            this.buttonDone_YDS.Size = new System.Drawing.Size(84, 81);
            this.buttonDone_YDS.TabIndex = 1;
            this.toolTipButton_YDS.SetToolTip(this.buttonDone_YDS, "Изменяет в седьмом столбце элементы кратные 5 на 2");
            this.buttonDone_YDS.UseVisualStyleBackColor = true;
            this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
            // 
            // buttonOpenFile_YDS
            // 
            this.buttonOpenFile_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Properties.Resources.folder_page_white;
            this.buttonOpenFile_YDS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_YDS.Name = "buttonOpenFile_YDS";
            this.buttonOpenFile_YDS.Size = new System.Drawing.Size(84, 81);
            this.buttonOpenFile_YDS.TabIndex = 0;
            this.toolTipButton_YDS.SetToolTip(this.buttonOpenFile_YDS, "Открыть файл\r\nОткройте нужный файл для обработки");
            this.buttonOpenFile_YDS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_YDS.Click += new System.EventHandler(this.buttonOpenFile_YDS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 590);
            this.Controls.Add(this.panelLeft_YDS);
            this.Controls.Add(this.panelRight_YDS);
            this.Controls.Add(this.panelTop2_YDS);
            this.Controls.Add(this.panelTop_YDS);
            this.MinimumSize = new System.Drawing.Size(911, 565);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 25 | Янголенко Д. С.";
            this.Load += new System.EventHandler(this.File_Load_YDS);
            this.panelTop_YDS.ResumeLayout(false);
            this.panelTop2_YDS.ResumeLayout(false);
            this.panelRight_YDS.ResumeLayout(false);
            this.panelLeft_YDS.ResumeLayout(false);
            this.groupBoxTask_YDS.ResumeLayout(false);
            this.groupBoxTask_YDS.PerformLayout();
            this.groupBoxInput_YDS.ResumeLayout(false);
            this.groupBoxOutput_YDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_YDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_YDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_YDS;
        private System.Windows.Forms.Panel panelTop2_YDS;
        private System.Windows.Forms.Panel panelRight_YDS;
        private System.Windows.Forms.Panel panelLeft_YDS;
        private System.Windows.Forms.Button buttonSaveFile_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
        private System.Windows.Forms.Button buttonDone_YDS;
        private System.Windows.Forms.Button buttonOpenFile_YDS;
        private System.Windows.Forms.GroupBox groupBoxTask_YDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_YDS;
        private System.Windows.Forms.GroupBox groupBoxInput_YDS;
        private System.Windows.Forms.ToolTip toolTipButton_YDS;
        private System.Windows.Forms.Label labelTask_YDS;
        private System.Windows.Forms.DataGridView dataGridViewOutput_YDS;
        private System.Windows.Forms.DataGridView dataGridViewInput_YDS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_YDS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatix_YDS;
    }
}

