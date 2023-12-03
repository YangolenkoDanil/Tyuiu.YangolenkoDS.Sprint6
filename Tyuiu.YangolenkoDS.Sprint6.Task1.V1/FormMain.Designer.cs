namespace Tyuiu.YangolenkoDS.Sprint6.Task1.V1
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
            this.groupBoxCondition_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_YDS = new System.Windows.Forms.GroupBox();
            this.groupBoxVars_YDS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_YDS = new System.Windows.Forms.TextBox();
            this.labelStart_YDS = new System.Windows.Forms.Label();
            this.labelStop_YDS = new System.Windows.Forms.Label();
            this.textBoxStart_YDS = new System.Windows.Forms.TextBox();
            this.textBoxStop_YDS = new System.Windows.Forms.TextBox();
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.buttonDone_YDS = new System.Windows.Forms.Button();
            this.pictureBoxCondition_YDS = new System.Windows.Forms.PictureBox();
            this.labelResult_YDS = new System.Windows.Forms.Label();
            this.groupBoxCondition_YDS.SuspendLayout();
            this.groupBoxResult_YDS.SuspendLayout();
            this.groupBoxVars_YDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_YDS
            // 
            this.groupBoxCondition_YDS.Controls.Add(this.pictureBoxCondition_YDS);
            this.groupBoxCondition_YDS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_YDS.Name = "groupBoxCondition_YDS";
            this.groupBoxCondition_YDS.Size = new System.Drawing.Size(545, 275);
            this.groupBoxCondition_YDS.TabIndex = 0;
            this.groupBoxCondition_YDS.TabStop = false;
            this.groupBoxCondition_YDS.Text = "Условие";
            // 
            // groupBoxResult_YDS
            // 
            this.groupBoxResult_YDS.Controls.Add(this.labelResult_YDS);
            this.groupBoxResult_YDS.Controls.Add(this.textBoxResult_YDS);
            this.groupBoxResult_YDS.Location = new System.Drawing.Point(565, 13);
            this.groupBoxResult_YDS.Name = "groupBoxResult_YDS";
            this.groupBoxResult_YDS.Size = new System.Drawing.Size(223, 425);
            this.groupBoxResult_YDS.TabIndex = 1;
            this.groupBoxResult_YDS.TabStop = false;
            this.groupBoxResult_YDS.Text = "Вывод данных";
            // 
            // groupBoxVars_YDS
            // 
            this.groupBoxVars_YDS.Controls.Add(this.textBoxStop_YDS);
            this.groupBoxVars_YDS.Controls.Add(this.textBoxStart_YDS);
            this.groupBoxVars_YDS.Controls.Add(this.labelStop_YDS);
            this.groupBoxVars_YDS.Controls.Add(this.labelStart_YDS);
            this.groupBoxVars_YDS.Location = new System.Drawing.Point(12, 294);
            this.groupBoxVars_YDS.Name = "groupBoxVars_YDS";
            this.groupBoxVars_YDS.Size = new System.Drawing.Size(333, 144);
            this.groupBoxVars_YDS.TabIndex = 2;
            this.groupBoxVars_YDS.TabStop = false;
            this.groupBoxVars_YDS.Text = "Ввод данных";
            // 
            // textBoxResult_YDS
            // 
            this.textBoxResult_YDS.Location = new System.Drawing.Point(6, 44);
            this.textBoxResult_YDS.Multiline = true;
            this.textBoxResult_YDS.Name = "textBoxResult_YDS";
            this.textBoxResult_YDS.ReadOnly = true;
            this.textBoxResult_YDS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_YDS.Size = new System.Drawing.Size(211, 375);
            this.textBoxResult_YDS.TabIndex = 0;
            this.textBoxResult_YDS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelStart_YDS
            // 
            this.labelStart_YDS.AutoSize = true;
            this.labelStart_YDS.Location = new System.Drawing.Point(7, 49);
            this.labelStart_YDS.Name = "labelStart_YDS";
            this.labelStart_YDS.Size = new System.Drawing.Size(83, 16);
            this.labelStart_YDS.TabIndex = 0;
            this.labelStart_YDS.Text = "Старт шага:";
            // 
            // labelStop_YDS
            // 
            this.labelStop_YDS.AutoSize = true;
            this.labelStop_YDS.Location = new System.Drawing.Point(163, 49);
            this.labelStop_YDS.Name = "labelStop_YDS";
            this.labelStop_YDS.Size = new System.Drawing.Size(84, 16);
            this.labelStop_YDS.TabIndex = 1;
            this.labelStop_YDS.Text = "Конец шага:";
            // 
            // textBoxStart_YDS
            // 
            this.textBoxStart_YDS.Location = new System.Drawing.Point(7, 69);
            this.textBoxStart_YDS.Name = "textBoxStart_YDS";
            this.textBoxStart_YDS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_YDS.TabIndex = 2;
            // 
            // textBoxStop_YDS
            // 
            this.textBoxStop_YDS.Location = new System.Drawing.Point(166, 68);
            this.textBoxStop_YDS.Name = "textBoxStop_YDS";
            this.textBoxStop_YDS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_YDS.TabIndex = 3;
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_YDS.Location = new System.Drawing.Point(351, 330);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(84, 64);
            this.buttonHelp_YDS.TabIndex = 3;
            this.buttonHelp_YDS.Text = "Справка";
            this.buttonHelp_YDS.UseVisualStyleBackColor = false;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // buttonDone_YDS
            // 
            this.buttonDone_YDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_YDS.Location = new System.Drawing.Point(443, 330);
            this.buttonDone_YDS.Name = "buttonDone_YDS";
            this.buttonDone_YDS.Size = new System.Drawing.Size(116, 64);
            this.buttonDone_YDS.TabIndex = 4;
            this.buttonDone_YDS.Text = "Выполнить";
            this.buttonDone_YDS.UseVisualStyleBackColor = false;
            this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
            // 
            // pictureBoxCondition_YDS
            // 
            this.pictureBoxCondition_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task1.V1.Properties.Resources.Task1V1;
            this.pictureBoxCondition_YDS.Location = new System.Drawing.Point(9, 22);
            this.pictureBoxCondition_YDS.Name = "pictureBoxCondition_YDS";
            this.pictureBoxCondition_YDS.Size = new System.Drawing.Size(530, 235);
            this.pictureBoxCondition_YDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCondition_YDS.TabIndex = 0;
            this.pictureBoxCondition_YDS.TabStop = false;
            // 
            // labelResult_YDS
            // 
            this.labelResult_YDS.AutoSize = true;
            this.labelResult_YDS.Location = new System.Drawing.Point(6, 22);
            this.labelResult_YDS.Name = "labelResult_YDS";
            this.labelResult_YDS.Size = new System.Drawing.Size(80, 16);
            this.labelResult_YDS.TabIndex = 1;
            this.labelResult_YDS.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_YDS);
            this.Controls.Add(this.buttonHelp_YDS);
            this.Controls.Add(this.groupBoxVars_YDS);
            this.Controls.Add(this.groupBoxResult_YDS);
            this.Controls.Add(this.groupBoxCondition_YDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Янголенко Д. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_YDS.ResumeLayout(false);
            this.groupBoxResult_YDS.ResumeLayout(false);
            this.groupBoxResult_YDS.PerformLayout();
            this.groupBoxVars_YDS.ResumeLayout(false);
            this.groupBoxVars_YDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_YDS;
        private System.Windows.Forms.GroupBox groupBoxResult_YDS;
        private System.Windows.Forms.GroupBox groupBoxVars_YDS;
        private System.Windows.Forms.TextBox textBoxResult_YDS;
        private System.Windows.Forms.TextBox textBoxStop_YDS;
        private System.Windows.Forms.TextBox textBoxStart_YDS;
        private System.Windows.Forms.Label labelStop_YDS;
        private System.Windows.Forms.Label labelStart_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
        private System.Windows.Forms.Button buttonDone_YDS;
        private System.Windows.Forms.PictureBox pictureBoxCondition_YDS;
        private System.Windows.Forms.Label labelResult_YDS;
    }
}

