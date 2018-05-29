using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Copier
{
    public partial class frmFileCopier : MetroForm
    {
        public frmFileCopier()
        {
            InitializeComponent();
        }


        private void selectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            if (((Button)sender).Name == "btnSelectFolder")
                txtFolderOrigin.Text = fd.SelectedPath + "\\";
            else
                txtFolderPath.Text = fd.SelectedPath + "\\";
        }

        private void txtFolderOrigin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }
    }
}
