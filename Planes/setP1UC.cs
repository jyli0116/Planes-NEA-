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
        public static setP1UC setP1screen;
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
        private int orientation = 0;
        private bool inrange = true;
        string planehover;
        int r = 0;
        int c = 0;
        public Grid p1planegrid;
        int planescount = 0;

        public setP1UC()
        {
            setP1screen = this;
            InitializeComponent();
            p1planegrid = new Grid();
        }

        // creates grid of buttons with events
        private void CreateGrid(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    p1planegrid.playgrid[r, c] = 0;
                }
            }

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
                        Tag = Convert.ToString(r) + " " + Convert.ToString(c),

                    };
                    setupGrid[r, c].MouseHover += new EventHandler(setupGridHover);
                    setupGrid[r, c].MouseLeave += new EventHandler(setupGridLeave);
                    setupGrid[r, c].MouseClick += new MouseEventHandler(setupGridClick);
                    Controls.Add(setupGrid[r, c]);
                }
            }

        }

        // checks is space is free to place plane
        private bool planeenabled(int r, int c)
        {
            if (orientation == 0)
            {
                if (p1planegrid.playgrid[r + 1, c - 2] == 0 && p1planegrid.playgrid[r + 1, c - 1] == 0 && p1planegrid.playgrid[r + 1, c] == 0 && p1planegrid.playgrid[r + 1, c + 1] == 0 && p1planegrid.playgrid[r + 1, c + 2] == 0 && p1planegrid.playgrid[r + 2, c] == 0 && p1planegrid.playgrid[r + 3, c - 1] == 0 && p1planegrid.playgrid[r + 3, c] == 0 && p1planegrid.playgrid[r + 3, c + 1] == 0)
                {
                    return true;
                }
            }
            else if (orientation == 1)
            {
                if (p1planegrid.playgrid[r + 2, c + 1] == 0 && p1planegrid.playgrid[r + 1, c + 1] == 0 && p1planegrid.playgrid[r, c + 1] == 0 && p1planegrid.playgrid[r - 1, c + 1] == 0 && p1planegrid.playgrid[r - 2, c + 1] == 0 && p1planegrid.playgrid[r, c + 2] == 0 && p1planegrid.playgrid[r, c + 3] == 0 && p1planegrid.playgrid[r - 1, c + 3] == 0 && p1planegrid.playgrid[r + 1, c + 3] == 0)
                {
                    return true;
                }
            }
            else if (orientation == 2)
            {
                if (p1planegrid.playgrid[r - 1, c + 2] == 0 && p1planegrid.playgrid[r - 1, c + 1] == 0 && p1planegrid.playgrid[r - 1, c] == 0 && p1planegrid.playgrid[r - 1, c - 1] == 0 && p1planegrid.playgrid[r - 1, c - 2] == 0 && p1planegrid.playgrid[r - 2, c] == 0 && p1planegrid.playgrid[r - 3, c + 1] == 0 && p1planegrid.playgrid[r - 3, c] == 0 && p1planegrid.playgrid[r - 3, c - 1] == 0)
                {
                    return true;
                }
            }
            else
            {
                if (p1planegrid.playgrid[r - 2, c - 1] == 0 && p1planegrid.playgrid[r - 1, c - 1] == 0 && p1planegrid.playgrid[r, c - 1] == 0 && p1planegrid.playgrid[r + 1, c - 1] == 0 && p1planegrid.playgrid[r + 2, c - 1] == 0 && p1planegrid.playgrid[r, c - 2] == 0 && p1planegrid.playgrid[r - 1, c - 3] == 0 && p1planegrid.playgrid[r, c - 3] == 0 && p1planegrid.playgrid[r + 1, c - 3] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // changes the colour of grid according to reference array
        private void GridColour()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (p1planegrid.playgrid[i, j] == 2)
                    {
                        setupGrid[i, j].BackColor = Color.Red;
                    }
                    else if (p1planegrid.playgrid[i, j] == 1)
                    {
                        setupGrid[i, j].BackColor = Color.Blue;
                    }
                    else if (p1planegrid.playgrid[i, j] == 0)
                    {
                        setupGrid[i, j].BackColor = Color.Transparent;
                    }
                }
            }
        }

        // when grid cutton clicked, check if plane can be placed
        // if so, place plane
        private void setupGridClick(object sender, EventArgs e)
        {
            if (inrange == true)
            {
                planehover = Convert.ToString((sender as Button).Tag);
                r = Convert.ToInt32(planehover.Substring(0, 1));
                c = Convert.ToInt32(planehover.Substring(2, 1));
                planescount++;
                p1planegrid.AddPlane(r, c, orientation);

                if (orientation == 0)
                {
                    p1planegrid.playgrid[r, c] = 2;
                    p1planegrid.playgrid[r + 1, c - 2] = 1;
                    p1planegrid.playgrid[r + 1, c - 1] = 1;
                    p1planegrid.playgrid[r + 1, c] = 1;
                    p1planegrid.playgrid[r + 1, c + 1] = 1;
                    p1planegrid.playgrid[r + 1, c + 2] = 1;
                    p1planegrid.playgrid[r + 2, c] = 1;
                    p1planegrid.playgrid[r + 3, c - 1] = 1;
                    p1planegrid.playgrid[r + 3, c] = 1;
                    p1planegrid.playgrid[r + 3, c + 1] = 1;
                }
                else if (orientation == 1)
                {
                    p1planegrid.playgrid[r, c] = 2;
                    p1planegrid.playgrid[r + 2, c + 1] = 1;
                    p1planegrid.playgrid[r + 1, c + 1] = 1;
                    p1planegrid.playgrid[r, c + 1] = 1;
                    p1planegrid.playgrid[r - 1, c + 1] = 1;
                    p1planegrid.playgrid[r - 2, c + 1] = 1;
                    p1planegrid.playgrid[r, c + 2] = 1;
                    p1planegrid.playgrid[r, c + 3] = 1;
                    p1planegrid.playgrid[r - 1, c + 3] = 1;
                    p1planegrid.playgrid[r + 1, c + 3] = 1;
                }
                else if (orientation == 2)
                {
                    p1planegrid.playgrid[r, c] = 2;
                    p1planegrid.playgrid[r - 1, c + 2] = 1;
                    p1planegrid.playgrid[r - 1, c + 1] = 1;
                    p1planegrid.playgrid[r - 1, c] = 1;
                    p1planegrid.playgrid[r - 1, c - 1] = 1;
                    p1planegrid.playgrid[r - 1, c - 2] = 1;
                    p1planegrid.playgrid[r - 2, c] = 1;
                    p1planegrid.playgrid[r - 3, c + 1] = 1;
                    p1planegrid.playgrid[r - 3, c] = 1;
                    p1planegrid.playgrid[r - 3, c - 1] = 1;
                }
                else
                {
                    p1planegrid.playgrid[r, c] = 2;
                    p1planegrid.playgrid[r - 2, c - 1] = 1;
                    p1planegrid.playgrid[r - 1, c - 1] = 1;
                    p1planegrid.playgrid[r, c - 1] = 1;
                    p1planegrid.playgrid[r + 1, c - 1] = 1;
                    p1planegrid.playgrid[r + 2, c - 1] = 1;
                    p1planegrid.playgrid[r, c - 2] = 1;
                    p1planegrid.playgrid[r - 1, c - 3] = 1;
                    p1planegrid.playgrid[r, c - 3] = 1;
                    p1planegrid.playgrid[r + 1, c - 3] = 1;
                }
                GridColour();
                inrange = false;
            }

        }

        // displays plane position when mouse hovers over grid if possible
        private void setupGridHover(object sender, EventArgs e)
        {
            planehover = Convert.ToString((sender as Button).Tag);
            r = Convert.ToInt32(planehover.Substring(0, 1));
            c = Convert.ToInt32(planehover.Substring(2, 1));

            if(p1planegrid.playgrid[r, c] == 0)
            {
                if (planescount < 3)
                {
                    if (((Button)sender).Enabled == true)
                    {

                        //which is it is possible to put a plane in that position with that orientation
                        if (orientation == 0)
                        {
                            if (c + 2 <= 9 && c - 2 >= 0 && r + 3 <= 9)
                            {

                                inrange = planeenabled(r, c);
                            }
                            else
                            {
                                inrange = false;
                            }
                        }
                        else if (orientation == 1)
                        {
                            if (r + 2 <= 9 && r - 2 >= 0 && c + 3 <= 9)
                            {
                                inrange = planeenabled(r, c);
                            }
                            else
                            {
                                inrange = false;
                            }
                        }
                        else if (orientation == 2)
                        {
                            if (c + 2 <= 9 && c - 2 >= 0 && r - 3 >= 0)
                            {
                                inrange = planeenabled(r, c);
                            }
                            else
                            {
                                inrange = false;
                            }
                        }
                        else
                        {
                            if (r + 2 <= 9 && r - 2 >= 0 && c - 3 >= 0)
                            {
                                inrange = planeenabled(r, c);
                            }
                            else
                            {
                                inrange = false;
                            }
                        }

                        //if its not in range, then cannot click, else, the plane is displayed
                        if (inrange == false)
                        {
                            ((Button)sender).BackColor = Color.DarkGray;
                        }
                        else
                        {
                            if (orientation == 0)
                            {
                                setupGrid[r, c].BackColor = Color.Red;
                                setupGrid[r + 1, c - 2].BackColor = Color.Blue;
                                setupGrid[r + 1, c - 1].BackColor = Color.Blue;
                                setupGrid[r + 1, c].BackColor = Color.Blue;
                                setupGrid[r + 1, c + 1].BackColor = Color.Blue;
                                setupGrid[r + 1, c + 2].BackColor = Color.Blue;
                                setupGrid[r + 2, c].BackColor = Color.Blue;
                                setupGrid[r + 3, c - 1].BackColor = Color.Blue;
                                setupGrid[r + 3, c].BackColor = Color.Blue;
                                setupGrid[r + 3, c + 1].BackColor = Color.Blue;
                            }
                            else if (orientation == 1)
                            {
                                setupGrid[r, c].BackColor = Color.Red;
                                setupGrid[r + 2, c + 1].BackColor = Color.Blue;
                                setupGrid[r + 1, c + 1].BackColor = Color.Blue;
                                setupGrid[r, c + 1].BackColor = Color.Blue;
                                setupGrid[r - 1, c + 1].BackColor = Color.Blue;
                                setupGrid[r - 2, c + 1].BackColor = Color.Blue;
                                setupGrid[r, c + 2].BackColor = Color.Blue;
                                setupGrid[r, c + 3].BackColor = Color.Blue;
                                setupGrid[r - 1, c + 3].BackColor = Color.Blue;
                                setupGrid[r + 1, c + 3].BackColor = Color.Blue;

                            }
                            else if (orientation == 2)
                            {
                                setupGrid[r, c].BackColor = Color.Red;
                                setupGrid[r - 1, c + 2].BackColor = Color.Blue;
                                setupGrid[r - 1, c + 1].BackColor = Color.Blue;
                                setupGrid[r - 1, c].BackColor = Color.Blue;
                                setupGrid[r - 1, c - 1].BackColor = Color.Blue;
                                setupGrid[r - 1, c - 2].BackColor = Color.Blue;
                                setupGrid[r - 2, c].BackColor = Color.Blue;
                                setupGrid[r - 3, c + 1].BackColor = Color.Blue;
                                setupGrid[r - 3, c].BackColor = Color.Blue;
                                setupGrid[r - 3, c - 1].BackColor = Color.Blue;
                            }
                            else
                            {
                                setupGrid[r, c].BackColor = Color.Red;
                                setupGrid[r - 2, c - 1].BackColor = Color.Blue;
                                setupGrid[r - 1, c - 1].BackColor = Color.Blue;
                                setupGrid[r, c - 1].BackColor = Color.Blue;
                                setupGrid[r + 1, c - 1].BackColor = Color.Blue;
                                setupGrid[r + 2, c - 1].BackColor = Color.Blue;
                                setupGrid[r, c - 2].BackColor = Color.Blue;
                                setupGrid[r - 1, c - 3].BackColor = Color.Blue;
                                setupGrid[r, c - 3].BackColor = Color.Blue;
                                setupGrid[r + 1, c - 3].BackColor = Color.Blue;
                            }
                        }
                    }
                }
            }

            
        }

        // when the mouse leaves a button, if a plane hasn't already been placed there, the button turns to normal
        private void setupGridLeave(object sender, EventArgs e)
        {
            if (p1planegrid.playgrid[r, c] == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (p1planegrid.playgrid[i, j] == 0)
                        {
                            setupGrid[i, j].BackColor = Color.Transparent;
                        }
                    }
                }
            ((Button)sender).Enabled = true;
            }
        }

        // confirm button set up p1 page to set up p2 page
        private void P1confirmbtn_Click(object sender, EventArgs e)
        {
            if (planescount == 3)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        setupGrid[i, j].Enabled = true;
                        setupGrid[i, j].BackColor = Color.Transparent;
                        setupGrid[i, j].ForeColor = Color.Transparent;
                    }

                }
                inrange = true;
                planehover = "";
                orientation = 0;
                planescount = 0;
                r = 0;
                c = 0;

                if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP2UC"))
                {
                    setP2UC p2board = new setP2UC();
                    p2board.Dock = DockStyle.Fill;
                    MainForm.Instance.pagecontainer.Controls.Add(p2board);

                }
                MainForm.Instance.pagecontainer.Controls["setP2UC"].BringToFront();
            }
            else
            {
                p1currentlbl.Text = "You have not yet placed 3 planes on your grid";
            }
        }

        // back button set up p1 page to no of players page
        private void P1backbtn_Click(object sender, EventArgs e)
        {
            // brings up pop up window to confirm if should exit set up page
            Form setupconfirm = new setupconfirm();
            setupconfirm.Show();
            
        }


        // create grid of buttons when UC first loads
        private void setP1UC_Load(object sender, EventArgs e)
        {
            CreateGrid(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
        }

        // changes orientation of plane
        private void turnbtn_Click(object sender, EventArgs e)
        {
            orientation = (orientation + 1) % 4;
        }

        // auto creates a grid of 3 planes
        private void autobtn_Click(object sender, EventArgs e)
        {
            p1planegrid.CreateGrid();
            planescount = 3;
            GridColour();
        }

        // clears grid of all planes
        private void clearbtn_Click(object sender, EventArgs e)
        {
            planescount = 0;
            p1planegrid.ClearGrid();
            GridColour();
        }

        // removes last plane placed
        private void undobtn_Click(object sender, EventArgs e)
        {
            p1planegrid.RemovePlane();
            planescount--;
            GridColour();
        }
    }
}
