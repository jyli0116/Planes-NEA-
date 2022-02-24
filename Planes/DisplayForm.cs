using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planes
{
    //Form used for displaying the grids the players are playing with
    public partial class DisplayForm : Form
    {
        private Button[,] p1Grid;
        private Button[,] p2Grid;
        private Grid p2planegrid;
        private Grid p1planegrid;
        const int SQUARE_GRID_SIZE = 10;
        const int cols = SQUARE_GRID_SIZE;
        const int rows = SQUARE_GRID_SIZE;
        const int gridWidth = 300;
        const int gridHeight = 300;
        const int tileWidth = gridWidth / cols;
        const int tileHeight = gridHeight / rows;
        const int gridTop = 200;
        const int gridLeft = 300;

        public DisplayForm()
        {
            //accesses variables from game page
            gamepageUC gamescreen = gamepageUC.gamepagescreen;
            p2planegrid = gamescreen.p2planegrid;
            p1planegrid = gamescreen.p1planegrid;
            InitializeComponent();
        }

        //adjusts the colours of the grid of buttons depending on whats on the grid
        private void GridColour()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (p2planegrid.playgrid[i, j] == 2)
                    {
                        p2Grid[i, j].BackColor = Color.Red;
                    }
                    else if (p2planegrid.playgrid[i, j] == 1)
                    {
                        p2Grid[i, j].BackColor = Color.Blue;
                    }
                    else if (p2planegrid.playgrid[i, j] == 0)
                    {
                        p2Grid[i, j].BackColor = Color.DarkGray;
                    }

                    if (p1planegrid.playgrid[i, j] == 2)
                    {
                        p1Grid[i, j].BackColor = Color.Red;
                    }
                    else if (p1planegrid.playgrid[i, j] == 1)
                    {
                        p1Grid[i, j].BackColor = Color.Blue;
                    }
                    else if (p1planegrid.playgrid[i, j] == 0)
                    {
                        p1Grid[i, j].BackColor = Color.DarkGray;
                    }
                }
            }
        }

        //when the form is loaded, two grids of buttons created to display the boards playing against
        private void DisplayForm_Load(object sender, EventArgs e)
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
                        Location = new Point(tileWidth * c + (gridLeft - 200), tileHeight * r + gridTop),
                        Font = new Font("Arial", gridWidth / cols / 3),
                        Tag = Convert.ToString(r) + " " + Convert.ToString(c),

                    };
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
                        Tag = Convert.ToString(r) + " " + Convert.ToString(c),

                    };
                    Controls.Add(p2Grid[r, c]);
                }
            }

            GridColour();
        }
    }
}
