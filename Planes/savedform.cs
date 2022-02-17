using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class savedform : Form
    {
        Grid p2planegrid;

        public savedform()
        {
            InitializeComponent();
            setP2UC setP2 = setP2UC.setP2screen;
            p2planegrid = setP2.p2planegrid;
        }

        private void saveformbtn_Click(object sender, EventArgs e)
        {
            //add save game thing
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    p2planegrid.playgrid[i, j] = 0;
                }
            }
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC returnhome = new HomeUC();
                returnhome.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(returnhome);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
            this.Close();
        }

        private void continueexitbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    p2planegrid.playgrid[i, j] = 0;
                }
            }
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC returnhome = new HomeUC();
                returnhome.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(returnhome);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
            this.Close();
        }
    }
}
