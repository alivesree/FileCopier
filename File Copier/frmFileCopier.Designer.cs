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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pnlProgress.SuspendLayout();
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
            this.pnlProgress.Controls.Add(this.lblFileName);
            this.pnlProgress.Controls.Add(this.metroLabel3);
            this.pnlProgress.Controls.Add(this.metroLabel2);
            this.pnlProgress.Controls.Add(this.prgBar);
            this.pnlProgress.HorizontalScrollbarBarColor = true;
            this.pnlProgress.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProgress.HorizontalScrollbarSize = 10;
            this.pnlProgress.Location = new System.Drawing.Point(10, 215);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(572, 72);
            this.pnlProgress.TabIndex = 118;
            this.pnlProgress.VerticalScrollbarBarColor = true;
            this.pnlProgress.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProgress.VerticalScrollbarSize = 10;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(44, 50);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(45, 19);
            this.lblFileName.TabIndex = 121;
            this.lblFileName.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 120;
            this.metroLabel3.Text = "File : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 119;
            this.metroLabel2.Text = "Copying";
            // 
            // frmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 299);
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblFileName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

