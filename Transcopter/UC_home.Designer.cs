﻿namespace Transcopter
{
    partial class UC_home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home_lable
            // 
            this.Home_lable.AutoSize = true;
            this.Home_lable.Location = new System.Drawing.Point(343, 228);
            this.Home_lable.Name = "Home_lable";
            this.Home_lable.Size = new System.Drawing.Size(62, 13);
            this.Home_lable.TabIndex = 0;
            this.Home_lable.Text = "Home page";
            // 
            // UC_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Home_lable);
            this.Name = "UC_home";
            this.Size = new System.Drawing.Size(770, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home_lable;
    }
}
