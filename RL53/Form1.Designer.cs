namespace RL53
{
    partial class Form1
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
            this.generateButton = new System.Windows.Forms.Button();
            this.rl53SourceTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputPdfBrowse = new System.Windows.Forms.Button();
            this.csvExportBrowse = new System.Windows.Forms.Button();
            this.rl53SourceFileBrowse = new System.Windows.Forms.Button();
            this.outputPdfTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.csvExportTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(866, 273);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(122, 37);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // rl53SourceTextbox
            // 
            this.rl53SourceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rl53SourceTextbox.Location = new System.Drawing.Point(191, 20);
            this.rl53SourceTextbox.Name = "rl53SourceTextbox";
            this.rl53SourceTextbox.Size = new System.Drawing.Size(698, 26);
            this.rl53SourceTextbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.outputPdfBrowse);
            this.groupBox1.Controls.Add(this.csvExportBrowse);
            this.groupBox1.Controls.Add(this.rl53SourceFileBrowse);
            this.groupBox1.Controls.Add(this.outputPdfTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.csvExportTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rl53SourceTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // outputPdfBrowse
            // 
            this.outputPdfBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPdfBrowse.Location = new System.Drawing.Point(895, 133);
            this.outputPdfBrowse.Name = "outputPdfBrowse";
            this.outputPdfBrowse.Size = new System.Drawing.Size(75, 42);
            this.outputPdfBrowse.TabIndex = 9;
            this.outputPdfBrowse.Text = "Browse";
            this.outputPdfBrowse.UseVisualStyleBackColor = true;
            this.outputPdfBrowse.Click += new System.EventHandler(this.outputPdfBrowse_Click);
            // 
            // csvExportBrowse
            // 
            this.csvExportBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csvExportBrowse.Location = new System.Drawing.Point(895, 72);
            this.csvExportBrowse.Name = "csvExportBrowse";
            this.csvExportBrowse.Size = new System.Drawing.Size(75, 43);
            this.csvExportBrowse.TabIndex = 8;
            this.csvExportBrowse.Text = "Browse";
            this.csvExportBrowse.UseVisualStyleBackColor = true;
            this.csvExportBrowse.Click += new System.EventHandler(this.csvExportBrowse_Click);
            // 
            // rl53SourceFileBrowse
            // 
            this.rl53SourceFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rl53SourceFileBrowse.Location = new System.Drawing.Point(895, 13);
            this.rl53SourceFileBrowse.Name = "rl53SourceFileBrowse";
            this.rl53SourceFileBrowse.Size = new System.Drawing.Size(75, 41);
            this.rl53SourceFileBrowse.TabIndex = 7;
            this.rl53SourceFileBrowse.Text = "Browse";
            this.rl53SourceFileBrowse.UseVisualStyleBackColor = true;
            this.rl53SourceFileBrowse.Click += new System.EventHandler(this.rl53SourceFileBrowse_Click);
            // 
            // outputPdfTextbox
            // 
            this.outputPdfTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPdfTextbox.Location = new System.Drawing.Point(191, 144);
            this.outputPdfTextbox.Name = "outputPdfTextbox";
            this.outputPdfTextbox.Size = new System.Drawing.Size(698, 26);
            this.outputPdfTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output PDF";
            // 
            // csvExportTextbox
            // 
            this.csvExportTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csvExportTextbox.Location = new System.Drawing.Point(191, 83);
            this.csvExportTextbox.Name = "csvExportTextbox";
            this.csvExportTextbox.Size = new System.Drawing.Size(698, 26);
            this.csvExportTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Winestyr CSV Export";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "RL-53 Source PDF";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 221);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(970, 22);
            this.progressBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::RL53.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateButton);
            this.MinimumSize = new System.Drawing.Size(600, 370);
            this.Name = "Form1";
            this.Text = "Winestyr IL RL-53 Report Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox rl53SourceTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button outputPdfBrowse;
        private System.Windows.Forms.Button csvExportBrowse;
        private System.Windows.Forms.Button rl53SourceFileBrowse;
        private System.Windows.Forms.TextBox outputPdfTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox csvExportTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

