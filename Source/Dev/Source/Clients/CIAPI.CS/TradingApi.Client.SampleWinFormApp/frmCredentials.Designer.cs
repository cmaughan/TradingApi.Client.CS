﻿namespace TradingApi.Client.SampleWinFormApp
{
    partial class frmCredentials
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
            this.comboSystems = new System.Windows.Forms.ComboBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cmdLogon = new System.Windows.Forms.Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbUserNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboSystems
            // 
            this.comboSystems.FormattingEnabled = true;
            this.comboSystems.Items.AddRange(new object[] {
            "Development",
            "Test",
            "Pre Production",
            "Practice",
            "Live"});
            this.comboSystems.Location = new System.Drawing.Point(106, 26);
            this.comboSystems.Name = "comboSystems";
            this.comboSystems.Size = new System.Drawing.Size(147, 21);
            this.comboSystems.TabIndex = 48;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.ForeColor = System.Drawing.Color.Black;
            this.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdExit.Location = new System.Drawing.Point(148, 115);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(105, 23);
            this.cmdExit.TabIndex = 42;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(13, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 26);
            this.lblUserName.TabIndex = 46;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdLogon
            // 
            this.cmdLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogon.ForeColor = System.Drawing.Color.Black;
            this.cmdLogon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdLogon.Location = new System.Drawing.Point(39, 115);
            this.cmdLogon.Name = "cmdLogon";
            this.cmdLogon.Size = new System.Drawing.Size(105, 23);
            this.cmdLogon.TabIndex = 43;
            this.cmdLogon.Text = "Log-On";
            this.cmdLogon.UseVisualStyleBackColor = false;
            this.cmdLogon.Click += new System.EventHandler(this.cmdLogon_Click);
            // 
            // lblSystem
            // 
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSystem.Location = new System.Drawing.Point(13, 26);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(86, 22);
            this.lblSystem.TabIndex = 49;
            this.lblSystem.Text = "System";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(147, 20);
            this.txtPassword.TabIndex = 45;
            // 
            // lblPassword
            // 
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(13, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 23);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUserNames
            // 
            this.cbUserNames.FormattingEnabled = true;
            this.cbUserNames.Location = new System.Drawing.Point(106, 49);
            this.cbUserNames.Name = "cbUserNames";
            this.cbUserNames.Size = new System.Drawing.Size(147, 21);
            this.cbUserNames.TabIndex = 44;
            // 
            // frmCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(292, 154);
            this.ControlBox = false;
            this.Controls.Add(this.comboSystems);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmdLogon);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbUserNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCredentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "API LogOn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCredentials_FormClosing);
            this.Load += new System.EventHandler(this.frmCredentials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox comboSystems;
        internal System.Windows.Forms.Button cmdExit;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Button cmdLogon;
        internal System.Windows.Forms.Label lblSystem;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.ComboBox cbUserNames;
    }
}