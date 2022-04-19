﻿namespace Framework.Cryptography.UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtSecurePhrase = new System.Windows.Forms.TextBox();
            this.lblSecurePhrase = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Framework.Cryptography.UI.Properties.Resources.encrypt;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(125, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Framework.Cryptography";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(126, 35);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(475, 15);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "This application allows the encryption and decription based on a specific encrypt" +
    "ion type";
            // 
            // ddlType
            // 
            this.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "TripleDESProtectedConfigurationProvider",
            "MD5CryptoServiceProvider"});
            this.ddlType.Location = new System.Drawing.Point(130, 83);
            this.ddlType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(316, 23);
            this.ddlType.TabIndex = 0;
            this.ddlType.SelectedIndexChanged += new System.EventHandler(this.ddlType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(126, 61);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 16);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInput.Location = new System.Drawing.Point(24, 119);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(55, 21);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(24, 143);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Type your text here";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(826, 291);
            this.txtInput.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(762, 576);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(88, 27);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Location = new System.Drawing.Point(644, 576);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(88, 27);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(24, 475);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(826, 95);
            this.txtOutput.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(24, 451);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(68, 21);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output:";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(24, 576);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(88, 27);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtSecurePhrase
            // 
            this.txtSecurePhrase.Enabled = false;
            this.txtSecurePhrase.Location = new System.Drawing.Point(456, 83);
            this.txtSecurePhrase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSecurePhrase.Name = "txtSecurePhrase";
            this.txtSecurePhrase.PlaceholderText = "Type your secure phrase";
            this.txtSecurePhrase.Size = new System.Drawing.Size(394, 23);
            this.txtSecurePhrase.TabIndex = 1;
            this.txtSecurePhrase.UseSystemPasswordChar = true;
            // 
            // lblSecurePhrase
            // 
            this.lblSecurePhrase.AutoSize = true;
            this.lblSecurePhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecurePhrase.Location = new System.Drawing.Point(453, 61);
            this.lblSecurePhrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurePhrase.Name = "lblSecurePhrase";
            this.lblSecurePhrase.Size = new System.Drawing.Size(113, 16);
            this.lblSecurePhrase.TabIndex = 13;
            this.lblSecurePhrase.Text = "Secure Phrase:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 627);
            this.Controls.Add(this.lblSecurePhrase);
            this.Controls.Add(this.txtSecurePhrase);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 666);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(918, 666);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Framework.Cryptography";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtSecurePhrase;
        private System.Windows.Forms.Label lblSecurePhrase;
        private ErrorProvider errorProvider1;
    }
}

