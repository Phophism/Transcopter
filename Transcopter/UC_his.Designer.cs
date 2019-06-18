namespace Transcopter
{
    partial class UC_his
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
            this.His_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // His_label
            // 
            this.His_label.AutoSize = true;
            this.His_label.Location = new System.Drawing.Point(352, 231);
            this.His_label.Name = "His_label";
            this.His_label.Size = new System.Drawing.Size(66, 13);
            this.His_label.TabIndex = 0;
            this.His_label.Text = "History page";
            // 
            // UC_his
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.His_label);
            this.Name = "UC_his";
            this.Size = new System.Drawing.Size(770, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label His_label;
    }
}
