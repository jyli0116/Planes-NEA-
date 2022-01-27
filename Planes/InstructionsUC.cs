using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class InstructionsUC : UserControl
    {
        public InstructionsUC()
        {
            InitializeComponent();
        }

        private void instructionbackbtn_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC instructionsback = new HomeUC();
                instructionsback.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(instructionsback);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
        }
    }
}
