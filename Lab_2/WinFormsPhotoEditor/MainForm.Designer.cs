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
            this.BtnSaveFilters = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.GbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbHue)).BeginInit();
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
            this.Menu.Size = new System.Drawing.Size(984, 24);
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
            this.GbOperations.Location = new System.Drawing.Point(718, 27);
            this.GbOperations.Name = "GbOperations";
            this.GbOperations.Size = new System.Drawing.Size(254, 572);
            this.GbOperations.TabIndex = 4;
            this.GbOperations.TabStop = false;
            this.GbOperations.Text = "Operations";
            // 
            // BtnSepiaFilter
            // 
            this.BtnSepiaFilter.BackgroundImage = global::WinFormsPhotoEditor.Resources.Sepia;
            this.BtnSepiaFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSepiaFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSepiaFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSepiaFilter.Location = new System.Drawing.Point(171, 423);
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
            this.BtnPolaroidFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPolaroidFilter.Location = new System.Drawing.Point(90, 423);
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
            this.BtnInvertFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInvertFilter.Location = new System.Drawing.Point(9, 423);
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
            this.BtnGothamFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGothamFilter.Location = new System.Drawing.Point(171, 367);
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
            this.BtnComicFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComicFilter.Location = new System.Drawing.Point(90, 367);
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
            this.BtnBlackWhiteFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlackWhiteFilter.Location = new System.Drawing.Point(9, 367);
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
            this.LblImageFilters.Location = new System.Drawing.Point(6, 351);
            this.LblImageFilters.Name = "LblImageFilters";
            this.LblImageFilters.Size = new System.Drawing.Size(37, 13);
            this.LblImageFilters.TabIndex = 17;
            this.LblImageFilters.Text = "Filters:";
            // 
            // BtnSaveContrast
            // 
            this.BtnSaveContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveContrast.Location = new System.Drawing.Point(9, 320);
            this.BtnSaveContrast.Name = "BtnSaveContrast";
            this.BtnSaveContrast.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveContrast.TabIndex = 16;
            this.BtnSaveContrast.Text = "Apply contrast changes";
            this.BtnSaveContrast.UseVisualStyleBackColor = true;
            this.BtnSaveContrast.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // TbContrast
            // 
            this.TbContrast.Location = new System.Drawing.Point(9, 287);
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
            this.LblContrast.Location = new System.Drawing.Point(6, 271);
            this.LblContrast.Name = "LblContrast";
            this.LblContrast.Size = new System.Drawing.Size(49, 13);
            this.LblContrast.TabIndex = 14;
            this.LblContrast.Text = "Contrast:";
            // 
            // BtnSaveBrightness
            // 
            this.BtnSaveBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveBrightness.Location = new System.Drawing.Point(9, 240);
            this.BtnSaveBrightness.Name = "BtnSaveBrightness";
            this.BtnSaveBrightness.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveBrightness.TabIndex = 13;
            this.BtnSaveBrightness.Text = "Apply brightness changes";
            this.BtnSaveBrightness.UseVisualStyleBackColor = true;
            this.BtnSaveBrightness.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // TbBrightness
            // 
            this.TbBrightness.Location = new System.Drawing.Point(9, 207);
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
            this.LblBrightness.Location = new System.Drawing.Point(6, 191);
            this.LblBrightness.Name = "LblBrightness";
            this.LblBrightness.Size = new System.Drawing.Size(59, 13);
            this.LblBrightness.TabIndex = 11;
            this.LblBrightness.Text = "Brightness:";
            // 
            // BtnSaveRotation
            // 
            this.BtnSaveRotation.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.BtnSaveHue.Location = new System.Drawing.Point(9, 160);
            this.BtnSaveHue.Name = "BtnSaveHue";
            this.BtnSaveHue.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveHue.TabIndex = 9;
            this.BtnSaveHue.Text = "Apply hue changes";
            this.BtnSaveHue.UseVisualStyleBackColor = true;
            this.BtnSaveHue.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // TbHue
            // 
            this.TbHue.Location = new System.Drawing.Point(9, 127);
            this.TbHue.Maximum = 360;
            this.TbHue.Name = "TbHue";
            this.TbHue.Size = new System.Drawing.Size(239, 45);
            this.TbHue.TabIndex = 8;
            this.TbHue.Scroll += new System.EventHandler(this.TbHue_Scroll);
            // 
            // LblHue
            // 
            this.LblHue.AutoSize = true;
            this.LblHue.Location = new System.Drawing.Point(6, 111);
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
            this.PbImage.Size = new System.Drawing.Size(700, 572);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // BtnSaveFilters
            // 
            this.BtnSaveFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveFilters.Location = new System.Drawing.Point(9, 479);
            this.BtnSaveFilters.Name = "BtnSaveFilters";
            this.BtnSaveFilters.Size = new System.Drawing.Size(239, 23);
            this.BtnSaveFilters.TabIndex = 24;
            this.BtnSaveFilters.Text = "Apply filters";
            this.BtnSaveFilters.UseVisualStyleBackColor = true;
            this.BtnSaveFilters.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.GbOperations);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.Menu);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
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
    }
}

