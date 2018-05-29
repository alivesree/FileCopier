namespace File_Copier
{
    partial class frmFileCopier
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
            this.btnSelectFolder2 = new MetroFramework.Controls.MetroButton();
            this.btnSelectFolder = new MetroFramework.Controls.MetroButton();
            this.txtFolderOrigin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtFolderPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.prgBar = new MetroFramework.Controls.MetroProgressBar();
            this.btnCopy = new MetroFramework.Controls.MetroButton();
            this.pnlProgress = new MetroFramework.Controls.MetroPanel();
            this.lblFileName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.pnlSize = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblFiles = new MetroFramework.Controls.MetroLabel();
            this.lblSize = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pnlFileinfo = new MetroFramework.Controls.MetroPanel();
            this.pnlProgress.SuspendLayout();
            this.pnlSize.SuspendLayout();
            this.pnlFileinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder2
            // 
            this.btnSelectFolder2.BackgroundImage = global::File_Copier.Properties.Resources.folderIcon;
            this.btnSelectFolder2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectFolder2.Location = new System.Drawing.Point(516, 129);
            this.btnSelectFolder2.Name = "btnSelectFolder2";
            this.btnSelectFolder2.Size = new System.Drawing.Size(25, 23);
            this.btnSelectFolder2.Style = MetroFramework.MetroColorStyle.White;
            this.btnSelectFolder2.TabIndex = 21;
            this.btnSelectFolder2.UseSelectable = true;
            this.btnSelectFolder2.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackgroundImage = global::File_Copier.Properties.Resources.folderIcon;
            this.btnSelectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectFolder.Location = new System.Drawing.Point(516, 80);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(25, 23);
            this.btnSelectFolder.Style = MetroFramework.MetroColorStyle.White;
            this.btnSelectFolder.TabIndex = 20;
            this.btnSelectFolder.UseSelectable = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // txtFolderOrigin
            // 
            // 
            // 
            // 
            this.txtFolderOrigin.CustomButton.Image = null;
            this.txtFolderOrigin.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.txtFolderOrigin.CustomButton.Name = "";
            this.txtFolderOrigin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolderOrigin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolderOrigin.CustomButton.TabIndex = 1;
            this.txtFolderOrigin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolderOrigin.CustomButton.UseSelectable = true;
            this.txtFolderOrigin.CustomButton.Visible = false;
            this.txtFolderOrigin.Lines = new string[0];
            this.txtFolderOrigin.Location = new System.Drawing.Point(146, 80);
            this.txtFolderOrigin.MaxLength = 32767;
            this.txtFolderOrigin.Name = "txtFolderOrigin";
            this.txtFolderOrigin.PasswordChar = '\0';
            this.txtFolderOrigin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolderOrigin.SelectedText = "";
            this.txtFolderOrigin.SelectionLength = 0;
            this.txtFolderOrigin.SelectionStart = 0;
            this.txtFolderOrigin.ShortcutsEnabled = true;
            this.txtFolderOrigin.Size = new System.Drawing.Size(364, 23);
            this.txtFolderOrigin.TabIndex = 19;
            this.txtFolderOrigin.UseSelectable = true;
            this.txtFolderOrigin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolderOrigin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolderOrigin.TextChanged += new System.EventHandler(this.txtFolderOrigin_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 82);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "folder origin";
            // 
            // txtFolderPath
            // 
            // 
            // 
            // 
            this.txtFolderPath.CustomButton.Image = null;
            this.txtFolderPath.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.txtFolderPath.CustomButton.Name = "";
            this.txtFolderPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolderPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolderPath.CustomButton.TabIndex = 1;
            this.txtFolderPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolderPath.CustomButton.UseSelectable = true;
            this.txtFolderPath.CustomButton.Visible = false;
            this.txtFolderPath.Lines = new string[0];
            this.txtFolderPath.Location = new System.Drawing.Point(146, 129);
            this.txtFolderPath.MaxLength = 32767;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.PasswordChar = '\0';
            this.txtFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolderPath.SelectedText = "";
            this.txtFolderPath.SelectionLength = 0;
            this.txtFolderPath.SelectionStart = 0;
            this.txtFolderPath.ShortcutsEnabled = true;
            this.txtFolderPath.Size = new System.Drawing.Size(364, 23);
            this.txtFolderPath.TabIndex = 17;
            this.txtFolderPath.UseSelectable = true;
            this.txtFolderPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolderPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "folder to save files";
            // 
            // prgBar
            // 
            this.prgBar.HideProgressText = false;
            this.prgBar.Location = new System.Drawing.Point(3, 26);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(560, 23);
            this.prgBar.TabIndex = 22;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(146, 174);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 117;
            this.btnCopy.TabStop = false;
            this.btnCopy.Text = "Start Copy";
            this.btnCopy.UseCustomBackColor = true;
            this.btnCopy.UseCustomForeColor = true;
            this.btnCopy.UseSelectable = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.pnlFileinfo);
            this.pnlProgress.Controls.Add(this.lblStatus);
            this.pnlProgress.Controls.Add(this.prgBar);
            this.pnlProgress.HorizontalScrollbarBarColor = true;
            this.pnlProgress.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProgress.HorizontalScrollbarSize = 10;
            this.pnlProgress.Location = new System.Drawing.Point(10, 202);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(572, 72);
            this.pnlProgress.TabIndex = 118;
            this.pnlProgress.VerticalScrollbarBarColor = true;
            this.pnlProgress.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProgress.VerticalScrollbarSize = 10;
            this.pnlProgress.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(41, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(45, 19);
            this.lblFileName.TabIndex = 121;
            this.lblFileName.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 120;
            this.metroLabel3.Text = "File : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 119;
            this.lblStatus.Text = "Copying";
            // 
            // pnlSize
            // 
            this.pnlSize.Controls.Add(this.lblSize);
            this.pnlSize.Controls.Add(this.metroLabel5);
            this.pnlSize.Controls.Add(this.lblFiles);
            this.pnlSize.Controls.Add(this.metroLabel7);
            this.pnlSize.HorizontalScrollbarBarColor = true;
            this.pnlSize.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSize.HorizontalScrollbarSize = 10;
            this.pnlSize.Location = new System.Drawing.Point(238, 163);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(303, 39);
            this.pnlSize.TabIndex = 122;
            this.pnlSize.VerticalScrollbarBarColor = true;
            this.pnlSize.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSize.VerticalScrollbarSize = 10;
            this.pnlSize.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(2, 11);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 119;
            this.metroLabel7.Text = "Total Files";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(68, 11);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(34, 19);
            this.lblFiles.TabIndex = 120;
            this.lblFiles.Text = "Files";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(191, 11);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(32, 19);
            this.lblSize.TabIndex = 122;
            this.lblSize.Text = "Size";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(126, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 121;
            this.metroLabel5.Text = "Total Size :";
            // 
            // pnlFileinfo
            // 
            this.pnlFileinfo.Controls.Add(this.metroLabel3);
            this.pnlFileinfo.Controls.Add(this.lblFileName);
            this.pnlFileinfo.HorizontalScrollbarBarColor = true;
            this.pnlFileinfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFileinfo.HorizontalScrollbarSize = 10;
            this.pnlFileinfo.Location = new System.Drawing.Point(3, 49);
            this.pnlFileinfo.Name = "pnlFileinfo";
            this.pnlFileinfo.Size = new System.Drawing.Size(421, 20);
            this.pnlFileinfo.TabIndex = 123;
            this.pnlFileinfo.VerticalScrollbarBarColor = true;
            this.pnlFileinfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFileinfo.VerticalScrollbarSize = 10;
            // 
            // frmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 278);
            this.Controls.Add(this.pnlSize);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSelectFolder2);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtFolderOrigin);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmFileCopier";
            this.Text = "File Copier";
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            this.pnlFileinfo.ResumeLayout(false);
            this.pnlFileinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSelectFolder2;
        private MetroFramework.Controls.MetroButton btnSelectFolder;
        private MetroFramework.Controls.MetroTextBox txtFolderOrigin;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtFolderPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar prgBar;
        private MetroFramework.Controls.MetroButton btnCopy;
        private MetroFramework.Controls.MetroPanel pnlProgress;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel lblFileName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel pnlSize;
        private MetroFramework.Controls.MetroLabel lblSize;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblFiles;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel pnlFileinfo;
    }
}

