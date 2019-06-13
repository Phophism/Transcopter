using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transcopter
{
    public partial class UC_send_pre : UserControl
    {
        public UC_send_pre()
        {
            InitializeComponent();
        }

        private void Send_btn_next_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.UC_container_panel.Controls.ContainsKey("UC_send_Progress"))
            {
                UC_send_Progress uc_send_progress = new UC_send_Progress();
                uc_send_progress.Dock = DockStyle.Fill;
                Form1.Instance.UC_container_panel.Controls.Add(uc_send_progress);
            }
            Form1.Instance.UC_container_panel.Controls["UC_send_Progress"].BringToFront();
            Form1.Instance.Back_btn.Visible = true ;
        }
    }
}
