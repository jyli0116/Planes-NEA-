using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    public partial class gamepageUC : UserControl
    {
        private Button[,] p1Grid;
        private Button[,] p2Grid;
        const int SQUARE_GRID_SIZE = 10;
        const int cols = SQUARE_GRID_SIZE;
        const int rows = SQUARE_GRID_SIZE;
        const int gridWidth = 300;
        const int gridHeight = 300;
        const int tileWidth = gridWidth / cols;
        const int tileHeight = gridHeight / rows;
        const int gridTop = 200;
        const int gridLeft = 300;
        Grid p2planegrid;


        public gamepageUC()
        {
            InitializeComponent();
            setP2UC setP2 = setP2UC.setP2screen;
            p2planegrid = setP2.p2planegrid;
        }

        

        private void CreateGrids(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            p1Grid = new Button[rows, cols];
            p2Grid = new Button[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    p1Grid[r, c] = new Button()
                    {
                        Size = new Size(tileWidth, tileHeight),
                        Location = new Point(tileWidth * c + (gridLeft-200), tileHeight * r + gridTop),
                        Font = new Font("Arial", gridWidth / cols / 3),

                    };
                    p1Grid[r, c].MouseHover += new EventHandler(p1GridHover);
                    p1Grid[r, c].MouseLeave += new EventHandler(p1GridLeave);
                    Controls.Add(p1Grid[r, c]);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    p2Grid[r, c] = new Button()
                    {
                        Size = new Size(tileWidth, tileHeight),
                        Location = new Point(tileWidth * c + (gridLeft + 200), tileHeight * r + gridTop),
                        Font = new Font("Arial", gridWidth / cols / 3),

                    };
                    p2Grid[r, c].MouseHover += new EventHandler(p2GridHover);
                    p2Grid[r, c].MouseLeave += new EventHandler(p2GridLeave);
                    Controls.Add(p2Grid[r, c]);
                }
            }

        }

        

        private void p1GridHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightPink;
        }

        private void p1GridLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void p2GridHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightPink;
        }

        private void p2GridLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        //allows user to return to home page from game page
        private void exitgamebtn_Click(object sender, EventArgs e)
        {
            Form savedform = new savedform();
            savedform.Show();
        }

        private void savegamebtn_Click(object sender, EventArgs e)
        {
            //save game ?
        }

        private void gamepageUC_Load(object sender, EventArgs e)
        {
            CreateGrids(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
        }
    }
}
