namespace GOC_Tabulation_System
{
    partial class frmServer
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
            this.dgvPreElim = new System.Windows.Forms.DataGridView();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSemiFinal = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrintSemi = new System.Windows.Forms.Button();
            this.btnSubmitSemi = new System.Windows.Forms.Button();
            this.dgvTOP10 = new System.Windows.Forms.DataGridView();
            this.btnPreviewTOP = new System.Windows.Forms.Button();
            this.btnSubmitTOP = new System.Windows.Forms.Button();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.frmLock = new System.Windows.Forms.ComboBox();
            this.lblJudges = new System.Windows.Forms.Label();
            this.lblCandidates = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreElim)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemiFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOP10)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreElim
            // 
            this.dgvPreElim.AllowUserToAddRows = false;
            this.dgvPreElim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreElim.Location = new System.Drawing.Point(605, 64);
            this.dgvPreElim.Name = "dgvPreElim";
            this.dgvPreElim.RowHeadersVisible = false;
            this.dgvPreElim.Size = new System.Drawing.Size(749, 464);
            this.dgvPreElim.TabIndex = 0;
            this.dgvPreElim.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreElim_CellEndEdit);
            this.dgvPreElim.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreElim_CellEnter);
            this.dgvPreElim.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPreElim_EditingControlShowing);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(602, 44);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(156, 15);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "[LONG GOWN COMPETITION]";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 38);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GOC_Tabulation_System.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1338, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabulation Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "DB Setting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSemiFinal
            // 
            this.dgvSemiFinal.AllowUserToAddRows = false;
            this.dgvSemiFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemiFinal.Location = new System.Drawing.Point(181, 64);
            this.dgvSemiFinal.Name = "dgvSemiFinal";
            this.dgvSemiFinal.RowHeadersVisible = false;
            this.dgvSemiFinal.Size = new System.Drawing.Size(418, 464);
            this.dgvSemiFinal.TabIndex = 9;
            this.dgvSemiFinal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSemiFinal_CellEndEdit);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(764, 39);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(924, 39);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrintSemi
            // 
            this.btnPrintSemi.Location = new System.Drawing.Point(260, 40);
            this.btnPrintSemi.Name = "btnPrintSemi";
            this.btnPrintSemi.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSemi.TabIndex = 13;
            this.btnPrintSemi.Text = "Preview";
            this.btnPrintSemi.UseVisualStyleBackColor = true;
            // 
            // btnSubmitSemi
            // 
            this.btnSubmitSemi.Location = new System.Drawing.Point(181, 40);
            this.btnSubmitSemi.Name = "btnSubmitSemi";
            this.btnSubmitSemi.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitSemi.TabIndex = 12;
            this.btnSubmitSemi.Text = "Submit";
            this.btnSubmitSemi.UseVisualStyleBackColor = true;
            this.btnSubmitSemi.Click += new System.EventHandler(this.btnSubmitSemi_Click);
            // 
            // dgvTOP10
            // 
            this.dgvTOP10.AllowUserToAddRows = false;
            this.dgvTOP10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTOP10.Location = new System.Drawing.Point(181, 534);
            this.dgvTOP10.Name = "dgvTOP10";
            this.dgvTOP10.RowHeadersVisible = false;
            this.dgvTOP10.Size = new System.Drawing.Size(1173, 191);
            this.dgvTOP10.TabIndex = 14;
            this.dgvTOP10.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvTOP10_SortCompare);
            // 
            // btnPreviewTOP
            // 
            this.btnPreviewTOP.Location = new System.Drawing.Point(260, 733);
            this.btnPreviewTOP.Name = "btnPreviewTOP";
            this.btnPreviewTOP.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewTOP.TabIndex = 16;
            this.btnPreviewTOP.Text = "Preview";
            this.btnPreviewTOP.UseVisualStyleBackColor = true;
            this.btnPreviewTOP.Click += new System.EventHandler(this.btnPreviewTOP_Click);
            // 
            // btnSubmitTOP
            // 
            this.btnSubmitTOP.Location = new System.Drawing.Point(181, 733);
            this.btnSubmitTOP.Name = "btnSubmitTOP";
            this.btnSubmitTOP.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTOP.TabIndex = 15;
            this.btnSubmitTOP.Text = "Submit";
            this.btnSubmitTOP.UseVisualStyleBackColor = true;
            this.btnSubmitTOP.Click += new System.EventHandler(this.btnSubmitTOP_Click);
            // 
            // cmbEvents
            // 
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Items.AddRange(new object[] {
            "Long Gown",
            "Semi Final - Q and A",
            "Final - Q and A"});
            this.cmbEvents.Location = new System.Drawing.Point(15, 113);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(156, 23);
            this.cmbEvents.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Major Event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Judge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Number of Candidates:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Form Lock:";
            // 
            // frmLock
            // 
            this.frmLock.FormattingEnabled = true;
            this.frmLock.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.frmLock.Location = new System.Drawing.Point(13, 216);
            this.frmLock.Name = "frmLock";
            this.frmLock.Size = new System.Drawing.Size(69, 23);
            this.frmLock.TabIndex = 23;
            // 
            // lblJudges
            // 
            this.lblJudges.AutoSize = true;
            this.lblJudges.Location = new System.Drawing.Point(140, 143);
            this.lblJudges.Name = "lblJudges";
            this.lblJudges.Size = new System.Drawing.Size(14, 15);
            this.lblJudges.TabIndex = 25;
            this.lblJudges.Text = "0";
            // 
            // lblCandidates
            // 
            this.lblCandidates.AutoSize = true;
            this.lblCandidates.Location = new System.Drawing.Point(140, 168);
            this.lblCandidates.Name = "lblCandidates";
            this.lblCandidates.Size = new System.Drawing.Size(14, 15);
            this.lblCandidates.TabIndex = 26;
            this.lblCandidates.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCandidates);
            this.Controls.Add(this.lblJudges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.frmLock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEvents);
            this.Controls.Add(this.btnPreviewTOP);
            this.Controls.Add(this.btnSubmitTOP);
            this.Controls.Add(this.dgvTOP10);
            this.Controls.Add(this.btnPrintSemi);
            this.Controls.Add(this.btnSubmitSemi);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvSemiFinal);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPreElim);
            this.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServer";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreElim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemiFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOP10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreElim;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSemiFinal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrintSemi;
        private System.Windows.Forms.Button btnSubmitSemi;
        private System.Windows.Forms.DataGridView dgvTOP10;
        private System.Windows.Forms.Button btnPreviewTOP;
        private System.Windows.Forms.Button btnSubmitTOP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox frmLock;
        private System.Windows.Forms.Label lblJudges;
        private System.Windows.Forms.Label lblCandidates;
        private System.Windows.Forms.Button button2;
    }
}