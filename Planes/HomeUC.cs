using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
        }

        private void startgamebtn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("noPlayersUC"))
            {
                noPlayersUC startgame = new noPlayersUC();
                startgame.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(startgame);
            }
            MainForm.Instance.pagecontainer.Controls["noPlayersUC"].BringToFront();
        }

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

    }
}
