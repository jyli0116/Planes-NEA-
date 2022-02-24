using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    //Homepage to the game system
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
        }

        //starts a new game - directs user to page to choose number of player
        private void startgamebtn_Click(object sender, EventArgs e)
        {
            //opens no of players UC
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("noPlayersUC"))
            {
                noPlayersUC startgame = new noPlayersUC();
                startgame.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(startgame);
            }
            MainForm.Instance.pagecontainer.Controls["noPlayersUC"].BringToFront();
        }

        //opens page with instructions to the game
        private void instructionsbtn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("InstructionsUC"))
            {
                InstructionsUC instructions = new InstructionsUC();
                instructions.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(instructions);
            }
            MainForm.Instance.pagecontainer.Controls["InstructionsUC"].BringToFront();
        }

        private void savedgamebtn_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("SavedUC"))
            {
                SavedUC resumegame= new SavedUC();
                resumegame.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(resumegame);
            }
            MainForm.Instance.pagecontainer.Controls["SavedUC"].BringToFront();
        }
    }
}
