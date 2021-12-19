using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltraPlayer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sidePanel2_Click(object sender, EventArgs e)
        {


        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileList_Click(object sender, EventArgs e)
        {
            if (fileList.Items.Count != 0) return;
            
            openFilesDialog.FileName = "";
            openFilesDialog.Multiselect = true;

            if (openFilesDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFilesDialog.FileNames)
                {
                    fileList.Items.Add(file);
                    
                }
            }
        }

        private void fileList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
