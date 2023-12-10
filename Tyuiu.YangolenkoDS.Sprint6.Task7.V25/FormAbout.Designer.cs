namespace Tyuiu.YangolenkoDS.Sprint6.Task7.V25
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_YDS = new System.Windows.Forms.PictureBox();
            this.labelInfo_YDS = new System.Windows.Forms.Label();
            this.buttonClose_YDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_YDS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_YDS
            // 
            this.pictureBoxAvatar_YDS.Image = global::Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Properties.Resources.avatar;
            this.pictureBoxAvatar_YDS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_YDS.Name = "pictureBoxAvatar_YDS";
            this.pictureBoxAvatar_YDS.Size = new System.Drawing.Size(193, 259);
            this.pictureBoxAvatar_YDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_YDS.TabIndex = 0;
            this.pictureBoxAvatar_YDS.TabStop = false;
            // 
            // labelInfo_YDS
            // 
            this.labelInfo_YDS.AutoSize = true;
            this.labelInfo_YDS.Location = new System.Drawing.Point(212, 63);
            this.labelInfo_YDS.Name = "labelInfo_YDS";
            this.labelInfo_YDS.Size = new System.Drawing.Size(366, 144);
            this.labelInfo_YDS.TabIndex = 1;
            this.labelInfo_YDS.Text = resources.GetString("labelInfo_YDS.Text");
            // 
            // buttonClose_YDS
            // 
            this.buttonClose_YDS.Location = new System.Drawing.Point(503, 249);
            this.buttonClose_YDS.Name = "buttonClose_YDS";
            this.buttonClose_YDS.Size = new System.Drawing.Size(75, 23);
            this.buttonClose_YDS.TabIndex = 2;
            this.buttonClose_YDS.Text = "OK";
            this.buttonClose_YDS.UseVisualStyleBackColor = true;
            this.buttonClose_YDS.Click += new System.EventHandler(this.buttonClose_YDS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 284);
            this.Controls.Add(this.buttonClose_YDS);
            this.Controls.Add(this.labelInfo_YDS);
            this.Controls.Add(this.pictureBoxAvatar_YDS);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_YDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_YDS;
        private System.Windows.Forms.Label labelInfo_YDS;
        private System.Windows.Forms.Button buttonClose_YDS;
    }
}