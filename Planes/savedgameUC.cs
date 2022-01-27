using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class savedgameUC : UserControl
    {
        public savedgameUC()
        {
            InitializeComponent();
        }

        private void playersbackbtn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC savedback = new HomeUC();
                savedback.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(savedback);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
        }


        private void slotonebtn_Click(object sender, EventArgs e)
        {
            playsaved();
        }

        private void slottwobtn_Click(object sender, EventArgs e)
        {
            playsaved();
        }

        private void slotthreebtn_Click(object sender, EventArgs e)
        {
            playsaved();
        }

        private void slotfourbtn_Click(object sender, EventArgs e)
        {
            playsaved();
        }

        private void slotfivebtn_Click(object sender, EventArgs e)
        {
            playsaved();
        }

        //subroutine for opening saved slot
        static void playsaved()
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("gamepageUC"))
            {
                gamepageUC savedgame = new gamepageUC();
                savedgame.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(savedgame);
            }
            MainForm.Instance.pagecontainer.Controls["gamepageUC"].BringToFront();
        }

    }
}
