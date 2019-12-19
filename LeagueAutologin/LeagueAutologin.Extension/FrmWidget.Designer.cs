﻿namespace LeagueAutologin.Extension
{
    partial class FrmWidget
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
            this.tvAccounts = new System.Windows.Forms.TreeView();
            this.btnClose = new System.Windows.Forms.Label();
            this.tmrCheckScreen = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckProcess = new System.Windows.Forms.Timer(this.components);
            this.tmrRelocateForm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tvAccounts
            // 
            this.tvAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAccounts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvAccounts.Location = new System.Drawing.Point(0, 0);
            this.tvAccounts.Name = "tvAccounts";
            this.tvAccounts.Size = new System.Drawing.Size(139, 220);
            this.tvAccounts.TabIndex = 0;
            this.tvAccounts.DoubleClick += new System.EventHandler(this.tvAccounts_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(126, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(12, 13);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrCheckScreen
            // 
            this.tmrCheckScreen.Interval = 500;
            this.tmrCheckScreen.Tick += new System.EventHandler(this.tmrCheckScreen_Tick);
            // 
            // tmrCheckProcess
            // 
            this.tmrCheckProcess.Interval = 250;
            this.tmrCheckProcess.Tick += new System.EventHandler(this.tmrCheckProcess_Tick);
            // 
            // tmrRelocateForm
            // 
            this.tmrRelocateForm.Interval = 150;
            this.tmrRelocateForm.Tick += new System.EventHandler(this.tmrRelocateForm_Tick);
            // 
            // FrmWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 220);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tvAccounts);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWidget";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "LeagueAutologin";
            this.Load += new System.EventHandler(this.FrmWidget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvAccounts;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Timer tmrCheckScreen;
        private System.Windows.Forms.Timer tmrCheckProcess;
        private System.Windows.Forms.Timer tmrRelocateForm;
    }
}

