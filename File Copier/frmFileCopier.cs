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
            count = new DirectoryInfo(txtFolderOrigin.Text).EnumerateFiles("*.*", SearchOption.AllDirectories).Count() ;
            this.Invoke((MethodInvoker)delegate
            {
                pnlSize.Show();
                lblFiles.Text = (count).ToString();
                Application.DoEvents();
                lblSize.Text =  (size / (1024 * 1024 )).ToString() + " MB";
                lblFiles.Tag = count;
                this.Refresh();
                pnlProgress.Hide();
            });
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            pnlProgress.Show();
            pnlFileinfo.Show();
            prgBar.ProgressBarStyle = ProgressBarStyle.Continuous;
            prgBar.Minimum = 0;
            prgBar.Maximum = Convert.ToInt32( lblFiles.Tag);
            prgBar.Refresh();
            prgBar.HideProgressText = false;
            lblStatus.Text = "Copying";
            foreach (string newPath in Directory.GetFiles(txtFolderOrigin.Text, "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    int count = 1;
                    string newFullPath = txtFolderPath.Text + newPath.Split('\\').Last();
                    while (File.Exists(newFullPath))
                    {
                        if (new FileInfo(newPath).Extension != "")
                        {
                            string tempFileName = string.Format("{0}({1})", newPath.Split('\\').Last().Replace(new FileInfo(newPath).Extension, ""), count++);
                            newFullPath = Path.Combine(newFullPath.Replace(newFullPath.Split('\\').Last(), ""), tempFileName + new FileInfo(newPath).Extension);
                        }
                        else
                        {
                            string tempFileName = string.Format("{0}({1})", newPath, count++);
                            newFullPath = Path.Combine(newFullPath.Replace(newFullPath.Split('\\').Last(), ""), tempFileName + new FileInfo(newPath).Extension);
                        }
                    }
                    lblFileName.Text = new FileInfo(newPath).Name;
                    File.Copy(newPath, newFullPath);
                    prgBar.Value++;
                    this.Refresh();
                }
                catch 
                {
                    MessageBox.Show("Missed file " + newPath);
                }

            }
            this.Refresh();
            MessageBox.Show("Completed");
        }
    }
}
