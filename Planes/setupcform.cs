using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    //form comes up to check when exiting setup screens
    public partial class setupconfirm : Form
    {
        public setupconfirm()
        {
            InitializeComponent();
        }

        //stays on the setup page (P1 or P2)
        private void staybtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes
        }

        //continues to exit fro setup page
        private void continueoutbtn_Click(object sender, EventArgs e)
        {
            //if no of players uc exists, bring that forward
            //else create new no of players uc
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("noPlayersUC"))
            {
                noPlayersUC p1back = new noPlayersUC();
                p1back.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(p1back);
            }
            MainForm.Instance.pagecontainer.Controls["noPlayersUC"].BringToFront();

            if (MainForm.Instance.pagecontainer.Controls.ContainsKey("setP2UC"))
            {
                MainForm.Instance.pagecontainer.Controls.RemoveByKey("setP2UC");
            }
            if (MainForm.Instance.pagecontainer.Controls.ContainsKey("setP1UC"))
            {
                MainForm.Instance.pagecontainer.Controls.RemoveByKey("setP1UC");
            }
            this.Close(); //closes
        }
    }
}
