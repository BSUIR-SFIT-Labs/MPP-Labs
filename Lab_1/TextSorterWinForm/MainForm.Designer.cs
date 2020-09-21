namespace TextSorterWinForm
{
    partial class MainForm
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
            this.GbFileGeneration = new System.Windows.Forms.GroupBox();
            this.LblPathToFile = new System.Windows.Forms.Label();
            this.TbPathToFile = new System.Windows.Forms.TextBox();
            this.LblFileSize = new System.Windows.Forms.Label();
            this.NudFileSize = new System.Windows.Forms.NumericUpDown();
            this.BtnGenerateFile = new System.Windows.Forms.Button();
            this.LblFileGeenrationTime = new System.Windows.Forms.Label();
            this.GbFileSorter = new System.Windows.Forms.GroupBox();
            this.TbPathToSrcFile = new System.Windows.Forms.TextBox();
            this.LblPathToSrcFile = new System.Windows.Forms.Label();
            this.LblPathToSortedFile = new System.Windows.Forms.Label();
            this.TbPathToSortedFile = new System.Windows.Forms.TextBox();
            this.BtnSortFile = new System.Windows.Forms.Button();
            this.LblFileSortingTime = new System.Windows.Forms.Label();
            this.GbFileGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFileSize)).BeginInit();
            this.GbFileSorter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFileGeneration
            // 
            this.GbFileGeneration.Controls.Add(this.LblFileGeenrationTime);
            this.GbFileGeneration.Controls.Add(this.BtnGenerateFile);
            this.GbFileGeneration.Controls.Add(this.NudFileSize);
            this.GbFileGeneration.Controls.Add(this.LblFileSize);
            this.GbFileGeneration.Controls.Add(this.TbPathToFile);
            this.GbFileGeneration.Controls.Add(this.LblPathToFile);
            this.GbFileGeneration.Location = new System.Drawing.Point(12, 12);
            this.GbFileGeneration.Name = "GbFileGeneration";
            this.GbFileGeneration.Size = new System.Drawing.Size(295, 162);
            this.GbFileGeneration.TabIndex = 0;
            this.GbFileGeneration.TabStop = false;
            this.GbFileGeneration.Text = "File generation";
            // 
            // LblPathToFile
            // 
            this.LblPathToFile.AutoSize = true;
            this.LblPathToFile.Location = new System.Drawing.Point(6, 28);
            this.LblPathToFile.Name = "LblPathToFile";
            this.LblPathToFile.Size = new System.Drawing.Size(60, 13);
            this.LblPathToFile.TabIndex = 0;
            this.LblPathToFile.Text = "Path to file:";
            // 
            // TbPathToFile
            // 
            this.TbPathToFile.Location = new System.Drawing.Point(9, 44);
            this.TbPathToFile.Name = "TbPathToFile";
            this.TbPathToFile.Size = new System.Drawing.Size(276, 20);
            this.TbPathToFile.TabIndex = 1;
            // 
            // LblFileSize
            // 
            this.LblFileSize.AutoSize = true;
            this.LblFileSize.Location = new System.Drawing.Point(6, 72);
            this.LblFileSize.Name = "LblFileSize";
            this.LblFileSize.Size = new System.Drawing.Size(76, 13);
            this.LblFileSize.TabIndex = 2;
            this.LblFileSize.Text = "File size in GB:";
            // 
            // NudFileSize
            // 
            this.NudFileSize.Location = new System.Drawing.Point(88, 70);
            this.NudFileSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudFileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudFileSize.Name = "NudFileSize";
            this.NudFileSize.Size = new System.Drawing.Size(197, 20);
            this.NudFileSize.TabIndex = 3;
            this.NudFileSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnGenerateFile
            // 
            this.BtnGenerateFile.Location = new System.Drawing.Point(9, 96);
            this.BtnGenerateFile.Name = "BtnGenerateFile";
            this.BtnGenerateFile.Size = new System.Drawing.Size(276, 23);
            this.BtnGenerateFile.TabIndex = 4;
            this.BtnGenerateFile.Text = "Generate file";
            this.BtnGenerateFile.UseVisualStyleBackColor = true;
            this.BtnGenerateFile.Click += new System.EventHandler(this.BtnGenerateFile_Click);
            // 
            // LblFileGeenrationTime
            // 
            this.LblFileGeenrationTime.AutoSize = true;
            this.LblFileGeenrationTime.Location = new System.Drawing.Point(6, 131);
            this.LblFileGeenrationTime.Name = "LblFileGeenrationTime";
            this.LblFileGeenrationTime.Size = new System.Drawing.Size(101, 13);
            this.LblFileGeenrationTime.TabIndex = 5;
            this.LblFileGeenrationTime.Text = "File generation time:";
            // 
            // GbFileSorter
            // 
            this.GbFileSorter.Controls.Add(this.LblFileSortingTime);
            this.GbFileSorter.Controls.Add(this.BtnSortFile);
            this.GbFileSorter.Controls.Add(this.TbPathToSortedFile);
            this.GbFileSorter.Controls.Add(this.LblPathToSortedFile);
            this.GbFileSorter.Controls.Add(this.TbPathToSrcFile);
            this.GbFileSorter.Controls.Add(this.LblPathToSrcFile);
            this.GbFileSorter.Location = new System.Drawing.Point(12, 180);
            this.GbFileSorter.Name = "GbFileSorter";
            this.GbFileSorter.Size = new System.Drawing.Size(295, 169);
            this.GbFileSorter.TabIndex = 1;
            this.GbFileSorter.TabStop = false;
            this.GbFileSorter.Text = "File sorter";
            // 
            // TbPathToSrcFile
            // 
            this.TbPathToSrcFile.Location = new System.Drawing.Point(9, 42);
            this.TbPathToSrcFile.Name = "TbPathToSrcFile";
            this.TbPathToSrcFile.Size = new System.Drawing.Size(276, 20);
            this.TbPathToSrcFile.TabIndex = 3;
            // 
            // LblPathToSrcFile
            // 
            this.LblPathToSrcFile.AutoSize = true;
            this.LblPathToSrcFile.Location = new System.Drawing.Point(6, 26);
            this.LblPathToSrcFile.Name = "LblPathToSrcFile";
            this.LblPathToSrcFile.Size = new System.Drawing.Size(94, 13);
            this.LblPathToSrcFile.TabIndex = 2;
            this.LblPathToSrcFile.Text = "Path to sourse file:";
            // 
            // LblPathToSortedFile
            // 
            this.LblPathToSortedFile.AutoSize = true;
            this.LblPathToSortedFile.Location = new System.Drawing.Point(6, 65);
            this.LblPathToSortedFile.Name = "LblPathToSortedFile";
            this.LblPathToSortedFile.Size = new System.Drawing.Size(92, 13);
            this.LblPathToSortedFile.TabIndex = 4;
            this.LblPathToSortedFile.Text = "Path to sorted file:";
            // 
            // TbPathToSortedFile
            // 
            this.TbPathToSortedFile.Location = new System.Drawing.Point(9, 81);
            this.TbPathToSortedFile.Name = "TbPathToSortedFile";
            this.TbPathToSortedFile.Size = new System.Drawing.Size(276, 20);
            this.TbPathToSortedFile.TabIndex = 5;
            // 
            // BtnSortFile
            // 
            this.BtnSortFile.Location = new System.Drawing.Point(9, 107);
            this.BtnSortFile.Name = "BtnSortFile";
            this.BtnSortFile.Size = new System.Drawing.Size(276, 23);
            this.BtnSortFile.TabIndex = 5;
            this.BtnSortFile.Text = "Sort file";
            this.BtnSortFile.UseVisualStyleBackColor = true;
            this.BtnSortFile.Click += new System.EventHandler(this.BtnSortFile_Click);
            // 
            // LblFileSortingTime
            // 
            this.LblFileSortingTime.AutoSize = true;
            this.LblFileSortingTime.Location = new System.Drawing.Point(6, 142);
            this.LblFileSortingTime.Name = "LblFileSortingTime";
            this.LblFileSortingTime.Size = new System.Drawing.Size(82, 13);
            this.LblFileSortingTime.TabIndex = 6;
            this.LblFileSortingTime.Text = "File sorting time:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 356);
            this.Controls.Add(this.GbFileSorter);
            this.Controls.Add(this.GbFileGeneration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text sorter";
            this.GbFileGeneration.ResumeLayout(false);
            this.GbFileGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFileSize)).EndInit();
            this.GbFileSorter.ResumeLayout(false);
            this.GbFileSorter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbFileGeneration;
        private System.Windows.Forms.Label LblFileSize;
        private System.Windows.Forms.TextBox TbPathToFile;
        private System.Windows.Forms.Label LblPathToFile;
        private System.Windows.Forms.Label LblFileGeenrationTime;
        private System.Windows.Forms.Button BtnGenerateFile;
        private System.Windows.Forms.NumericUpDown NudFileSize;
        private System.Windows.Forms.GroupBox GbFileSorter;
        private System.Windows.Forms.Label LblFileSortingTime;
        private System.Windows.Forms.Button BtnSortFile;
        private System.Windows.Forms.TextBox TbPathToSortedFile;
        private System.Windows.Forms.Label LblPathToSortedFile;
        private System.Windows.Forms.TextBox TbPathToSrcFile;
        private System.Windows.Forms.Label LblPathToSrcFile;
    }
}

