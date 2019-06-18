﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transcopter
{
    public partial class Form1 : Form
    {

        UC_home uc_home = new UC_home();
        UC_send_pre uc_send_pre = new UC_send_pre();
        UC_send_Progress uc_send_progress = new UC_send_Progress();
        UC_his uc_his = new UC_his();

        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj ;
            }
        }

        public Panel UC_container_panel
        {
            get { return UC_container; }
            set { UC_container = value;  }
        }

        public Button Back_btn
        {
            get { return Btn_Back; }
            set { Btn_Back = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            uc_home.BringToFront();
            Btn_Back.Visible = false;
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            
            uc_send_pre.BringToFront();
            Btn_Back.Visible = false;
        }

        private void Btn_his_Click(object sender, EventArgs e)
        {
            uc_his.BringToFront();
            Btn_Back.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Back.Visible = false;
            _obj = this;

            // Set dock style for added user control
            uc_home.Dock = DockStyle.Fill;
            uc_send_pre.Dock = DockStyle.Fill;
            uc_send_progress.Dock = DockStyle.Fill;
            uc_his.Dock = DockStyle.Fill;

            // Add user control to main layout
            // All existing user controls must be added 
            UC_container_panel.Controls.Add(uc_home);
            UC_container_panel.Controls.Add(uc_send_pre);
            UC_container_panel.Controls.Add(uc_send_progress);
            UC_container_panel.Controls.Add(uc_his);


        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            UC_container_panel.Controls["UC_send_pre"].BringToFront();
            Btn_Back.Visible = false;
        }
    }
}
