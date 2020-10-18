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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAsImage = new System.Windows.Forms.ToolStripMenuItem();
            this.GbOperations = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnHorizontalFlip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFlip = new System.Windows.Forms.Label();
            this.BtnSaveFilters = new System.Windows.Forms.Button();
            this.BtnSepiaFilter = new System.Windows.Forms.Button();
            this.BtnPolaroidFilter = new System.Windows.Forms.Button();
            this.BtnInvertFilter = new System.Windows.Forms.Button();
            this.BtnGothamFilter = new System.Windows.Forms.Button();
            this.BtnComicFilter = new System.Windows.Forms.Button();
            this.BtnBlackWhiteFilter = new System.Windows.Forms.Button();
            this.LblImageFilters = new System.Windows.Forms.Label();
            this.BtnSaveContrast = new System.Windows.Forms.Button();
            this.TbContrast = new System.Windows.Forms.TrackBar();
            this.LblContrast = new System.Windows.Forms.Label();
            this.BtnSaveBrightness = new System.Windows.Forms.Button();
            this.TbBrightness = new System.Windows.Forms.TrackBar();
            this.LblBrightness = new System.Windows.Forms.Label();
            this.BtnSaveRotation = new System.Windows.Forms.Button();
            this.BtnSaveHue = new System.Windows.Forms.Button();
            this.TbHue = new System.Windows.Forms.TrackBar();
            this.LblHue = new System.Windows.Forms.Label();
            this.BtnRotateToSpecDegreesRight = new System.Windows.Forms.Button();
            this.NudDegreeToRotate = new System.Windows.Forms.NumericUpDown();
            this.BtnRotateTo90DegreesLeft = new System.Windows.Forms.Button();
            this.LblRotation = new System.Windows.Forms.Label();
            this.BtnRotateTo90DegreesRight = new System.Windows.Forms.Button();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.BtnVerticalFlip = new System.Windows.Forms.Button();
            this.LblSaturation = new System.Windows.Forms.Label();
            this.TbSaturation = new System.Windows.Forms.TrackBar();
            this.btnSaveSaturation = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Menu.SuspendLayout();
            this.GbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDegreeToRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbSaturation)).BeginInit();
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
            this.Menu.Size = new System.Drawing.Size(1184, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenImage,
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
            // MenuItemSaveAsImage
            // 
            this.MenuItemSaveAsImage.Name = "MenuItemSaveAsImage";
            this.MenuItemSaveAsImage.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemSaveAsImage.Size = new System.Drawing.Size(184, 22);
            this.MenuItemSaveAsImage.Text = "Save as";
            this.MenuItemSaveAsImage.Click += new System.EventHandler(this.MenuItemSaveAsImage_Click);
            // 
            // GbOperations
            // 
            this.GbOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbOperations.Controls.Add(this.btnSaveSaturation);
            this.GbOperations.Controls.Add(this.TbSaturation);
            this.GbOperations.Controls.Add(this.LblSaturation);
            this.GbOperations.Controls.Add(this.BtnVerticalFlip);
            this.GbOperations.Controls.Add(this.BtnReset);
            this.GbOperations.Controls.Add(this.BtnHorizontalFlip);
            this.GbOperations.Controls.Add(this.panel1);
            this.GbOperations.Controls.Add(this.LblFlip);
            this.GbOperations.Controls.Add(this.BtnSaveFilters);
            this.GbOperations.Controls.Add(this.BtnSepiaFilter);
            this.GbOperations.Controls.Add(this.BtnPolaroidFilter);
            this.GbOperations.Controls.Add(this.BtnInvertFilter);
            this.GbOperations.Controls.Add(this.BtnGothamFilter);
            this.GbOperations.Controls.Add(this.BtnComicFilter);
            this.GbOperations.Controls.Add(this.BtnBlackWhiteFilter);
            this.GbOperations.Controls.Add(this.LblImageFilters);
            this.GbOperations.Controls.Add(this.BtnSaveContrast);
            this.GbOperations.Controls.Add(this.TbContrast);
            this.GbOperations.Controls.Add(this.LblContrast);
            this.GbOperations.Controls.Add(this.BtnSaveBrightness);
            this.GbOperations.Controls.Add(this.TbBrightness);
            this.GbOperations.Controls.Add(this.LblBrightness);
            this.GbOperations.Controls.Add(this.BtnSaveRotation);
            this.GbOperations.Controls.Add(this.BtnSaveHue);
            this.GbOperations.Controls.Add(this.TbHue);
            this.GbOperations.Controls.Add(this.LblHue);
            this.GbOperations.Controls.Add(this.BtnRotateToSpecDegreesRight);
            this.GbOperations.Controls.Add(this.NudDegreeToRotate);
            this.GbOperations.Controls.Add(this.BtnRotateTo90DegreesLeft);
            this.GbOperations.Controls.Add(this.LblRotation);
            this.GbOperations.Controls.Add(this.BtnRotateTo90DegreesRight);
            this.GbOperations.Location = new System.Drawing.Point(918, 27);
            this.GbOperations.Name = "GbOperations";
            this.GbOperations.Size = new System.Drawing.Size(254, 722);
            this.GbOperations.TabIndex = 4;
            this.GbOperations.TabStop = false;
            this.GbOperations.Text = "Operations";
            // 
            // BtnReset
            // 
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Enabled = false;
            this.BtnReset.Location = new System.Drawing.Point(9, 693);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(237, 23);
            this.BtnReset.TabIndex = 29;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnHorizontalFlip
            // 
            this.BtnHorizontalFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHorizontalFlip.BackColor = System.Drawing.Color.Transparent;
            this.BtnHorizontalFlip.BackgroundImage = global::WinFormsPhotoEditor.Resources.HorizontalFlip;
            this.BtnHorizontalFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnHorizontalFlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHorizontalFlip.Enabled = false;
            this.BtnHorizontalFlip.FlatAppearance.BorderSize = 0;
            this.BtnHorizontalFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHorizontalFlip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHorizontalFlip.Location = new System.Drawing.Point(9, 124);
            this.BtnHorizontalFlip.Name = "BtnHorizontalFlip";
            this.BtnHorizontalFlip.Size = new System.Drawing.Size(30, 30);
            this.BtnHorizontalFlip.TabIndex = 28;
            this.BtnHorizontalFlip.UseVisualStyleBackColor = false;
            this.BtnHorizontalFlip.Click += new System.EventHandler(this.BtnHorizontalFlip_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WinFormsPhotoEditor.Resources.Gradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(22, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 25);
            this.panel1.TabIndex = 27;
            // 
            // LblFlip
            // 
            this.LblFlip.AutoSize = true;
            this.LblFlip.Location = new System.Drawing.Point(6, 108);
            this.LblFlip.Name = "LblFlip";
            this.LblFlip.Size = new System.Drawing.Size(26, 13);
            this.LblFlip.TabIndex = 25;
            this.LblFlip.Text = "Flip:";
            // 
            // BtnSaveFilters
            // 
            this.BtnSaveFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveFilters.Enabled = false;
            this.BtnSaveFilters.Location = new System.Drawing.Point(9, 644);
            this.BtnSaveFilters.Name = "BtnSaveFilters";
            this.BtnSaveFilters.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveFilters.TabIndex = 24;
            this.BtnSaveFilters.Text = "Apply filters";
            this.BtnSaveFilters.UseVisualStyleBackColor = true;
            this.BtnSaveFilters.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // BtnSepiaFilter
            // 
            this.BtnSepiaFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.Sepia;
            this.BtnSepiaFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSepiaFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSepiaFilter.Enabled = false;
            this.BtnSepiaFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSepiaFilter.Location = new System.Drawing.Point(171, 588);
            this.BtnSepiaFilter.Name = "BtnSepiaFilter";
            this.BtnSepiaFilter.Size = new System.Drawing.Size(75, 50);
            this.BtnSepiaFilter.TabIndex = 23;
            this.BtnSepiaFilter.Tag = "6";
            this.BtnSepiaFilter.UseVisualStyleBackColor = true;
            this.BtnSepiaFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // BtnPolaroidFilter
            // 
            this.BtnPolaroidFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.Polaroid;
            this.BtnPolaroidFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPolaroidFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPolaroidFilter.Enabled = false;
            this.BtnPolaroidFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPolaroidFilter.Location = new System.Drawing.Point(90, 588);
            this.BtnPolaroidFilter.Name = "BtnPolaroidFilter";
            this.BtnPolaroidFilter.Size = new System.Drawing.Size(75, 50);
            this.BtnPolaroidFilter.TabIndex = 22;
            this.BtnPolaroidFilter.Tag = "5";
            this.BtnPolaroidFilter.UseVisualStyleBackColor = true;
            this.BtnPolaroidFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // BtnInvertFilter
            // 
            this.BtnInvertFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.Invert;
            this.BtnInvertFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInvertFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInvertFilter.Enabled = false;
            this.BtnInvertFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInvertFilter.Location = new System.Drawing.Point(9, 588);
            this.BtnInvertFilter.Name = "BtnInvertFilter";
            this.BtnInvertFilter.Size = new System.Drawing.Size(75, 50);
            this.BtnInvertFilter.TabIndex = 21;
            this.BtnInvertFilter.Tag = "4";
            this.BtnInvertFilter.UseVisualStyleBackColor = true;
            this.BtnInvertFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // BtnGothamFilter
            // 
            this.BtnGothamFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.Gotham;
            this.BtnGothamFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGothamFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGothamFilter.Enabled = false;
            this.BtnGothamFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGothamFilter.Location = new System.Drawing.Point(171, 532);
            this.BtnGothamFilter.Name = "BtnGothamFilter";
            this.BtnGothamFilter.Size = new System.Drawing.Size(75, 50);
            this.BtnGothamFilter.TabIndex = 20;
            this.BtnGothamFilter.Tag = "3";
            this.BtnGothamFilter.UseVisualStyleBackColor = true;
            this.BtnGothamFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // BtnComicFilter
            // 
            this.BtnComicFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.Comic;
            this.BtnComicFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnComicFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComicFilter.Enabled = false;
            this.BtnComicFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComicFilter.Location = new System.Drawing.Point(90, 532);
            this.BtnComicFilter.Name = "BtnComicFilter";
            this.BtnComicFilter.Size = new System.Drawing.Size(75, 50);
            this.BtnComicFilter.TabIndex = 19;
            this.BtnComicFilter.Tag = "2";
            this.BtnComicFilter.UseVisualStyleBackColor = true;
            this.BtnComicFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // BtnBlackWhiteFilter
            // 
            this.BtnBlackWhiteFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.BlackWhiteFilter;
            this.BtnBlackWhiteFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackWhiteFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBlackWhiteFilter.Enabled = false;
            this.BtnBlackWhiteFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlackWhiteFilter.Location = new System.Drawing.Point(9, 532);
            this.BtnBlackWhiteFilter.Name = "BtnBlackWhiteFilter";
            this.BtnBlackWhiteFilter.Size = new System.Drawing.Size(75, 50);
            this.BtnBlackWhiteFilter.TabIndex = 18;
            this.BtnBlackWhiteFilter.Tag = "1";
            this.BtnBlackWhiteFilter.UseVisualStyleBackColor = true;
            this.BtnBlackWhiteFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // LblImageFilters
            // 
            this.LblImageFilters.AutoSize = true;
            this.LblImageFilters.Location = new System.Drawing.Point(6, 516);
            this.LblImageFilters.Name = "LblImageFilters";
            this.LblImageFilters.Size = new System.Drawing.Size(37, 13);
            this.LblImageFilters.TabIndex = 17;
            this.LblImageFilters.Text = "Filters:";
            // 
            // BtnSaveContrast
            // 
            this.BtnSaveContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveContrast.Enabled = false;
            this.BtnSaveContrast.Location = new System.Drawing.Point(9, 403);
            this.BtnSaveContrast.Name = "BtnSaveContrast";
            this.BtnSaveContrast.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveContrast.TabIndex = 16;
            this.BtnSaveContrast.Text = "Apply contrast changes";
            this.BtnSaveContrast.UseVisualStyleBackColor = true;
            this.BtnSaveContrast.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // TbContrast
            // 
            this.TbContrast.Enabled = false;
            this.TbContrast.Location = new System.Drawing.Point(9, 370);
            this.TbContrast.Maximum = 100;
            this.TbContrast.Minimum = -100;
            this.TbContrast.Name = "TbContrast";
            this.TbContrast.Size = new System.Drawing.Size(239, 45);
            this.TbContrast.TabIndex = 15;
            this.TbContrast.Scroll += new System.EventHandler(this.TbContrast_Scroll);
            // 
            // LblContrast
            // 
            this.LblContrast.AutoSize = true;
            this.LblContrast.Location = new System.Drawing.Point(6, 354);
            this.LblContrast.Name = "LblContrast";
            this.LblContrast.Size = new System.Drawing.Size(49, 13);
            this.LblContrast.TabIndex = 14;
            this.LblContrast.Text = "Contrast:";
            // 
            // BtnSaveBrightness
            // 
            this.BtnSaveBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveBrightness.Enabled = false;
            this.BtnSaveBrightness.Location = new System.Drawing.Point(9, 323);
            this.BtnSaveBrightness.Name = "BtnSaveBrightness";
            this.BtnSaveBrightness.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveBrightness.TabIndex = 13;
            this.BtnSaveBrightness.Text = "Apply brightness changes";
            this.BtnSaveBrightness.UseVisualStyleBackColor = true;
            this.BtnSaveBrightness.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // TbBrightness
            // 
            this.TbBrightness.Enabled = false;
            this.TbBrightness.Location = new System.Drawing.Point(9, 290);
            this.TbBrightness.Maximum = 100;
            this.TbBrightness.Minimum = -100;
            this.TbBrightness.Name = "TbBrightness";
            this.TbBrightness.Size = new System.Drawing.Size(239, 45);
            this.TbBrightness.TabIndex = 12;
            this.TbBrightness.Scroll += new System.EventHandler(this.TbBrightness_Scroll);
            // 
            // LblBrightness
            // 
            this.LblBrightness.AutoSize = true;
            this.LblBrightness.Location = new System.Drawing.Point(6, 274);
            this.LblBrightness.Name = "LblBrightness";
            this.LblBrightness.Size = new System.Drawing.Size(59, 13);
            this.LblBrightness.TabIndex = 11;
            this.LblBrightness.Text = "Brightness:";
            // 
            // BtnSaveRotation
            // 
            this.BtnSaveRotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveRotation.Enabled = false;
            this.BtnSaveRotation.Location = new System.Drawing.Point(122, 40);
            this.BtnSaveRotation.Name = "BtnSaveRotation";
            this.BtnSaveRotation.Size = new System.Drawing.Size(126, 23);
            this.BtnSaveRotation.TabIndex = 10;
            this.BtnSaveRotation.Text = "Apply rotation changes";
            this.BtnSaveRotation.UseVisualStyleBackColor = true;
            this.BtnSaveRotation.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // BtnSaveHue
            // 
            this.BtnSaveHue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveHue.Enabled = false;
            this.BtnSaveHue.Location = new System.Drawing.Point(9, 243);
            this.BtnSaveHue.Name = "BtnSaveHue";
            this.BtnSaveHue.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveHue.TabIndex = 9;
            this.BtnSaveHue.Text = "Apply hue changes";
            this.BtnSaveHue.UseVisualStyleBackColor = true;
            this.BtnSaveHue.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // TbHue
            // 
            this.TbHue.Enabled = false;
            this.TbHue.Location = new System.Drawing.Point(9, 177);
            this.TbHue.Maximum = 360;
            this.TbHue.Name = "TbHue";
            this.TbHue.Size = new System.Drawing.Size(239, 45);
            this.TbHue.TabIndex = 8;
            this.TbHue.Scroll += new System.EventHandler(this.TbHue_Scroll);
            // 
            // LblHue
            // 
            this.LblHue.AutoSize = true;
            this.LblHue.Location = new System.Drawing.Point(6, 161);
            this.LblHue.Name = "LblHue";
            this.LblHue.Size = new System.Drawing.Size(30, 13);
            this.LblHue.TabIndex = 7;
            this.LblHue.Text = "Hue:";
            // 
            // BtnRotateToSpecDegreesRight
            // 
            this.BtnRotateToSpecDegreesRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRotateToSpecDegreesRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRotateToSpecDegreesRight.BackgroundImage = global::WinFormsPhotoEditor.Resources.RotateToDegreesRightImage;
            this.BtnRotateToSpecDegreesRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRotateToSpecDegreesRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateToSpecDegreesRight.Enabled = false;
            this.BtnRotateToSpecDegreesRight.FlatAppearance.BorderSize = 0;
            this.BtnRotateToSpecDegreesRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateToSpecDegreesRight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotateToSpecDegreesRight.Location = new System.Drawing.Point(9, 37);
            this.BtnRotateToSpecDegreesRight.Name = "BtnRotateToSpecDegreesRight";
            this.BtnRotateToSpecDegreesRight.Size = new System.Drawing.Size(30, 30);
            this.BtnRotateToSpecDegreesRight.TabIndex = 6;
            this.BtnRotateToSpecDegreesRight.UseVisualStyleBackColor = false;
            this.BtnRotateToSpecDegreesRight.Click += new System.EventHandler(this.BtnRotateToSpecDegreesRight_Click);
            // 
            // NudDegreeToRotate
            // 
            this.NudDegreeToRotate.Enabled = false;
            this.NudDegreeToRotate.Location = new System.Drawing.Point(45, 43);
            this.NudDegreeToRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NudDegreeToRotate.Name = "NudDegreeToRotate";
            this.NudDegreeToRotate.Size = new System.Drawing.Size(71, 20);
            this.NudDegreeToRotate.TabIndex = 5;
            // 
            // BtnRotateTo90DegreesLeft
            // 
            this.BtnRotateTo90DegreesLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRotateTo90DegreesLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnRotateTo90DegreesLeft.BackgroundImage = global::WinFormsPhotoEditor.Resources.RotateLeftImage;
            this.BtnRotateTo90DegreesLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRotateTo90DegreesLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateTo90DegreesLeft.Enabled = false;
            this.BtnRotateTo90DegreesLeft.FlatAppearance.BorderSize = 0;
            this.BtnRotateTo90DegreesLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateTo90DegreesLeft.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotateTo90DegreesLeft.Location = new System.Drawing.Point(45, 73);
            this.BtnRotateTo90DegreesLeft.Name = "BtnRotateTo90DegreesLeft";
            this.BtnRotateTo90DegreesLeft.Size = new System.Drawing.Size(30, 30);
            this.BtnRotateTo90DegreesLeft.TabIndex = 4;
            this.BtnRotateTo90DegreesLeft.Text = "90";
            this.BtnRotateTo90DegreesLeft.UseVisualStyleBackColor = false;
            this.BtnRotateTo90DegreesLeft.Click += new System.EventHandler(this.BtnRotateTo90DegreesLeft_Click);
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
            // BtnRotateTo90DegreesRight
            // 
            this.BtnRotateTo90DegreesRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRotateTo90DegreesRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRotateTo90DegreesRight.BackgroundImage = global::WinFormsPhotoEditor.Resources.RotateRightImage;
            this.BtnRotateTo90DegreesRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRotateTo90DegreesRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRotateTo90DegreesRight.Enabled = false;
            this.BtnRotateTo90DegreesRight.FlatAppearance.BorderSize = 0;
            this.BtnRotateTo90DegreesRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotateTo90DegreesRight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotateTo90DegreesRight.Location = new System.Drawing.Point(9, 73);
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
            this.PbImage.Size = new System.Drawing.Size(900, 722);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // BtnVerticalFlip
            // 
            this.BtnVerticalFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerticalFlip.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerticalFlip.BackgroundImage = global::WinFormsPhotoEditor.Resources.VerticalFlip;
            this.BtnVerticalFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVerticalFlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerticalFlip.Enabled = false;
            this.BtnVerticalFlip.FlatAppearance.BorderSize = 0;
            this.BtnVerticalFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerticalFlip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerticalFlip.Location = new System.Drawing.Point(45, 124);
            this.BtnVerticalFlip.Name = "BtnVerticalFlip";
            this.BtnVerticalFlip.Size = new System.Drawing.Size(30, 30);
            this.BtnVerticalFlip.TabIndex = 30;
            this.BtnVerticalFlip.UseVisualStyleBackColor = false;
            this.BtnVerticalFlip.Click += new System.EventHandler(this.BtnVerticalFlip_Click);
            // 
            // LblSaturation
            // 
            this.LblSaturation.AutoSize = true;
            this.LblSaturation.Location = new System.Drawing.Point(7, 434);
            this.LblSaturation.Name = "LblSaturation";
            this.LblSaturation.Size = new System.Drawing.Size(58, 13);
            this.LblSaturation.TabIndex = 31;
            this.LblSaturation.Text = "Saturation:";
            // 
            // TbSaturation
            // 
            this.TbSaturation.Enabled = false;
            this.TbSaturation.Location = new System.Drawing.Point(9, 450);
            this.TbSaturation.Maximum = 100;
            this.TbSaturation.Minimum = -100;
            this.TbSaturation.Name = "TbSaturation";
            this.TbSaturation.Size = new System.Drawing.Size(239, 45);
            this.TbSaturation.TabIndex = 32;
            this.TbSaturation.Scroll += new System.EventHandler(this.TbSaturation_Scroll);
            // 
            // btnSaveSaturation
            // 
            this.btnSaveSaturation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSaturation.Enabled = false;
            this.btnSaveSaturation.Location = new System.Drawing.Point(9, 485);
            this.btnSaveSaturation.Name = "btnSaveSaturation";
            this.btnSaveSaturation.Size = new System.Drawing.Size(239, 23);
            this.btnSaveSaturation.TabIndex = 33;
            this.btnSaveSaturation.Text = "Apply saturation changes";
            this.btnSaveSaturation.UseVisualStyleBackColor = true;
            this.btnSaveSaturation.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.GbOperations);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.GbOperations.ResumeLayout(false);
            this.GbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDegreeToRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbSaturation)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAsImage;
        private System.Windows.Forms.GroupBox GbOperations;
        private System.Windows.Forms.Label LblRotation;
        private System.Windows.Forms.Button BtnRotateTo90DegreesLeft;
        private System.Windows.Forms.Button BtnRotateToSpecDegreesRight;
        private System.Windows.Forms.NumericUpDown NudDegreeToRotate;
        private System.Windows.Forms.TrackBar TbHue;
        private System.Windows.Forms.Label LblHue;
        private System.Windows.Forms.Button BtnSaveHue;
        private System.Windows.Forms.Button BtnSaveRotation;
        private System.Windows.Forms.Button BtnSaveBrightness;
        private System.Windows.Forms.TrackBar TbBrightness;
        private System.Windows.Forms.Label LblBrightness;
        private System.Windows.Forms.Button BtnSaveContrast;
        private System.Windows.Forms.TrackBar TbContrast;
        private System.Windows.Forms.Label LblContrast;
        private System.Windows.Forms.Button BtnBlackWhiteFilter;
        private System.Windows.Forms.Label LblImageFilters;
        private System.Windows.Forms.Button BtnComicFilter;
        private System.Windows.Forms.Button BtnGothamFilter;
        private System.Windows.Forms.Button BtnPolaroidFilter;
        private System.Windows.Forms.Button BtnInvertFilter;
        private System.Windows.Forms.Button BtnSepiaFilter;
        private System.Windows.Forms.Button BtnSaveFilters;
        private System.Windows.Forms.Label LblFlip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHorizontalFlip;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnVerticalFlip;
        private System.Windows.Forms.Button btnSaveSaturation;
        private System.Windows.Forms.TrackBar TbSaturation;
        private System.Windows.Forms.Label LblSaturation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

