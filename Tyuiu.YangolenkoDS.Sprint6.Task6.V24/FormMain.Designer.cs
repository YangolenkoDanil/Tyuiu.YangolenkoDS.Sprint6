namespace Tyuiu.YangolenkoDS.Sprint6.Task6.V24
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
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.buttonDone_YDS = new System.Windows.Forms.Button();
            this.buttonOpenFile_YDS = new System.Windows.Forms.Button();
            this.panelTop2_YDS = new System.Windows.Forms.Panel();
            this.groupBoxTask_YDS = new System.Windows.Forms.GroupBox();
            this.labelTask_YDS = new System.Windows.Forms.Label();
            this.panelRight_YDS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_YDS = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_YDS = new System.Windows.Forms.TextBox();
            this.panelLeft_YDS = new System.Windows.Forms.Panel();
            this.groupBoxInput_YDS = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_YDS = new System.Windows.Forms.TextBox();
            this.toolTipTask_YDS = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_YDS = new System.Windows.Forms.OpenFileDialog();
            this.panelTop_YDS.SuspendLayout();
            this.panelTop2_YDS.SuspendLayout();
            this.groupBoxTask_YDS.SuspendLayout();
            this.panelRight_YDS.SuspendLayout();
            this.groupBoxOutPut_YDS.SuspendLayout();
            this.panelLeft_YDS.SuspendLayout();
            this.groupBoxInput_YDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_YDS
            // 
            this.panelTop_YDS.Controls.Add(this.buttonHelp_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonDone_YDS);
            this.panelTop_YDS.Controls.Add(this.buttonOpenFile_YDS);
            this.panelTop_YDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_YDS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_YDS.Name = "panelTop_YDS";
            this.panelTop_YDS.Size = new System.Drawing.Size(1026, 100);
            this.panelTop_YDS.TabIndex = 0;
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task6.V24.Properties.Resources.help;
            this.buttonHelp_YDS.Location = new System.Drawing.Point(927, 12);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(87, 81);
            this.buttonHelp_YDS.TabIndex = 2;
            this.toolTipTask_YDS.SetToolTip(this.buttonHelp_YDS, "Сведение о программе");
            this.buttonHelp_YDS.UseVisualStyleBackColor = true;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // buttonDone_YDS
            // 
            this.buttonDone_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task6.V24.Properties.Resources.page_go;
            this.buttonDone_YDS.Location = new System.Drawing.Point(105, 12);
            this.buttonDone_YDS.Name = "buttonDone_YDS";
            this.buttonDone_YDS.Size = new System.Drawing.Size(87, 81);
            this.buttonDone_YDS.TabIndex = 1;
            this.toolTipTask_YDS.SetToolTip(this.buttonDone_YDS, "Выводит первое слово каждой строки в результирующею строку");
            this.buttonDone_YDS.UseVisualStyleBackColor = true;
            this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
            // 
            // buttonOpenFile_YDS
            // 
            this.buttonOpenFile_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task6.V24.Properties.Resources.folder_page_white;
            this.buttonOpenFile_YDS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_YDS.Name = "buttonOpenFile_YDS";
            this.buttonOpenFile_YDS.Size = new System.Drawing.Size(87, 81);
            this.buttonOpenFile_YDS.TabIndex = 0;
            this.toolTipTask_YDS.SetToolTip(this.buttonOpenFile_YDS, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_YDS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_YDS.Click += new System.EventHandler(this.buttonOpenFile_YDS_Click);
            // 
            // panelTop2_YDS
            // 
            this.panelTop2_YDS.Controls.Add(this.groupBoxTask_YDS);
            this.panelTop2_YDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2_YDS.Location = new System.Drawing.Point(0, 100);
            this.panelTop2_YDS.Name = "panelTop2_YDS";
            this.panelTop2_YDS.Size = new System.Drawing.Size(1026, 100);
            this.panelTop2_YDS.TabIndex = 1;
            // 
            // groupBoxTask_YDS
            // 
            this.groupBoxTask_YDS.Controls.Add(this.labelTask_YDS);
            this.groupBoxTask_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_YDS.Name = "groupBoxTask_YDS";
            this.groupBoxTask_YDS.Size = new System.Drawing.Size(1026, 100);
            this.groupBoxTask_YDS.TabIndex = 0;
            this.groupBoxTask_YDS.TabStop = false;
            this.groupBoxTask_YDS.Text = "Условие:";
            // 
            // labelTask_YDS
            // 
            this.labelTask_YDS.AutoSize = true;
            this.labelTask_YDS.Location = new System.Drawing.Point(12, 22);
            this.labelTask_YDS.Name = "labelTask_YDS";
            this.labelTask_YDS.Size = new System.Drawing.Size(856, 32);
            this.labelTask_YDS.TabIndex = 0;
            this.labelTask_YDS.Text = resources.GetString("labelTask_YDS.Text");
            // 
            // panelRight_YDS
            // 
            this.panelRight_YDS.Controls.Add(this.groupBoxOutPut_YDS);
            this.panelRight_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_YDS.Location = new System.Drawing.Point(366, 200);
            this.panelRight_YDS.Name = "panelRight_YDS";
            this.panelRight_YDS.Size = new System.Drawing.Size(660, 351);
            this.panelRight_YDS.TabIndex = 2;
            // 
            // groupBoxOutPut_YDS
            // 
            this.groupBoxOutPut_YDS.Controls.Add(this.textBoxOutPut_YDS);
            this.groupBoxOutPut_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_YDS.Name = "groupBoxOutPut_YDS";
            this.groupBoxOutPut_YDS.Size = new System.Drawing.Size(660, 351);
            this.groupBoxOutPut_YDS.TabIndex = 1;
            this.groupBoxOutPut_YDS.TabStop = false;
            this.groupBoxOutPut_YDS.Text = "Вывод:";
            // 
            // textBoxOutPut_YDS
            // 
            this.textBoxOutPut_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_YDS.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutPut_YDS.Multiline = true;
            this.textBoxOutPut_YDS.Name = "textBoxOutPut_YDS";
            this.textBoxOutPut_YDS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_YDS.Size = new System.Drawing.Size(654, 330);
            this.textBoxOutPut_YDS.TabIndex = 1;
            // 
            // panelLeft_YDS
            // 
            this.panelLeft_YDS.Controls.Add(this.groupBoxInput_YDS);
            this.panelLeft_YDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_YDS.Location = new System.Drawing.Point(0, 200);
            this.panelLeft_YDS.Name = "panelLeft_YDS";
            this.panelLeft_YDS.Size = new System.Drawing.Size(366, 351);
            this.panelLeft_YDS.TabIndex = 3;
            // 
            // groupBoxInput_YDS
            // 
            this.groupBoxInput_YDS.Controls.Add(this.textBoxInPut_YDS);
            this.groupBoxInput_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_YDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_YDS.Name = "groupBoxInput_YDS";
            this.groupBoxInput_YDS.Size = new System.Drawing.Size(366, 351);
            this.groupBoxInput_YDS.TabIndex = 1;
            this.groupBoxInput_YDS.TabStop = false;
            this.groupBoxInput_YDS.Text = "Ввод:";
            // 
            // textBoxInPut_YDS
            // 
            this.textBoxInPut_YDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_YDS.Location = new System.Drawing.Point(3, 18);
            this.textBoxInPut_YDS.Multiline = true;
            this.textBoxInPut_YDS.Name = "textBoxInPut_YDS";
            this.textBoxInPut_YDS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_YDS.Size = new System.Drawing.Size(360, 330);
            this.textBoxInPut_YDS.TabIndex = 0;
            // 
            // toolTipTask_YDS
            // 
            this.toolTipTask_YDS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_YDS.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_YDS
            // 
            this.openFileDialogTask_YDS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 551);
            this.Controls.Add(this.panelRight_YDS);
            this.Controls.Add(this.panelLeft_YDS);
            this.Controls.Add(this.panelTop2_YDS);
            this.Controls.Add(this.panelTop_YDS);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Янголенко Д. С.";
            this.panelTop_YDS.ResumeLayout(false);
            this.panelTop2_YDS.ResumeLayout(false);
            this.groupBoxTask_YDS.ResumeLayout(false);
            this.groupBoxTask_YDS.PerformLayout();
            this.panelRight_YDS.ResumeLayout(false);
            this.groupBoxOutPut_YDS.ResumeLayout(false);
            this.groupBoxOutPut_YDS.PerformLayout();
            this.panelLeft_YDS.ResumeLayout(false);
            this.groupBoxInput_YDS.ResumeLayout(false);
            this.groupBoxInput_YDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_YDS;
        private System.Windows.Forms.Panel panelTop2_YDS;
        private System.Windows.Forms.Panel panelRight_YDS;
        private System.Windows.Forms.Panel panelLeft_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
        private System.Windows.Forms.Button buttonDone_YDS;
        private System.Windows.Forms.Button buttonOpenFile_YDS;
        private System.Windows.Forms.ToolTip toolTipTask_YDS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_YDS;
        private System.Windows.Forms.GroupBox groupBoxTask_YDS;
        private System.Windows.Forms.Label labelTask_YDS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_YDS;
        private System.Windows.Forms.TextBox textBoxOutPut_YDS;
        private System.Windows.Forms.GroupBox groupBoxInput_YDS;
        private System.Windows.Forms.TextBox textBoxInPut_YDS;
    }
}

