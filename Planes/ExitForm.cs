using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class ExitForm : Form
    {
        private Grid p2planegrid;
        private Grid p1planegrid;
        private int nousers;

        public ExitForm()
        {
            gamepageUC gamescreen = gamepageUC.gamepagescreen;
            p2planegrid = gamescreen.p2planegrid;
            p1planegrid = gamescreen.p1planegrid;
            nousers = gamescreen.nousers;
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    p2planegrid.playgrid[i, j] = 0;
                    p1planegrid.playgrid[i, j] = 0;
                }
            }
            /*if (nousers == 2)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        p1planegrid.playgrid[i, j] = 0;
                    }
                }
            }*/
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC returnhome = new HomeUC();
                returnhome.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(returnhome);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
            MainForm.Instance.pagecontainer.Controls.RemoveByKey("gamepageUC");
            MainForm.Instance.pagecontainer.Controls.RemoveByKey("setP2UC");
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP1UC"))
            {
                MainForm.Instance.pagecontainer.Controls.RemoveByKey("setP1UC");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
