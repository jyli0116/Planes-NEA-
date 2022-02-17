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
        Grid p1planegrid;
        private int[,] p1refgrid = new int[10, 10];
        private int[,] p2refgrid = new int[10, 10];
        private int playerturn = 1;
        private int p1headno = 0;
        private int p2headno = 0;


        public gamepageUC()
        {
            InitializeComponent();
            setP2UC setP2 = setP2UC.setP2screen;
            p2planegrid = setP2.p2planegrid;
            setP1UC setP1 = setP1UC.setP1screen;
            p1planegrid = setP1.p1planegrid;
        }

        private bool CheckWin(int planeheads)
        {
            if(planeheads == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void squarecolours()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //for ech no change col
                }
            }
        }
        

        private void CreateGrids(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            p1Grid = new Button[rows, cols];
            p2Grid = new Button[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    p1refgrid[r, c] = 0;
                    p1Grid[r, c] = new Button()
                    {
                        Size = new Size(tileWidth, tileHeight),
                        Location = new Point(tileWidth * c + (gridLeft-200), tileHeight * r + gridTop),
                        Font = new Font("Arial", gridWidth / cols / 3),
                        Tag = Convert.ToString(r) + " " + Convert.ToString(c),

                    };
                    p1Grid[r, c].MouseHover += new EventHandler(p1GridHover);
                    p1Grid[r, c].MouseLeave += new EventHandler(p1GridLeave);
                    p1Grid[r, c].MouseClick += new MouseEventHandler(p1GridClick);
                    Controls.Add(p1Grid[r, c]);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    p2refgrid[r, c] = 0;
                    p2Grid[r, c] = new Button()
                    {
                        Size = new Size(tileWidth, tileHeight),
                        Location = new Point(tileWidth * c + (gridLeft + 200), tileHeight * r + gridTop),
                        Font = new Font("Arial", gridWidth / cols / 3),
                        Tag = Convert.ToString(r) + " " + Convert.ToString(c),

                    };
                    p2Grid[r, c].MouseHover += new EventHandler(p2GridHover);
                    p2Grid[r, c].MouseLeave += new EventHandler(p2GridLeave);
                    p2Grid[r, c].MouseClick += new MouseEventHandler(p2GridClick);
                    Controls.Add(p2Grid[r, c]);
                }
            }

        }

        
        private void p1GridClick(object sender, EventArgs e)
        {
            if (playerturn == 1)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p1refgrid[r, c] == 0)
                {

                }
                playerturn = 0;
            }

        }

        private void p2GridClick(object sender, EventArgs e)
        {
            if (playerturn == 0)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p2refgrid[r, c] == 0)
                {

                }
                playerturn = 1;
            }

        }

        private void p1GridHover(object sender, EventArgs e)
        {
            if (playerturn == 1)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p1refgrid[r, c] == 0)
                {
                    ((Button)sender).BackColor = Color.LightPink;
                }
            }

        }

        private void p1GridLeave(object sender, EventArgs e)
        {
            if (playerturn == 1)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p1refgrid[r, c] == 0)
                {
                    ((Button)sender).BackColor = Color.Transparent;
                }
            }

        }

        private void p2GridHover(object sender, EventArgs e)
        {
            if (playerturn == 0)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p2refgrid[r, c] == 0)
                {
                    ((Button)sender).BackColor = Color.LightPink;
                }
            }

        }

        private void p2GridLeave(object sender, EventArgs e)
        {
            if (playerturn == 0)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p2refgrid[r, c] == 0)
                {
                    ((Button)sender).BackColor = Color.Transparent;
                }
            }

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
