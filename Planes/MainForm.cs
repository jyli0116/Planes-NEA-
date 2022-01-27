using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planes
{
    public partial class MainForm : Form
    {
        //initial instance on main form
        static MainForm mainpage;
        public static MainForm Instance
        {
            get
            {
                if(mainpage == null)
                {
                    mainpage = new MainForm();
                }
                return mainpage;
            }
        }

        public Panel pagecontainer
        {
            get { return panelcontainer; }
            set { panelcontainer = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        //open the home page when the program loads
        private void Form1_Load(object sender, EventArgs e)
        {
            mainpage = this;

            HomeUC homepage = new HomeUC();
            homepage.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(homepage);
        }
    }

}
