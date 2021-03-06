﻿namespace AMSExplorer
{
    partial class AMSLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxAcounts = new System.Windows.Forms.ListBox();
            this.buttonSaveToList = new System.Windows.Forms.Button();
            this.buttonDeleteAccountEntry = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBlobKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccountKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxACSBaseAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxScope = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAPIServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonPartner = new System.Windows.Forms.RadioButton();
            this.radioButtonProd = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.buttonImportAll = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.accountmgtlink = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(232, 383);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 28);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(343, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listBoxAcounts
            // 
            this.listBoxAcounts.FormattingEnabled = true;
            this.listBoxAcounts.Location = new System.Drawing.Point(15, 43);
            this.listBoxAcounts.Name = "listBoxAcounts";
            this.listBoxAcounts.Size = new System.Drawing.Size(219, 303);
            this.listBoxAcounts.TabIndex = 10;
            this.listBoxAcounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAcounts_SelectedIndexChanged);
            // 
            // buttonSaveToList
            // 
            this.buttonSaveToList.Location = new System.Drawing.Point(271, 323);
            this.buttonSaveToList.Name = "buttonSaveToList";
            this.buttonSaveToList.Size = new System.Drawing.Size(122, 23);
            this.buttonSaveToList.TabIndex = 14;
            this.buttonSaveToList.Text = "<-- Save to the list";
            this.buttonSaveToList.UseVisualStyleBackColor = true;
            this.buttonSaveToList.Click += new System.EventHandler(this.buttonSaveToList_Click);
            // 
            // buttonDeleteAccountEntry
            // 
            this.buttonDeleteAccountEntry.Enabled = false;
            this.buttonDeleteAccountEntry.Location = new System.Drawing.Point(15, 352);
            this.buttonDeleteAccountEntry.Name = "buttonDeleteAccountEntry";
            this.buttonDeleteAccountEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAccountEntry.TabIndex = 15;
            this.buttonDeleteAccountEntry.Text = "Delete entry";
            this.buttonDeleteAccountEntry.UseVisualStyleBackColor = true;
            this.buttonDeleteAccountEntry.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(399, 323);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 23);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Clear fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(250, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 273);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.textBoxDescription);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxBlobKey);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxAccountKey);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxAccountName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(422, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Credentials";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(17, 204);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(387, 20);
            this.textBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Description (optional)";
            // 
            // textBoxBlobKey
            // 
            this.textBoxBlobKey.Location = new System.Drawing.Point(17, 151);
            this.textBoxBlobKey.Name = "textBoxBlobKey";
            this.textBoxBlobKey.Size = new System.Drawing.Size(387, 20);
            this.textBoxBlobKey.TabIndex = 2;
            this.textBoxBlobKey.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Default Storage Account Access Key (optional, needed for Azure import/export)";
            // 
            // textBoxAccountKey
            // 
            this.textBoxAccountKey.Location = new System.Drawing.Point(17, 98);
            this.textBoxAccountKey.Name = "textBoxAccountKey";
            this.textBoxAccountKey.Size = new System.Drawing.Size(387, 20);
            this.textBoxAccountKey.TabIndex = 1;
            this.textBoxAccountKey.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Azure Media Services Account Key";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(17, 45);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(387, 20);
            this.textBoxAccountName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Azure Media Services Account Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.textBoxACSBaseAddress);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxScope);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxAPIServer);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.radioButtonOther);
            this.tabPage2.Controls.Add(this.radioButtonPartner);
            this.tabPage2.Controls.Add(this.radioButtonProd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            // 
            // textBoxACSBaseAddress
            // 
            this.textBoxACSBaseAddress.Enabled = false;
            this.textBoxACSBaseAddress.Location = new System.Drawing.Point(31, 211);
            this.textBoxACSBaseAddress.Name = "textBoxACSBaseAddress";
            this.textBoxACSBaseAddress.Size = new System.Drawing.Size(375, 20);
            this.textBoxACSBaseAddress.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "ACS Base Address";
            // 
            // textBoxScope
            // 
            this.textBoxScope.Enabled = false;
            this.textBoxScope.Location = new System.Drawing.Point(31, 158);
            this.textBoxScope.Name = "textBoxScope";
            this.textBoxScope.Size = new System.Drawing.Size(375, 20);
            this.textBoxScope.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Scope";
            // 
            // textBoxAPIServer
            // 
            this.textBoxAPIServer.Enabled = false;
            this.textBoxAPIServer.Location = new System.Drawing.Point(31, 105);
            this.textBoxAPIServer.Name = "textBoxAPIServer";
            this.textBoxAPIServer.Size = new System.Drawing.Size(375, 20);
            this.textBoxAPIServer.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "API Server";
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(16, 58);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(54, 17);
            this.radioButtonOther.TabIndex = 34;
            this.radioButtonOther.Text = "Other:";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.CheckedChanged += new System.EventHandler(this.radioButtonOther_CheckedChanged);
            // 
            // radioButtonPartner
            // 
            this.radioButtonPartner.AutoSize = true;
            this.radioButtonPartner.Location = new System.Drawing.Point(16, 35);
            this.radioButtonPartner.Name = "radioButtonPartner";
            this.radioButtonPartner.Size = new System.Drawing.Size(118, 17);
            this.radioButtonPartner.TabIndex = 33;
            this.radioButtonPartner.Text = "Partner Deployment";
            this.radioButtonPartner.UseVisualStyleBackColor = true;
            // 
            // radioButtonProd
            // 
            this.radioButtonProd.AutoSize = true;
            this.radioButtonProd.Checked = true;
            this.radioButtonProd.Location = new System.Drawing.Point(16, 13);
            this.radioButtonProd.Name = "radioButtonProd";
            this.radioButtonProd.Size = new System.Drawing.Size(118, 17);
            this.radioButtonProd.TabIndex = 32;
            this.radioButtonProd.TabStop = true;
            this.radioButtonProd.Text = "Default (production)";
            this.radioButtonProd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Select or enter a Media Services account";
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.Location = new System.Drawing.Point(96, 352);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(64, 23);
            this.buttonExportAll.TabIndex = 32;
            this.buttonExportAll.Text = "Export all";
            this.buttonExportAll.UseVisualStyleBackColor = true;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // buttonImportAll
            // 
            this.buttonImportAll.Location = new System.Drawing.Point(166, 352);
            this.buttonImportAll.Name = "buttonImportAll";
            this.buttonImportAll.Size = new System.Drawing.Size(68, 23);
            this.buttonImportAll.TabIndex = 33;
            this.buttonImportAll.Text = "Import";
            this.buttonImportAll.UseVisualStyleBackColor = true;
            this.buttonImportAll.Click += new System.EventHandler(this.buttonImportAll_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "xml files|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "xml files|*.xml";
            // 
            // accountmgtlink
            // 
            this.accountmgtlink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountmgtlink.AutoSize = true;
            this.accountmgtlink.Location = new System.Drawing.Point(487, 9);
            this.accountmgtlink.Name = "accountmgtlink";
            this.accountmgtlink.Size = new System.Drawing.Size(203, 13);
            this.accountmgtlink.TabIndex = 34;
            this.accountmgtlink.TabStop = true;
            this.accountmgtlink.Text = "How to Create a Media Services Account";
            this.accountmgtlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accountmgtlink_LinkClicked);
            // 
            // AMSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(702, 423);
            this.Controls.Add(this.accountmgtlink);
            this.Controls.Add(this.buttonImportAll);
            this.Controls.Add(this.buttonExportAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDeleteAccountEntry);
            this.Controls.Add(this.buttonSaveToList);
            this.Controls.Add(this.listBoxAcounts);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AMSLogin";
            this.Text = "Azure Media Services Explorer Login";
            this.Load += new System.EventHandler(this.AMSLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxAcounts;
        private System.Windows.Forms.Button buttonSaveToList;
        private System.Windows.Forms.Button buttonDeleteAccountEntry;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBlobKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccountKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxACSBaseAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxScope;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAPIServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonPartner;
        private System.Windows.Forms.RadioButton radioButtonProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExportAll;
        private System.Windows.Forms.Button buttonImportAll;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel accountmgtlink;
    }
}