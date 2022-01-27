using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class setupconfirm : Form
    {
        public setupconfirm()
        {
            InitializeComponent();
        }

        private void staybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueoutbtn_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("noPlayersUC"))
            {
                noPlayersUC p1back = new noPlayersUC();
                p1back.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(p1back);
            }
            MainForm.Instance.pagecontainer.Controls["noPlayersUC"].BringToFront();
            this.Close();
        }
    }
}
