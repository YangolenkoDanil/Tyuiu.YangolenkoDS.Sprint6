namespace Tyuiu.YangolenkoDS.Sprint6.Task0.V1
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
            this.labelCondition_YDS = new System.Windows.Forms.Label();
            this.pictureBoxEquation_YDS = new System.Windows.Forms.PictureBox();
            this.groupBoxVarX_YDS = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_YDS = new System.Windows.Forms.TextBox();
            this.labelVarX_YDS = new System.Windows.Forms.Label();
            this.groupBoxResult_YDS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_YDS = new System.Windows.Forms.TextBox();
            this.labelResult_YDS = new System.Windows.Forms.Label();
            this.buttonDone_YDS = new System.Windows.Forms.Button();
            this.buttonHelp_YDS = new System.Windows.Forms.Button();
            this.groupBoxCondition_YDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_YDS)).BeginInit();
            this.groupBoxVarX_YDS.SuspendLayout();
            this.groupBoxResult_YDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_YDS
            // 
            this.groupBoxCondition_YDS.Controls.Add(this.labelCondition_YDS);
            this.groupBoxCondition_YDS.Controls.Add(this.pictureBoxEquation_YDS);
            this.groupBoxCondition_YDS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_YDS.Name = "groupBoxCondition_YDS";
            this.groupBoxCondition_YDS.Size = new System.Drawing.Size(775, 218);
            this.groupBoxCondition_YDS.TabIndex = 0;
            this.groupBoxCondition_YDS.TabStop = false;
            this.groupBoxCondition_YDS.Text = "Условие";
            // 
            // labelCondition_YDS
            // 
            this.labelCondition_YDS.AutoSize = true;
            this.labelCondition_YDS.Location = new System.Drawing.Point(7, 22);
            this.labelCondition_YDS.Name = "labelCondition_YDS";
            this.labelCondition_YDS.Size = new System.Drawing.Size(237, 16);
            this.labelCondition_YDS.TabIndex = 1;
            this.labelCondition_YDS.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxEquation_YDS
            // 
            this.pictureBoxEquation_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task0.V1.Properties.Resources.Task0V1;
            this.pictureBoxEquation_YDS.Location = new System.Drawing.Point(612, 22);
            this.pictureBoxEquation_YDS.Name = "pictureBoxEquation_YDS";
            this.pictureBoxEquation_YDS.Size = new System.Drawing.Size(157, 123);
            this.pictureBoxEquation_YDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEquation_YDS.TabIndex = 0;
            this.pictureBoxEquation_YDS.TabStop = false;
            this.pictureBoxEquation_YDS.Click += new System.EventHandler(this.pictureBoxEquation_YDS_Click);
            // 
            // groupBoxVarX_YDS
            // 
            this.groupBoxVarX_YDS.Controls.Add(this.textBoxVarX_YDS);
            this.groupBoxVarX_YDS.Controls.Add(this.labelVarX_YDS);
            this.groupBoxVarX_YDS.Location = new System.Drawing.Point(13, 238);
            this.groupBoxVarX_YDS.Name = "groupBoxVarX_YDS";
            this.groupBoxVarX_YDS.Size = new System.Drawing.Size(575, 151);
            this.groupBoxVarX_YDS.TabIndex = 1;
            this.groupBoxVarX_YDS.TabStop = false;
            this.groupBoxVarX_YDS.Text = "Ввод данных";
            // 
            // textBoxVarX_YDS
            // 
            this.textBoxVarX_YDS.Location = new System.Drawing.Point(13, 55);
            this.textBoxVarX_YDS.Name = "textBoxVarX_YDS";
            this.textBoxVarX_YDS.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_YDS.TabIndex = 1;
            this.textBoxVarX_YDS.TextChanged += new System.EventHandler(this.textBoxVarX_YDS_TextChanged);
            this.textBoxVarX_YDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_YDS_KeyPress);
            // 
            // labelVarX_YDS
            // 
            this.labelVarX_YDS.AutoSize = true;
            this.labelVarX_YDS.Location = new System.Drawing.Point(10, 36);
            this.labelVarX_YDS.Name = "labelVarX_YDS";
            this.labelVarX_YDS.Size = new System.Drawing.Size(103, 16);
            this.labelVarX_YDS.TabIndex = 0;
            this.labelVarX_YDS.Text = "Переменная X:";
            // 
            // groupBoxResult_YDS
            // 
            this.groupBoxResult_YDS.Controls.Add(this.textBoxResult_YDS);
            this.groupBoxResult_YDS.Controls.Add(this.labelResult_YDS);
            this.groupBoxResult_YDS.Location = new System.Drawing.Point(595, 238);
            this.groupBoxResult_YDS.Name = "groupBoxResult_YDS";
            this.groupBoxResult_YDS.Size = new System.Drawing.Size(200, 151);
            this.groupBoxResult_YDS.TabIndex = 2;
            this.groupBoxResult_YDS.TabStop = false;
            this.groupBoxResult_YDS.Text = "Вывод данных";
            // 
            // textBoxResult_YDS
            // 
            this.textBoxResult_YDS.Location = new System.Drawing.Point(10, 56);
            this.textBoxResult_YDS.Name = "textBoxResult_YDS";
            this.textBoxResult_YDS.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_YDS.TabIndex = 1;
            this.textBoxResult_YDS.TextChanged += new System.EventHandler(this.textBoxResult_YDS_TextChanged);
            // 
            // labelResult_YDS
            // 
            this.labelResult_YDS.AutoSize = true;
            this.labelResult_YDS.Location = new System.Drawing.Point(7, 36);
            this.labelResult_YDS.Name = "labelResult_YDS";
            this.labelResult_YDS.Size = new System.Drawing.Size(80, 16);
            this.labelResult_YDS.TabIndex = 0;
            this.labelResult_YDS.Text = "Результат:";
            // 
            // buttonDone_YDS
            // 
            this.buttonDone_YDS.Location = new System.Drawing.Point(666, 395);
            this.buttonDone_YDS.Name = "buttonDone_YDS";
            this.buttonDone_YDS.Size = new System.Drawing.Size(116, 43);
            this.buttonDone_YDS.TabIndex = 3;
            this.buttonDone_YDS.Text = "Выполнить";
            this.buttonDone_YDS.UseVisualStyleBackColor = true;
            this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
            // 
            // buttonHelp_YDS
            // 
            this.buttonHelp_YDS.Location = new System.Drawing.Point(605, 396);
            this.buttonHelp_YDS.Name = "buttonHelp_YDS";
            this.buttonHelp_YDS.Size = new System.Drawing.Size(51, 42);
            this.buttonHelp_YDS.TabIndex = 4;
            this.buttonHelp_YDS.Text = "?";
            this.buttonHelp_YDS.UseVisualStyleBackColor = true;
            this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_YDS);
            this.Controls.Add(this.buttonDone_YDS);
            this.Controls.Add(this.groupBoxResult_YDS);
            this.Controls.Add(this.groupBoxVarX_YDS);
            this.Controls.Add(this.groupBoxCondition_YDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 1 | Янголенко Д. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_YDS.ResumeLayout(false);
            this.groupBoxCondition_YDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_YDS)).EndInit();
            this.groupBoxVarX_YDS.ResumeLayout(false);
            this.groupBoxVarX_YDS.PerformLayout();
            this.groupBoxResult_YDS.ResumeLayout(false);
            this.groupBoxResult_YDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_YDS;
        private System.Windows.Forms.GroupBox groupBoxVarX_YDS;
        private System.Windows.Forms.GroupBox groupBoxResult_YDS;
        private System.Windows.Forms.Label labelCondition_YDS;
        private System.Windows.Forms.PictureBox pictureBoxEquation_YDS;
        private System.Windows.Forms.Label labelVarX_YDS;
        private System.Windows.Forms.TextBox textBoxVarX_YDS;
        private System.Windows.Forms.TextBox textBoxResult_YDS;
        private System.Windows.Forms.Label labelResult_YDS;
        private System.Windows.Forms.Button buttonDone_YDS;
        private System.Windows.Forms.Button buttonHelp_YDS;
    }
}

