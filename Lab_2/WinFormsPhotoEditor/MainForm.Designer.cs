namespace WinFormsPhotoEditor
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAsImage = new System.Windows.Forms.ToolStripMenuItem();
            this.GbOperations = new System.Windows.Forms.GroupBox();
            this.LblRotation = new System.Windows.Forms.Label();
            this.NudDegreeToRotate = new System.Windows.Forms.NumericUpDown();
            this.BtnRotateToSpecDegreesRight = new System.Windows.Forms.Button();
            this.BtnRotateTo90DegreesLeft = new System.Windows.Forms.Button();
            this.BtnRotateTo90DegreesRight = new System.Windows.Forms.Button();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.GbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDegreeToRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Menu;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(836, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenImage,
            this.MenuItemSaveImage,
            this.MenuItemSaveAsImage});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItemOpenImage
            // 
            this.MenuItemOpenImage.Name = "MenuItemOpenImage";
            this.MenuItemOpenImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpenImage.Size = new System.Drawing.Size(184, 22);
            this.MenuItemOpenImage.Text = "Open";
            this.MenuItemOpenImage.Click += new System.EventHandler(this.MenuItemOpenImage_Click);
            // 
            // MenuItemSaveImage
            // 
            this.MenuItemSaveImage.Name = "MenuItemSaveImage";
            this.MenuItemSaveImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSaveImage.Size = new System.Drawing.Size(184, 22);
            this.MenuItemSaveImage.Text = "Save";
            // 
            // MenuItemSaveAsImage
            // 
            this.MenuItemSaveAsImage.Name = "MenuItemSaveAsImage";
            this.MenuItemSaveAsImage.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemSaveAsImage.Size = new System.Drawing.Size(184, 22);
            this.MenuItemSaveAsImage.Text = "Save as";
            // 
            // GbOperations
            // 
            this.GbOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbOperations.Controls.Add(this.BtnRotateToSpecDegreesRight);
            this.GbOperations.Controls.Add(this.NudDegreeToRotate);
            this.GbOperations.Controls.Add(this.BtnRotateTo90DegreesLeft);
            this.GbOperations.Controls.Add(this.LblRotation);
            this.GbOperations.Controls.Add(this.BtnRotateTo90DegreesRight);
            this.GbOperations.Location = new System.Drawing.Point(599, 27);
            this.GbOperations.Name = "GbOperations";
            this.GbOperations.Size = new System.Drawing.Size(225, 427);
            this.GbOperations.TabIndex = 4;
            this.GbOperations.TabStop = false;
            this.GbOperations.Text = "Operations";
            // 
            // LblRotation
            // 
            this.LblRotation.AutoSize = true;
            this.LblRotation.Location = new System.Drawing.Point(6, 21);
            this.LblRotation.Name = "LblRotation";
            this.LblRotation.Size = new System.Drawing.Size(50, 13);
            this.LblRotation.TabIndex = 3;
            this.LblRotation.Text = "Rotation:";
            // 
            // NudDegreeToRotate
            // 
            this.NudDegreeToRotate.Location = new System.Drawing.Point(148, 43);
            this.NudDegreeToRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NudDegreeToRotate.Name = "NudDegreeToRotate";
            this.NudDegreeToRotate.Size = new System.Drawing.Size(71, 20);
            this.NudDegreeToRotate.TabIndex = 5;
            // 
            // BtnRotateToSpecDegreesRight
            // 
            this.BtnRotateToSpecDegreesRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRotateToSpecDegreesRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRotateToSpecDegreesRight.BackgroundImage = global::WinFormsPhotoEditor.Resources.RotateToDegreesRightImage;
            this.BtnRotateToSpecDegreesRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRotateToSpecDegreesRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateToSpecDegreesRight.FlatAppearance.BorderSize = 0;
            this.BtnRotateToSpecDegreesRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateToSpecDegreesRight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotateToSpecDegreesRight.Location = new System.Drawing.Point(112, 37);
            this.BtnRotateToSpecDegreesRight.Name = "BtnRotateToSpecDegreesRight";
            this.BtnRotateToSpecDegreesRight.Size = new System.Drawing.Size(30, 30);
            this.BtnRotateToSpecDegreesRight.TabIndex = 6;
            this.BtnRotateToSpecDegreesRight.UseVisualStyleBackColor = false;
            this.BtnRotateToSpecDegreesRight.Click += new System.EventHandler(this.BtnRotateToSpecDegreesRight_Click);
            // 
            // BtnRotateTo90DegreesLeft
            // 
            this.BtnRotateTo90DegreesLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRotateTo90DegreesLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnRotateTo90DegreesLeft.BackgroundImage = global::WinFormsPhotoEditor.Resources.RotateLeftImage;
            this.BtnRotateTo90DegreesLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRotateTo90DegreesLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateTo90DegreesLeft.FlatAppearance.BorderSize = 0;
            this.BtnRotateTo90DegreesLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateTo90DegreesLeft.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotateTo90DegreesLeft.Location = new System.Drawing.Point(45, 37);
            this.BtnRotateTo90DegreesLeft.Name = "BtnRotateTo90DegreesLeft";
            this.BtnRotateTo90DegreesLeft.Size = new System.Drawing.Size(30, 30);
            this.BtnRotateTo90DegreesLeft.TabIndex = 4;
            this.BtnRotateTo90DegreesLeft.Text = "90";
            this.BtnRotateTo90DegreesLeft.UseVisualStyleBackColor = false;
            this.BtnRotateTo90DegreesLeft.Click += new System.EventHandler(this.BtnRotateTo90DegreesLeft_Click);
            // 
            // BtnRotateTo90DegreesRight
            // 
            this.BtnRotateTo90DegreesRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRotateTo90DegreesRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRotateTo90DegreesRight.BackgroundImage = global::WinFormsPhotoEditor.Resources.RotateRightImage;
            this.BtnRotateTo90DegreesRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRotateTo90DegreesRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateTo90DegreesRight.FlatAppearance.BorderSize = 0;
            this.BtnRotateTo90DegreesRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateTo90DegreesRight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotateTo90DegreesRight.Location = new System.Drawing.Point(9, 37);
            this.BtnRotateTo90DegreesRight.Name = "BtnRotateTo90DegreesRight";
            this.BtnRotateTo90DegreesRight.Size = new System.Drawing.Size(30, 30);
            this.BtnRotateTo90DegreesRight.TabIndex = 2;
            this.BtnRotateTo90DegreesRight.Text = "90";
            this.BtnRotateTo90DegreesRight.UseVisualStyleBackColor = false;
            this.BtnRotateTo90DegreesRight.Click += new System.EventHandler(this.BtnRotateTo90DegreesRight_Click);
            // 
            // PbImage
            // 
            this.PbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImage.Location = new System.Drawing.Point(12, 27);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(581, 427);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 466);
            this.Controls.Add(this.GbOperations);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.Menu);
            this.MinimumSize = new System.Drawing.Size(852, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.GbOperations.ResumeLayout(false);
            this.GbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDegreeToRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BtnRotateTo90DegreesRight;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpenImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAsImage;
        private System.Windows.Forms.GroupBox GbOperations;
        private System.Windows.Forms.Label LblRotation;
        private System.Windows.Forms.Button BtnRotateTo90DegreesLeft;
        private System.Windows.Forms.Button BtnRotateToSpecDegreesRight;
        private System.Windows.Forms.NumericUpDown NudDegreeToRotate;
    }
}

