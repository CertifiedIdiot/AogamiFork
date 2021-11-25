﻿namespace Aogami.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenSaveFileButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SaveDataTabControl = new System.Windows.Forms.TabControl();
            this.GeneralStatsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.SaveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.MakeBackUpCheckbox = new System.Windows.Forms.CheckBox();
            this.ImportDecryptedDataButton = new System.Windows.Forms.Button();
            this.ExportDecryptedDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SaveDataTabControl.SuspendLayout();
            this.SaveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenSaveFileButton
            // 
            this.OpenSaveFileButton.Location = new System.Drawing.Point(168, 12);
            this.OpenSaveFileButton.Name = "OpenSaveFileButton";
            this.OpenSaveFileButton.Size = new System.Drawing.Size(144, 60);
            this.OpenSaveFileButton.TabIndex = 0;
            this.OpenSaveFileButton.Text = "Open Save File...";
            this.OpenSaveFileButton.UseVisualStyleBackColor = true;
            this.OpenSaveFileButton.Click += new System.EventHandler(this.OpenSaveFileButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(150, 60);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Honeydew;
            this.SaveChangesButton.Enabled = false;
            this.SaveChangesButton.Location = new System.Drawing.Point(318, 12);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(111, 33);
            this.SaveChangesButton.TabIndex = 2;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // SaveDataTabControl
            // 
            this.SaveDataTabControl.Controls.Add(this.GeneralStatsTabPage);
            this.SaveDataTabControl.Controls.Add(this.ItemsTabPage);
            this.SaveDataTabControl.Location = new System.Drawing.Point(6, 22);
            this.SaveDataTabControl.Name = "SaveDataTabControl";
            this.SaveDataTabControl.SelectedIndex = 0;
            this.SaveDataTabControl.Size = new System.Drawing.Size(548, 259);
            this.SaveDataTabControl.TabIndex = 3;
            // 
            // GeneralStatsTabPage
            // 
            this.GeneralStatsTabPage.Location = new System.Drawing.Point(4, 24);
            this.GeneralStatsTabPage.Name = "GeneralStatsTabPage";
            this.GeneralStatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralStatsTabPage.Size = new System.Drawing.Size(540, 231);
            this.GeneralStatsTabPage.TabIndex = 0;
            this.GeneralStatsTabPage.Text = "General";
            this.GeneralStatsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(540, 231);
            this.ItemsTabPage.TabIndex = 1;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveDataGroupBox
            // 
            this.SaveDataGroupBox.Controls.Add(this.SaveDataTabControl);
            this.SaveDataGroupBox.Location = new System.Drawing.Point(12, 78);
            this.SaveDataGroupBox.Name = "SaveDataGroupBox";
            this.SaveDataGroupBox.Size = new System.Drawing.Size(560, 287);
            this.SaveDataGroupBox.TabIndex = 4;
            this.SaveDataGroupBox.TabStop = false;
            this.SaveDataGroupBox.Text = "Save Data";
            // 
            // MakeBackUpCheckbox
            // 
            this.MakeBackUpCheckbox.AutoSize = true;
            this.MakeBackUpCheckbox.Location = new System.Drawing.Point(318, 51);
            this.MakeBackUpCheckbox.Name = "MakeBackUpCheckbox";
            this.MakeBackUpCheckbox.Size = new System.Drawing.Size(111, 19);
            this.MakeBackUpCheckbox.TabIndex = 5;
            this.MakeBackUpCheckbox.Text = "Make a back-up";
            this.MakeBackUpCheckbox.UseVisualStyleBackColor = true;
            // 
            // ImportDecryptedDataButton
            // 
            this.ImportDecryptedDataButton.Location = new System.Drawing.Point(435, 12);
            this.ImportDecryptedDataButton.Name = "ImportDecryptedDataButton";
            this.ImportDecryptedDataButton.Size = new System.Drawing.Size(137, 27);
            this.ImportDecryptedDataButton.TabIndex = 6;
            this.ImportDecryptedDataButton.Text = "Import Decrypted Data";
            this.ImportDecryptedDataButton.UseVisualStyleBackColor = true;
            this.ImportDecryptedDataButton.Click += new System.EventHandler(this.ImportDecryptedDataButton_Click);
            // 
            // ExportDecryptedDataButton
            // 
            this.ExportDecryptedDataButton.Location = new System.Drawing.Point(435, 45);
            this.ExportDecryptedDataButton.Name = "ExportDecryptedDataButton";
            this.ExportDecryptedDataButton.Size = new System.Drawing.Size(137, 27);
            this.ExportDecryptedDataButton.TabIndex = 7;
            this.ExportDecryptedDataButton.Text = "Export Decrypted Data";
            this.ExportDecryptedDataButton.UseVisualStyleBackColor = true;
            this.ExportDecryptedDataButton.Click += new System.EventHandler(this.ExportDecryptedDataButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.ExportDecryptedDataButton);
            this.Controls.Add(this.ImportDecryptedDataButton);
            this.Controls.Add(this.MakeBackUpCheckbox);
            this.Controls.Add(this.SaveDataGroupBox);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.OpenSaveFileButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Aogami";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.SaveDataTabControl.ResumeLayout(false);
            this.SaveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OpenSaveFileButton;
        private PictureBox LogoPictureBox;
        private Button SaveChangesButton;
        private TabControl SaveDataTabControl;
        private TabPage GeneralStatsTabPage;
        private TabPage ItemsTabPage;
        private GroupBox SaveDataGroupBox;
        private CheckBox MakeBackUpCheckbox;
        private Button ImportDecryptedDataButton;
        private Button ExportDecryptedDataButton;
    }
}