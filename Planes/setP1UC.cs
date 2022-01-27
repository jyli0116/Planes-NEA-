using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class setP1UC : UserControl
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

        public setP1UC()
        {
            InitializeComponent();
        }

        private void CreateGrid(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            P1backbtn.Text = "Go";
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

        //confirm button set up p1 page to set up p2 page
        private void P1confirmbtn_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP2UC"))
            {
                setP2UC p2board = new setP2UC();
                p2board.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(p2board);
            }
            MainForm.Instance.pagecontainer.Controls["setP2UC"].BringToFront();
            
            
        }

        //back button set up p1 page to no of players page
        private void P1backbtn_Click(object sender, EventArgs e)
        {
            //brings up pop up window to confirm if should exit set up page
            Form setupconfirm = new setupconfirm();
            setupconfirm.Show();
        }

        private void setP1UC_Load(object sender, EventArgs e)
        {
            CreateGrid(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
        }
    }
}
