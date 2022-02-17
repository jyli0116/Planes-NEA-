using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class difficultyUC : UserControl
    {
        public static difficultyUC difficultyscreen;
        public int difficultylvl;

        public difficultyUC()
        {
            difficultyscreen = this;
            InitializeComponent();
        }

        private void easybtn_Click(object sender, EventArgs e)
        {
            singleBoard();
            difficultylvl = 0;
        }

        private void mediumbtn_Click(object sender, EventArgs e)
        {
            singleBoard();
            difficultylvl = 1;
        }
        private void hardbtn_Click(object sender, EventArgs e)
        {
            singleBoard();
            difficultylvl = 2;
        }

        //subroutine to go to set p2 board
        static void singleBoard()
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP2UC"))
            {
                setP2UC setsingleboard = new setP2UC();
                setsingleboard.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(setsingleboard);
            }
            MainForm.Instance.pagecontainer.Controls["setP2UC"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("noPlayersUC"))
            {
                noPlayersUC difficultyback = new noPlayersUC();
                difficultyback.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(difficultyback);
            }
            MainForm.Instance.pagecontainer.Controls["noPlayersUC"].BringToFront();
        }
    }
}
