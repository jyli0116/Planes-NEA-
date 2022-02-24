using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    //UC for user to choose no of players in game
    public partial class noPlayersUC : UserControl
    {
        //instance of this UC
        public static noPlayersUC noplayersscreen;
        //no of players/users in game
        public int noplayers = 0;

        public noPlayersUC()
        {
            noplayersscreen = this;
            InitializeComponent();
        }

        //return from number of players page back to the home page
        private void playersbackbtn_Click(object sender, EventArgs e)
        {
            //brings home screen to the front
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC playersback = new HomeUC();
                playersback.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(playersback);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
        }

        //play a two player game
        private void p2btn_Click(object sender, EventArgs e)
        {
            //brings set up page P1 forwards, number of players is two
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP1UC"))
            {
                setP1UC p1board = new setP1UC();
                p1board.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(p1board);
            }
            MainForm.Instance.pagecontainer.Controls["setP1UC"].BringToFront();
            noplayers = 2; 
        }

        //play a one player game
        private void p1btn_Click(object sender, EventArgs e)
        {
            // brings up set difficulty page, number of players is one
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
