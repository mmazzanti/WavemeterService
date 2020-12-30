﻿
namespace Wavemeter_SVC_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RestartSVC = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckSVC = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.StartSVC = new System.Windows.Forms.Button();
            this.StopSVC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // RestartSVC
            // 
            this.RestartSVC.BackColor = System.Drawing.Color.Coral;
            this.RestartSVC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RestartSVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartSVC.Font = new System.Drawing.Font("JuliaMono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartSVC.ForeColor = System.Drawing.Color.Black;
            this.RestartSVC.Location = new System.Drawing.Point(149, 228);
            this.RestartSVC.Name = "RestartSVC";
            this.RestartSVC.Size = new System.Drawing.Size(210, 54);
            this.RestartSVC.TabIndex = 0;
            this.RestartSVC.Text = "Restart Service";
            this.RestartSVC.UseVisualStyleBackColor = false;
            this.RestartSVC.Click += new System.EventHandler(this.RestartSVC_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(380, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 34);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stopped/Not Running";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckSVC
            // 
            this.CheckSVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckSVC.ForeColor = System.Drawing.Color.Black;
            this.CheckSVC.Location = new System.Drawing.Point(380, 228);
            this.CheckSVC.Name = "CheckSVC";
            this.CheckSVC.Size = new System.Drawing.Size(210, 54);
            this.CheckSVC.TabIndex = 2;
            this.CheckSVC.Text = "Check status";
            this.CheckSVC.UseVisualStyleBackColor = true;
            this.CheckSVC.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(28, 321);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LogBox.Size = new System.Drawing.Size(687, 157);
            this.LogBox.TabIndex = 3;
            // 
            // StartSVC
            // 
            this.StartSVC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.StartSVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartSVC.ForeColor = System.Drawing.Color.Black;
            this.StartSVC.Location = new System.Drawing.Point(149, 143);
            this.StartSVC.Name = "StartSVC";
            this.StartSVC.Size = new System.Drawing.Size(210, 54);
            this.StartSVC.TabIndex = 4;
            this.StartSVC.Text = "Start Service";
            this.StartSVC.UseVisualStyleBackColor = false;
            this.StartSVC.Click += new System.EventHandler(this.StartSVC_Click);
            // 
            // StopSVC
            // 
            this.StopSVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StopSVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopSVC.ForeColor = System.Drawing.Color.Black;
            this.StopSVC.Location = new System.Drawing.Point(380, 143);
            this.StopSVC.Name = "StopSVC";
            this.StopSVC.Size = new System.Drawing.Size(210, 54);
            this.StopSVC.TabIndex = 5;
            this.StopSVC.Text = "Stop Service";
            this.StopSVC.UseVisualStyleBackColor = false;
            this.StopSVC.Click += new System.EventHandler(this.StopSVC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Service status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JuliaMono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(185, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wavemeter Service Manager";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(120, 120);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(742, 490);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopSVC);
            this.Controls.Add(this.StartSVC);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.CheckSVC);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.RestartSVC);
            this.Font = new System.Drawing.Font("JuliaMono", 8F);
            this.ForeColor = System.Drawing.Color.Wheat;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Wavemeter service manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestartSVC;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button CheckSVC;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button StartSVC;
        private System.Windows.Forms.Button StopSVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Logo;
    }
}

