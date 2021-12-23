namespace UltraPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlay = new DevExpress.XtraEditors.SimpleButton();
            this.lbNow = new DevExpress.XtraEditors.LabelControl();
            this.lbDuration = new DevExpress.XtraEditors.LabelControl();
            this.musicProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.songCover = new DevExpress.XtraEditors.PictureEdit();
            this.songArtists = new DevExpress.XtraEditors.LabelControl();
            this.songTitle = new DevExpress.XtraEditors.LabelControl();
            this.listPlayer = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.btnAddFiles = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteFiles = new DevExpress.XtraEditors.SimpleButton();
            this.lbNumberOfSongs = new DevExpress.XtraEditors.LabelControl();
            this.lbBrowseFiles = new DevExpress.XtraEditors.LabelControl();
            this.fileList = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControlToolTip = new DevExpress.Utils.ToolTipController(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.btnSettings = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            this.sidePanel1.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicProgressBar.Properties)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover.Properties)).BeginInit();
            this.listPlayer.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel3);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 536);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1104, 102);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Controls.Add(this.btnPrevious);
            this.sidePanel3.Controls.Add(this.btnNext);
            this.sidePanel3.Controls.Add(this.btnPlay);
            this.sidePanel3.Controls.Add(this.lbNow);
            this.sidePanel3.Controls.Add(this.lbDuration);
            this.sidePanel3.Controls.Add(this.musicProgressBar);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(307, 1);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(797, 101);
            this.sidePanel3.TabIndex = 4;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.AutoWidthInLayoutControl = true;
            this.btnPrevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrevious.ImageOptions.SvgImage")));
            this.btnPrevious.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnPrevious.Location = new System.Drawing.Point(354, 21);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrevious.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnPrevious.Size = new System.Drawing.Size(31, 29);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.ToolTip = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoWidthInLayoutControl = true;
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnNext.Location = new System.Drawing.Point(492, 21);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNext.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNext.Size = new System.Drawing.Size(31, 29);
            this.btnNext.TabIndex = 16;
            this.btnNext.ToolTip = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.AutoWidthInLayoutControl = true;
            this.btnPlay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPlay.ImageOptions.SvgImage")));
            this.btnPlay.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnPlay.Location = new System.Drawing.Point(425, 21);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPlay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnPlay.Size = new System.Drawing.Size(31, 29);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.ToolTip = "Play/Resume";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbNow
            // 
            this.lbNow.Location = new System.Drawing.Point(199, 61);
            this.lbNow.Margin = new System.Windows.Forms.Padding(5);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(31, 17);
            this.lbNow.TabIndex = 10;
            this.lbNow.Text = "00:00";
            // 
            // lbDuration
            // 
            this.lbDuration.Location = new System.Drawing.Point(649, 61);
            this.lbDuration.Margin = new System.Windows.Forms.Padding(4);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(31, 17);
            this.lbDuration.TabIndex = 9;
            this.lbDuration.Text = "10:00";
            // 
            // musicProgressBar
            // 
            this.musicProgressBar.Location = new System.Drawing.Point(240, 68);
            this.musicProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.musicProgressBar.Name = "musicProgressBar";
            this.musicProgressBar.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.True;
            this.musicProgressBar.Size = new System.Drawing.Size(400, 6);
            this.musicProgressBar.TabIndex = 5;
            this.musicProgressBar.Click += new System.EventHandler(this.musicProgressBar_Click);
            this.musicProgressBar.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.musicProgressBar_QueryContinueDrag);
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Controls.Add(this.songCover);
            this.sidePanel2.Controls.Add(this.songArtists);
            this.sidePanel2.Controls.Add(this.songTitle);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 1);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(307, 101);
            this.sidePanel2.TabIndex = 3;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // songCover
            // 
            this.songCover.Location = new System.Drawing.Point(12, 26);
            this.songCover.Name = "songCover";
            this.songCover.Properties.AllowFocused = false;
            this.songCover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.songCover.Properties.ErrorImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("songCover.Properties.ErrorImageOptions.SvgImage")));
            this.songCover.Properties.NullText = " ";
            this.songCover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.songCover.Properties.ShowMenu = false;
            this.songCover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.songCover.Size = new System.Drawing.Size(55, 55);
            this.songCover.TabIndex = 2;
            // 
            // songArtists
            // 
            this.songArtists.Location = new System.Drawing.Point(79, 57);
            this.songArtists.Margin = new System.Windows.Forms.Padding(4);
            this.songArtists.Name = "songArtists";
            this.songArtists.Size = new System.Drawing.Size(70, 17);
            this.songArtists.TabIndex = 1;
            this.songArtists.Text = "Song Artists";
            // 
            // songTitle
            // 
            this.songTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitle.Appearance.Options.UseFont = true;
            this.songTitle.Location = new System.Drawing.Point(79, 30);
            this.songTitle.Margin = new System.Windows.Forms.Padding(4);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(82, 23);
            this.songTitle.TabIndex = 0;
            this.songTitle.Text = "Song Title";
            // 
            // listPlayer
            // 
            this.listPlayer.AllowResize = false;
            this.listPlayer.Controls.Add(this.sidePanel5);
            this.listPlayer.Controls.Add(this.lbBrowseFiles);
            this.listPlayer.Controls.Add(this.fileList);
            this.listPlayer.Controls.Add(this.labelControl1);
            this.listPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPlayer.Location = new System.Drawing.Point(0, 0);
            this.listPlayer.Name = "listPlayer";
            this.listPlayer.Size = new System.Drawing.Size(308, 536);
            this.listPlayer.TabIndex = 1;
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.btnAddFiles);
            this.sidePanel5.Controls.Add(this.btnDeleteFiles);
            this.sidePanel5.Controls.Add(this.lbNumberOfSongs);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 507);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(307, 29);
            this.sidePanel5.TabIndex = 12;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.AutoSize = true;
            this.btnAddFiles.AutoWidthInLayoutControl = true;
            this.btnAddFiles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddFiles.ImageOptions.SvgImage")));
            this.btnAddFiles.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.btnAddFiles.Location = new System.Drawing.Point(275, 0);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddFiles.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAddFiles.Size = new System.Drawing.Size(25, 27);
            this.btnAddFiles.TabIndex = 13;
            this.btnAddFiles.ToolTip = "Add Files";
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.AutoSize = true;
            this.btnDeleteFiles.AutoWidthInLayoutControl = true;
            this.btnDeleteFiles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteFiles.ImageOptions.SvgImage")));
            this.btnDeleteFiles.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.btnDeleteFiles.Location = new System.Drawing.Point(241, 0);
            this.btnDeleteFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeleteFiles.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDeleteFiles.Size = new System.Drawing.Size(25, 27);
            this.btnDeleteFiles.TabIndex = 12;
            this.btnDeleteFiles.ToolTip = "Delete All";
            this.btnDeleteFiles.Click += new System.EventHandler(this.btnDeleteFiles_Click);
            // 
            // lbNumberOfSongs
            // 
            this.lbNumberOfSongs.Appearance.Options.UseTextOptions = true;
            this.lbNumberOfSongs.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.lbNumberOfSongs.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbNumberOfSongs.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumberOfSongs.Location = new System.Drawing.Point(0, 0);
            this.lbNumberOfSongs.Name = "lbNumberOfSongs";
            this.lbNumberOfSongs.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbNumberOfSongs.Size = new System.Drawing.Size(234, 27);
            this.lbNumberOfSongs.TabIndex = 11;
            this.lbNumberOfSongs.Text = "0 songs";
            // 
            // lbBrowseFiles
            // 
            this.lbBrowseFiles.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbBrowseFiles.Appearance.Options.UseForeColor = true;
            this.lbBrowseFiles.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbBrowseFiles.AppearanceHovered.Options.UseForeColor = true;
            this.lbBrowseFiles.Location = new System.Drawing.Point(119, 272);
            this.lbBrowseFiles.Name = "lbBrowseFiles";
            this.lbBrowseFiles.Size = new System.Drawing.Size(71, 17);
            this.lbBrowseFiles.TabIndex = 2;
            this.lbBrowseFiles.Text = "Browse Files";
            this.lbBrowseFiles.Click += new System.EventHandler(this.lbBrowseFiles_Click);
            // 
            // fileList
            // 
            this.fileList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.fileList.Appearance.Options.UseBackColor = true;
            this.fileList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fileList.Location = new System.Drawing.Point(1, 56);
            this.fileList.Margin = new System.Windows.Forms.Padding(4);
            this.fileList.Name = "fileList";
            this.fileList.ShowFocusRect = false;
            this.fileList.Size = new System.Drawing.Size(306, 449);
            this.fileList.TabIndex = 1;
            this.fileList.ToolTipController = this.listBoxControlToolTip;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            this.fileList.Click += new System.EventHandler(this.fileList_Click);
            // 
            // listBoxControlToolTip
            // 
            this.listBoxControlToolTip.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.listBoxControlToolTip_GetActiveObjectInfo);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.labelControl1.Size = new System.Drawing.Size(307, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "File List";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "xtraOpenFileDialog1";
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.Controls.Add(this.btnSettings);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel4.Location = new System.Drawing.Point(308, 0);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(796, 536);
            this.sidePanel4.TabIndex = 2;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoWidthInLayoutControl = true;
            this.btnSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSettings.ImageOptions.SvgImage")));
            this.btnSettings.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnSettings.Location = new System.Drawing.Point(749, 14);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSettings.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSettings.Size = new System.Drawing.Size(31, 29);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.ToolTip = "Add Files";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // svgImageCollection
            // 
            this.svgImageCollection.Add("pause", "image://svgimages/arrows/pause.svg");
            this.svgImageCollection.Add("next", "image://svgimages/arrows/next.svg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 638);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.listPlayer);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraPlayer";
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicProgressBar.Properties)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover.Properties)).EndInit();
            this.listPlayer.ResumeLayout(false);
            this.listPlayer.PerformLayout();
            this.sidePanel5.ResumeLayout(false);
            this.sidePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel listPlayer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.XtraOpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.ListBoxControl fileList;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.ProgressBarControl musicProgressBar;
        private DevExpress.XtraEditors.LabelControl songTitle;
        private DevExpress.XtraEditors.LabelControl songArtists;
        private DevExpress.XtraEditors.LabelControl lbNow;
        private DevExpress.XtraEditors.LabelControl lbDuration;
        private DevExpress.XtraEditors.PictureEdit songCover;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.LabelControl lbBrowseFiles;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.LabelControl lbNumberOfSongs;
        private DevExpress.XtraEditors.SimpleButton btnDeleteFiles;
        private DevExpress.XtraEditors.SimpleButton btnAddFiles;
        private DevExpress.Utils.ToolTipController listBoxControlToolTip;
        private DevExpress.XtraEditors.SimpleButton btnSettings;
        private DevExpress.XtraEditors.SimpleButton btnPlay;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.Utils.SvgImageCollection svgImageCollection;
    }
}

