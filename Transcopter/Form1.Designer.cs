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
            this.UC_container = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Btn_home = new System.Windows.Forms.Button();
            this.Btn_send = new System.Windows.Forms.Button();
            this.Btn_his = new System.Windows.Forms.Button();
            this.Panel_back = new System.Windows.Forms.Panel();
            this.Panel_windows = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Panel_left.SuspendLayout();
            this.Panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panel_back.SuspendLayout();
            this.Panel_windows.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_left
            // 
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
            // 
            // Panel_top
            // 
            this.Panel_top.Controls.Add(this.Panel_windows);
            this.Panel_top.Controls.Add(this.Panel_back);
            this.Panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_top.Location = new System.Drawing.Point(130, 0);
            this.Panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_top.Name = "Panel_top";
            this.Panel_top.Size = new System.Drawing.Size(770, 70);
            this.Panel_top.TabIndex = 1;
            // 
            // UC_container
            // 
            this.UC_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_container.Location = new System.Drawing.Point(130, 70);
            this.UC_container.Margin = new System.Windows.Forms.Padding(0);
            this.UC_container.Name = "UC_container";
            this.UC_container.Size = new System.Drawing.Size(770, 480);
            this.UC_container.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 70);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Btn_home
            // 
            this.Btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_home.FlatAppearance.BorderSize = 0;
            this.Btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_home.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_home.Location = new System.Drawing.Point(0, 70);
            this.Btn_home.Name = "Btn_home";
            this.Btn_home.Size = new System.Drawing.Size(130, 90);
            this.Btn_home.TabIndex = 1;
            this.Btn_home.Text = "button1";
            this.Btn_home.UseVisualStyleBackColor = true;
            // 
            // Btn_send
            // 
            this.Btn_send.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_send.FlatAppearance.BorderSize = 0;
            this.Btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_send.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_send.Location = new System.Drawing.Point(0, 160);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(130, 90);
            this.Btn_send.TabIndex = 2;
            this.Btn_send.Text = "button2";
            this.Btn_send.UseVisualStyleBackColor = true;
            // 
            // Btn_his
            // 
            this.Btn_his.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_his.FlatAppearance.BorderSize = 0;
            this.Btn_his.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_his.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_his.Location = new System.Drawing.Point(0, 250);
            this.Btn_his.Name = "Btn_his";
            this.Btn_his.Size = new System.Drawing.Size(130, 90);
            this.Btn_his.TabIndex = 3;
            this.Btn_his.Text = "button3";
            this.Btn_his.UseVisualStyleBackColor = true;
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
            // Btn_Back
            // 
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(20, 14);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(40, 40);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "button4";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // Btn_close
            // 
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_close.Location = new System.Drawing.Point(73, 14);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(40, 40);
            this.Btn_close.TabIndex = 5;
            this.Btn_close.Text = "button5";
            this.Btn_close.UseVisualStyleBackColor = true;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Font = new System.Drawing.Font("Karla", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_minimize.Location = new System.Drawing.Point(27, 14);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(40, 40);
            this.Btn_minimize.TabIndex = 6;
            this.Btn_minimize.Text = "button6";
            this.Btn_minimize.UseVisualStyleBackColor = true;
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
            this.Panel_left.ResumeLayout(false);
            this.Panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panel_back.ResumeLayout(false);
            this.Panel_windows.ResumeLayout(false);
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

