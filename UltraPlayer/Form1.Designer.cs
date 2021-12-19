namespace UltraPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.listPlayer = new DevExpress.XtraEditors.SidePanel();
            this.fileList = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.openFilesDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.sidePanel1.SuspendLayout();
            this.listPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.progressBarControl1);
            this.sidePanel1.Controls.Add(this.labelControl4);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 532);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(989, 102);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl4
            // 
            this.labelControl4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl4.ImageOptions.SvgImage")));
            this.labelControl4.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.labelControl4.Location = new System.Drawing.Point(413, 30);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 25);
            this.labelControl4.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl3.ImageOptions.SvgImage")));
            this.labelControl3.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.labelControl3.Location = new System.Drawing.Point(543, 30);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 25);
            this.labelControl3.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl2.ImageOptions.SvgImage")));
            this.labelControl2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.labelControl2.Location = new System.Drawing.Point(480, 30);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 25);
            this.labelControl2.TabIndex = 0;
            // 
            // listPlayer
            // 
            this.listPlayer.Controls.Add(this.fileList);
            this.listPlayer.Controls.Add(this.labelControl1);
            this.listPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPlayer.Location = new System.Drawing.Point(0, 0);
            this.listPlayer.Name = "listPlayer";
            this.listPlayer.Size = new System.Drawing.Size(245, 532);
            this.listPlayer.TabIndex = 1;
            // 
            // fileList
            // 
            this.fileList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fileList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileList.Location = new System.Drawing.Point(0, 80);
            this.fileList.Margin = new System.Windows.Forms.Padding(4);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(244, 452);
            this.fileList.TabIndex = 1;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged_1);
            this.fileList.Click += new System.EventHandler(this.fileList_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "List";
            // 
            // openFilesDialog
            // 
            this.openFilesDialog.FileName = "xtraOpenFileDialog1";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(296, 73);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(400, 5);
            this.progressBarControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 634);
            this.Controls.Add(this.listPlayer);
            this.Controls.Add(this.sidePanel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraPlayer";
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.listPlayer.ResumeLayout(false);
            this.listPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel listPlayer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.XtraOpenFileDialog openFilesDialog;
        private DevExpress.XtraEditors.ListBoxControl fileList;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}

