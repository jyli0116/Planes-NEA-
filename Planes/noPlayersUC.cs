using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class noPlayersUC : UserControl
    {
        public static noPlayersUC noplayersscreen;
        public int noplayers = 0;

        public noPlayersUC()
        {
            noplayersscreen = this;
            InitializeComponent();
        }

        //return from number of players page back to the home page
        private void playersbackbtn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC playersback = new HomeUC();
                playersback.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(playersback);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
        }

        private void p2btn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP1UC"))
            {
                setP1UC p1board = new setP1UC();
                p1board.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(p1board);
            }
            MainForm.Instance.pagecontainer.Controls["setP1UC"].BringToFront();
            noplayers = 2; 
        }

        private void p1btn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("difficultyUC"))
            {
                difficultyUC singledifficulty = new difficultyUC();
                singledifficulty.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(singledifficulty);
            }
            MainForm.Instance.pagecontainer.Controls["difficultyUC"].BringToFront();
            noplayers = 1;
        }
    }
}
