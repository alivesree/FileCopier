using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            pnlSize.Show();
            pnlProgress.Visible = true;
            pnlFileinfo.Hide();
            Application.DoEvents();
            prgBar.ProgressBarStyle = ProgressBarStyle.Marquee;
            prgBar.MarqueeAnimationSpeed = 1;
            prgBar.Refresh();
            Application.DoEvents();
            this.Refresh();
            lblStatus.Text = "Getting Info";
            Task.Run(() => getDirectoryInfo());
            this.Refresh();
            prgBar.Refresh();
        }
        
        private void getDirectoryInfo()
        {
            long size = 0, count = 0;
            size = new DirectoryInfo(txtFolderOrigin.Text).EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);
            Application.DoEvents();
            count = new DirectoryInfo(txtFolderOrigin.Text).EnumerateFiles("*.*", SearchOption.AllDirectories).Count() - 1;
            this.Invoke((MethodInvoker)delegate
            {
                lblFiles.Text = (++count).ToString();
                Application.DoEvents();
                lblSize.Text =  (size / (1024 * 1024 )).ToString() + " MB";
                this.Refresh();
                pnlProgress.Hide();
            });
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {

        }
    }
}
