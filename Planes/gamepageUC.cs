﻿using System;
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
        //grids of buttons users interact with
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
        //the grids set up beforehand
        Grid p2planegrid;
        Grid p1planegrid;
        //the grids that show what is displayed on the buttons
        private int[,] p1refgrid = new int[10, 10];
        private int[,] p2refgrid = new int[10, 10];
        private int playerturn;
        private int p1headno = 0;
        private int p2headno = 0;
        private int nousers;
        private int difficulty;
        Random rnd = new Random();


        public gamepageUC()
        {
            InitializeComponent();
            setP2UC setP2 = setP2UC.setP2screen;
            p2planegrid = setP2.p2planegrid;
            noPlayersUC noplayers = noPlayersUC.noplayersscreen;
            nousers = noplayers.noplayers;
            if (nousers == 2)
            {
                setP1UC setP1 = setP1UC.setP1screen;
                p1planegrid = setP1.p1planegrid;
                playerturn = 1;
            }
            else
            {
                playerturn = 0;
                p1planegrid = new Grid();
                p1planegrid.CreateGrid();
                difficultyUC difficultyscreen = difficultyUC.difficultyscreen;
                difficulty = difficultyscreen.difficultylvl;
            }
        }

        private void GamePlay()
        {
            if (nousers == 1 && playerturn == 1)
            {
                if (difficulty == 0)
                {
                    EasyMove();
                }
                else if (difficulty == 1)
                {
                    MediumMove();
                }
                else if (difficulty == 2)
                {
                    HardMove();
                }
            }
        }

        private void EasyMove()
        {

        }

        private void MediumMove()
        {

        }

        private void HardMove()
        {

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

        private void GridColour()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (p2refgrid[i, j] == 2)
                    {
                        p2Grid[i, j].BackColor = Color.Red;
                    }
                    else if (p2refgrid[i, j] == 1)
                    {
                        p2Grid[i, j].BackColor = Color.Blue;
                    }
                    else if (p2refgrid[i, j] == -1)
                    {
                        p2Grid[i, j].BackColor = Color.DarkGray;
                    }

                    if (p1refgrid[i, j] == 2)
                    {
                        p1Grid[i, j].BackColor = Color.Red;
                    }
                    else if (p1refgrid[i, j] == 1)
                    {
                        p1Grid[i, j].BackColor = Color.Blue;
                    }
                    else if (p1refgrid[i, j] == -1)
                    {
                        p1Grid[i, j].BackColor = Color.DarkGray;
                    }
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
            if (playerturn == 1 && nousers == 2)
            {
                string gridindex = Convert.ToString((sender as Button).Tag);
                int r = Convert.ToInt32(gridindex.Substring(0, 1));
                int c = Convert.ToInt32(gridindex.Substring(2, 1));
                if (p1refgrid[r, c] == 0)
                {
                    if (p1planegrid.playgrid[r, c] == 0)
                    {
                        p1refgrid[r, c] = -1;
                    }
                    else
                    {
                        p1refgrid[r, c] = p1planegrid.playgrid[r, c];
                    }
                    if (p1refgrid[r, c] == 2)
                    {
                        p1headno++;
                    }
                    GridColour();
                    if (CheckWin(p1headno))
                    {
                        playerturn = 3;
                        MessageBox.Show("Player 1 Won :)");
                    }

                    playerturn = 0;
                }
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
                    if (p2planegrid.playgrid[r, c] == 0)
                    {
                        p2refgrid[r, c] = -1;
                    }
                    else
                    {
                        p2refgrid[r, c] = p2planegrid.playgrid[r, c];
                    }                    
                    if (p2refgrid[r, c] == 2)
                    {
                        p2headno++;
                    }

                    GridColour();

                    if (CheckWin(p2headno))
                    {
                        playerturn = 3;
                        MessageBox.Show("Player 2 Won :)");
                    }

                    playerturn = 1;

                    if (nousers == 1)
                    {
                        GamePlay();
                    }
                }

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
