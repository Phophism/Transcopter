namespace Transcopter
{
    partial class UC_send_Progress
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
            this.Send_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_label
            // 
            this.Send_label.AutoSize = true;
            this.Send_label.Location = new System.Drawing.Point(336, 213);
            this.Send_label.Name = "Send_label";
            this.Send_label.Size = new System.Drawing.Size(76, 13);
            this.Send_label.TabIndex = 0;
            this.Send_label.Text = "Send Progress";
            // 
            // UC_send_Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Send_label);
            this.Name = "UC_send_Progress";
            this.Size = new System.Drawing.Size(770, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Send_label;
    }
}
