namespace Transcopter
{
    partial class UC_send_pre
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
            this.Send_btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send_label
            // 
            this.Send_label.AutoSize = true;
            this.Send_label.Location = new System.Drawing.Point(351, 196);
            this.Send_label.Name = "Send_label";
            this.Send_label.Size = new System.Drawing.Size(51, 13);
            this.Send_label.TabIndex = 0;
            this.Send_label.Text = "Pre Send";
            // 
            // Send_btn_next
            // 
            this.Send_btn_next.Location = new System.Drawing.Point(354, 242);
            this.Send_btn_next.Name = "Send_btn_next";
            this.Send_btn_next.Size = new System.Drawing.Size(48, 26);
            this.Send_btn_next.TabIndex = 1;
            this.Send_btn_next.Text = "next";
            this.Send_btn_next.UseVisualStyleBackColor = true;
            // 
            // UC_send_pre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Send_btn_next);
            this.Controls.Add(this.Send_label);
            this.Name = "UC_send_pre";
            this.Size = new System.Drawing.Size(770, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Send_label;
        private System.Windows.Forms.Button Send_btn_next;
    }
}
