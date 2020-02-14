namespace GOC_Tabulation_System
{
    partial class frmAddPicturecs
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFromDB = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lrntxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFromDB
            // 
            this.txtFromDB.Location = new System.Drawing.Point(605, 78);
            this.txtFromDB.Name = "txtFromDB";
            this.txtFromDB.Size = new System.Drawing.Size(144, 20);
            this.txtFromDB.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(605, 149);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(144, 20);
            this.txtPath.TabIndex = 3;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(605, 197);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(144, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // lrntxt
            // 
            this.lrntxt.Location = new System.Drawing.Point(605, 255);
            this.lrntxt.Name = "lrntxt";
            this.lrntxt.Size = new System.Drawing.Size(144, 20);
            this.lrntxt.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(605, 334);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(144, 20);
            this.txtImage.TabIndex = 6;
            // 
            // frmAddPicturecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 634);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lrntxt);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtFromDB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAddPicturecs";
            this.Text = "frmAddPicturecs";
            this.Load += new System.EventHandler(this.frmAddPicturecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFromDB;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox lrntxt;
        private System.Windows.Forms.TextBox txtImage;
    }
}