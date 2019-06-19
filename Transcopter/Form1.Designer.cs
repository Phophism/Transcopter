namespace Transcopter
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
            this.Panel_left = new System.Windows.Forms.Panel();
            this.Panel_top = new System.Windows.Forms.Panel();
            this.Panel_windows = new System.Windows.Forms.Panel();
            this.Panel_back = new System.Windows.Forms.Panel();
            this.UC_container = new System.Windows.Forms.Panel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_his = new System.Windows.Forms.Button();
            this.Btn_send = new System.Windows.Forms.Button();
            this.Btn_home = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panel_left.SuspendLayout();
            this.Panel_top.SuspendLayout();
            this.Panel_windows.SuspendLayout();
            this.Panel_back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_left
            // 
            this.Panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(97)))));
            this.Panel_left.Controls.Add(this.Btn_his);
            this.Panel_left.Controls.Add(this.Btn_send);
            this.Panel_left.Controls.Add(this.Btn_home);
            this.Panel_left.Controls.Add(this.Logo);
            this.Panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_left.Location = new System.Drawing.Point(0, 0);
            this.Panel_left.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_left.Name = "Panel_left";
            this.Panel_left.Size = new System.Drawing.Size(130, 550);
            this.Panel_left.TabIndex = 0;
            this.Panel_left.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_left_Paint);
            // 
            // Panel_top
            // 
            this.Panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.Panel_top.Controls.Add(this.Panel_windows);
            this.Panel_top.Controls.Add(this.Panel_back);
            this.Panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_top.Location = new System.Drawing.Point(130, 0);
            this.Panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_top.Name = "Panel_top";
            this.Panel_top.Size = new System.Drawing.Size(770, 70);
            this.Panel_top.TabIndex = 1;
            this.Panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_top_Paint);
            this.Panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_top_MouseDown);
            this.Panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_top_MouseMove);
            this.Panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_top_MouseUp);
            // 
            // Panel_windows
            // 
            this.Panel_windows.Controls.Add(this.Btn_minimize);
            this.Panel_windows.Controls.Add(this.Btn_close);
            this.Panel_windows.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_windows.Location = new System.Drawing.Point(630, 0);
            this.Panel_windows.Name = "Panel_windows";
            this.Panel_windows.Size = new System.Drawing.Size(140, 70);
            this.Panel_windows.TabIndex = 1;
            // 
            // Panel_back
            // 
            this.Panel_back.Controls.Add(this.Btn_Back);
            this.Panel_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_back.Location = new System.Drawing.Point(0, 0);
            this.Panel_back.Name = "Panel_back";
            this.Panel_back.Size = new System.Drawing.Size(80, 70);
            this.Panel_back.TabIndex = 0;
            // 
            // UC_container
            // 
            this.UC_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.UC_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_container.Location = new System.Drawing.Point(130, 70);
            this.UC_container.Margin = new System.Windows.Forms.Padding(0);
            this.UC_container.Name = "UC_container";
            this.UC_container.Size = new System.Drawing.Size(770, 480);
            this.UC_container.TabIndex = 1;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = global::Transcopter.Properties.Resources.minimize2_white_16;
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_minimize.Location = new System.Drawing.Point(27, 14);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(40, 40);
            this.Btn_minimize.TabIndex = 6;
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.BackgroundImage = global::Transcopter.Properties.Resources.power_white_24;
            this.Btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_close.Location = new System.Drawing.Point(73, 14);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(40, 40);
            this.Btn_close.TabIndex = 5;
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackgroundImage = global::Transcopter.Properties.Resources.back_white_smaller;
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(80, 70);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_his
            // 
            this.Btn_his.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_his.FlatAppearance.BorderSize = 0;
            this.Btn_his.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_his.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_his.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_his.Image = global::Transcopter.Properties.Resources.history2_white;
            this.Btn_his.Location = new System.Drawing.Point(0, 250);
            this.Btn_his.Name = "Btn_his";
            this.Btn_his.Size = new System.Drawing.Size(130, 90);
            this.Btn_his.TabIndex = 3;
            this.Btn_his.Text = "\r\n  HISTORY";
            this.Btn_his.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_his.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_his.UseVisualStyleBackColor = true;
            this.Btn_his.Click += new System.EventHandler(this.Btn_his_Click);
            // 
            // Btn_send
            // 
            this.Btn_send.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_send.FlatAppearance.BorderSize = 0;
            this.Btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_send.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_send.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_send.Image = global::Transcopter.Properties.Resources.drone3_white;
            this.Btn_send.Location = new System.Drawing.Point(0, 160);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(130, 90);
            this.Btn_send.TabIndex = 2;
            this.Btn_send.Text = "\r\n DEPLOY";
            this.Btn_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Btn_home
            // 
            this.Btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_home.FlatAppearance.BorderSize = 0;
            this.Btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_home.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_home.Image = global::Transcopter.Properties.Resources.home_white;
            this.Btn_home.Location = new System.Drawing.Point(0, 70);
            this.Btn_home.Name = "Btn_home";
            this.Btn_home.Size = new System.Drawing.Size(130, 90);
            this.Btn_home.TabIndex = 1;
            this.Btn_home.Text = "\r\n HOME";
            this.Btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_home.UseVisualStyleBackColor = true;
            this.Btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::Transcopter.Properties.Resources.camt_digital_SZs_icon;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 70);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.UC_container);
            this.Controls.Add(this.Panel_top);
            this.Controls.Add(this.Panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_left.ResumeLayout(false);
            this.Panel_top.ResumeLayout(false);
            this.Panel_windows.ResumeLayout(false);
            this.Panel_back.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_left;
        private System.Windows.Forms.Panel Panel_top;
        private System.Windows.Forms.Panel UC_container;
        private System.Windows.Forms.Button Btn_his;
        private System.Windows.Forms.Button Btn_send;
        private System.Windows.Forms.Button Btn_home;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Panel_windows;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Panel Panel_back;
        private System.Windows.Forms.Button Btn_Back;
    }
}

