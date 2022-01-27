using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class setP2UC : UserControl
    {
        private Button[,] setupGrid;
        const int SQUARE_GRID_SIZE = 10;
        const int cols = SQUARE_GRID_SIZE;
        const int rows = SQUARE_GRID_SIZE;
        const int gridWidth = 300;
        const int gridHeight = 300;
        const int tileWidth = gridWidth / cols;
        const int tileHeight = gridHeight / rows;
        const int gridTop = 200;
        const int gridLeft = 300;

        public setP2UC()
        {
            InitializeComponent();
        }

        private void CreateGrid(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            P2backbtn.Text = "Go";
            setupGrid = new Button[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    setupGrid[r, c] = new Button()
                    {
                        Size = new Size(tileWidth, tileHeight),
                        Location = new Point(tileWidth * c + gridLeft, tileHeight * r + gridTop),
                        Font = new Font("Arial", gridWidth / cols / 3),

                    };
                    setupGrid[r, c].MouseHover += new EventHandler(setupGridHover);
                    setupGrid[r, c].MouseLeave += new EventHandler(setupGridLeave);
                    Controls.Add(setupGrid[r, c]);
                }
            }

        }

        private void setupGridHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightPink;
        }

        private void setupGridLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        //back button set up p2 page to no of players page
        private void P2backbtn_Click(object sender, EventArgs e)
        {
            //brings up pop up window to confirm if should exit set up page
            Form setupconfirm = new setupconfirm();
            setupconfirm.Show();
        }

        private void P2confirmbtn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("gamepageUC"))
            {
                gamepageUC p2confirm = new gamepageUC();
                p2confirm.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(p2confirm);
            }
            MainForm.Instance.pagecontainer.Controls["gamepageUC"].BringToFront();
        }

        private void setP2UC_Load(object sender, EventArgs e)
        {
            CreateGrid(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
        }
    }
}
