namespace Transcopter
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
            this.Deliver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home_lable
            // 
            this.Home_lable.AutoSize = true;
            this.Home_lable.Location = new System.Drawing.Point(343, 37);
            this.Home_lable.Name = "Home_lable";
            this.Home_lable.Size = new System.Drawing.Size(62, 13);
            this.Home_lable.TabIndex = 0;
            this.Home_lable.Text = "Home page";
            // 
            // Deliver
            // 
            this.Deliver.FlatAppearance.BorderSize = 0;
            this.Deliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deliver.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deliver.Image = global::Transcopter.Properties.Resources.delevery_64;
            this.Deliver.Location = new System.Drawing.Point(304, 325);
            this.Deliver.Name = "Deliver";
            this.Deliver.Size = new System.Drawing.Size(114, 98);
            this.Deliver.TabIndex = 2;
            this.Deliver.Text = "   DELIVER NOW!!";
            this.Deliver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Deliver.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Transcopter.Properties.Resources.camt_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(188, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UC_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Deliver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home_lable);
            this.Name = "UC_home";
            this.Size = new System.Drawing.Size(770, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home_lable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Deliver;
    }
}
