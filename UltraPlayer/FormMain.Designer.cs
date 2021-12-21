﻿namespace UltraPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.lbNow = new DevExpress.XtraEditors.LabelControl();
            this.lbDuration = new DevExpress.XtraEditors.LabelControl();
            this.btnStop = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.musicProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnPrevious = new DevExpress.XtraEditors.LabelControl();
            this.btnNext = new DevExpress.XtraEditors.LabelControl();
            this.btnPlay = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.songCover = new DevExpress.XtraEditors.PictureEdit();
            this.songArtists = new DevExpress.XtraEditors.LabelControl();
            this.songTitle = new DevExpress.XtraEditors.LabelControl();
            this.listPlayer = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.btnAddFiles = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteFiles = new DevExpress.XtraEditors.SimpleButton();
            this.lbDirectory = new DevExpress.XtraEditors.LabelControl();
            this.lbBrowseFiles = new DevExpress.XtraEditors.LabelControl();
            this.fileList = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicProgressBar.Properties)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover.Properties)).BeginInit();
            this.listPlayer.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel3);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 532);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(989, 102);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Controls.Add(this.lbNow);
            this.sidePanel3.Controls.Add(this.lbDuration);
            this.sidePanel3.Controls.Add(this.btnStop);
            this.sidePanel3.Controls.Add(this.labelControl2);
            this.sidePanel3.Controls.Add(this.musicProgressBar);
            this.sidePanel3.Controls.Add(this.btnPrevious);
            this.sidePanel3.Controls.Add(this.btnNext);
            this.sidePanel3.Controls.Add(this.btnPlay);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(307, 1);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(682, 101);
            this.sidePanel3.TabIndex = 4;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // lbNow
            // 
            this.lbNow.Location = new System.Drawing.Point(117, 61);
            this.lbNow.Margin = new System.Windows.Forms.Padding(5);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(31, 17);
            this.lbNow.TabIndex = 10;
            this.lbNow.Text = "00:00";
            // 
            // lbDuration
            // 
            this.lbDuration.Location = new System.Drawing.Point(567, 61);
            this.lbDuration.Margin = new System.Windows.Forms.Padding(4);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(31, 17);
            this.lbDuration.TabIndex = 9;
            this.lbDuration.Text = "10:00";
            // 
            // btnStop
            // 
            this.btnStop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStop.ImageOptions.SvgImage")));
            this.btnStop.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnStop.Location = new System.Drawing.Point(227, 23);
            this.btnStop.Margin = new System.Windows.Forms.Padding(10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(25, 25);
            this.btnStop.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl2.ImageOptions.SvgImage")));
            this.labelControl2.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.labelControl2.Location = new System.Drawing.Point(460, 26);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 19);
            this.labelControl2.TabIndex = 7;
            // 
            // musicProgressBar
            // 
            this.musicProgressBar.Location = new System.Drawing.Point(158, 68);
            this.musicProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.musicProgressBar.Name = "musicProgressBar";
            this.musicProgressBar.Size = new System.Drawing.Size(400, 6);
            this.musicProgressBar.TabIndex = 5;
            this.musicProgressBar.Click += new System.EventHandler(this.musicProgressBar_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrevious.ImageOptions.SvgImage")));
            this.btnPrevious.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnPrevious.Location = new System.Drawing.Point(289, 23);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 25);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.ToolTip = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnNext.Location = new System.Drawing.Point(399, 23);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.TabIndex = 4;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPlay.ImageOptions.SvgImage")));
            this.btnPlay.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnPlay.Location = new System.Drawing.Point(344, 23);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 25);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.ToolTip = "Play";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
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
            this.listPlayer.Size = new System.Drawing.Size(308, 532);
            this.listPlayer.TabIndex = 1;
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.btnAddFiles);
            this.sidePanel5.Controls.Add(this.btnDeleteFiles);
            this.sidePanel5.Controls.Add(this.lbDirectory);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 503);
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
            // 
            // lbDirectory
            // 
            this.lbDirectory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDirectory.Location = new System.Drawing.Point(0, 0);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbDirectory.Size = new System.Drawing.Size(190, 27);
            this.lbDirectory.TabIndex = 11;
            this.lbDirectory.Text = "Chosen Directory";
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
            this.lbBrowseFiles.Click += new System.EventHandler(this.labelControl3_Click);
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
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged_1);
            this.fileList.Click += new System.EventHandler(this.fileList_Click);
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
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel4.Location = new System.Drawing.Point(308, 0);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(681, 532);
            this.sidePanel4.TabIndex = 2;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 634);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.listPlayer);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormMain.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private DevExpress.XtraEditors.LabelControl btnPrevious;
        private DevExpress.XtraEditors.LabelControl btnNext;
        private DevExpress.XtraEditors.LabelControl btnPlay;
        private DevExpress.XtraEditors.LabelControl songTitle;
        private DevExpress.XtraEditors.LabelControl songArtists;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl btnStop;
        private DevExpress.XtraEditors.LabelControl lbNow;
        private DevExpress.XtraEditors.LabelControl lbDuration;
        private DevExpress.XtraEditors.PictureEdit songCover;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.LabelControl lbBrowseFiles;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.LabelControl lbDirectory;
        private DevExpress.XtraEditors.SimpleButton btnDeleteFiles;
        private DevExpress.XtraEditors.SimpleButton btnAddFiles;
    }
}

