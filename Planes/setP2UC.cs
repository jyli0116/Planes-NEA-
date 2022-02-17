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
        // set up necessary variables to create grid later on
        public static setP2UC setP2screen;
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
        public Grid p2planegrid;
        int planescount = 0;

        //on load, creats instance of UC and creates a grid to store p2 planes
        public setP2UC()
        {
            setP2screen = this;
            InitializeComponent();

            p2planegrid = new Grid();
        }


        //creates a grid of buttons and a grid that stores the status of the squares underneath
        //adds three event handers for mousehover, mouseleave, mouseclick, then adds control to uc
        private void CreateGrid(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    p2planegrid.playgrid[r, c] = 0;
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

        //checks if the squares for a plane with head in position and an orientation can be put there, or if there are already plane parts there
        private bool planeenabled(int r, int c)
        {
            if(orientation == 0)
            {
                if (setupGrid[r + 1, c - 2].Enabled == true && setupGrid[r + 1, c - 1].Enabled == true && setupGrid[r + 1, c].Enabled == true && setupGrid[r + 1, c + 1].Enabled == true && setupGrid[r + 1, c + 2].Enabled == true && setupGrid[r + 2, c].Enabled == true && setupGrid[r + 3, c - 1].Enabled == true && setupGrid[r + 3, c].Enabled == true && setupGrid[r + 3, c + 1].Enabled == true)
                {
                    return true;
                }
            }
            else if(orientation == 1)
            {
                if (setupGrid[r + 2, c + 1].Enabled == true && setupGrid[r + 1, c + 1].Enabled == true && setupGrid[r, c + 1].Enabled == true && setupGrid[r - 1, c + 1].Enabled == true && setupGrid[r - 2, c + 1].Enabled == true && setupGrid[r, c + 2].Enabled == true && setupGrid[r, c + 3].Enabled == true && setupGrid[r - 1, c + 3].Enabled == true && setupGrid[r + 1, c + 3].Enabled == true)
                {
                    return true;
                }
            }
            else if(orientation == 2)
            {
                if (setupGrid[r - 1, c + 2].Enabled == true && setupGrid[r - 1, c + 1].Enabled == true && setupGrid[r - 1, c].Enabled == true && setupGrid[r - 1, c - 1].Enabled == true && setupGrid[r - 1, c - 2].Enabled == true && setupGrid[r - 2, c].Enabled == true && setupGrid[r - 3, c + 1].Enabled == true && setupGrid[r - 3, c].Enabled == true && setupGrid[r - 3, c - 1].Enabled == true)
                {
                    return true;
                }
            }
            else
            {
                if (setupGrid[r - 2, c - 1].Enabled == true && setupGrid[r - 1, c - 1].Enabled == true && setupGrid[r, c - 1].Enabled == true && setupGrid[r + 1, c - 1].Enabled == true && setupGrid[r + 2, c - 1].Enabled == true && setupGrid[r, c - 2].Enabled == true && setupGrid[r - 1, c - 3].Enabled == true && setupGrid[r, c - 3].Enabled == true && setupGrid[r + 1, c - 3].Enabled == true)
                {
                    return true;
                }
            }
            return false;
        }

        //when a button is clicked on the grid - if it is in range, the plane will be put in the orientation with that plane head
        private void setupGridClick(object sender, EventArgs e)
        {


            if(inrange == true)
            {
                planehover = Convert.ToString((sender as Button).Tag);
                r = Convert.ToInt32(planehover.Substring(0, 1));
                c = Convert.ToInt32(planehover.Substring(2, 1));
                planescount++;
                p2planegrid.AddPlane(r, c, orientation);

                if (orientation == 0)
                {
                    p2planegrid.playgrid[r, c] = 2;
                    setupGrid[r, c].Enabled = false;
                    p2planegrid.playgrid[r + 1, c - 2] = 1;
                    setupGrid[r + 1, c - 2].Enabled = false;
                    p2planegrid.playgrid[r + 1, c - 1] = 1;
                    setupGrid[r + 1, c - 1].Enabled = false;
                    p2planegrid.playgrid[r + 1, c] = 1;
                    setupGrid[r + 1, c].Enabled = false;
                    p2planegrid.playgrid[r + 1, c + 1] = 1;
                    setupGrid[r + 1, c + 1].Enabled = false;
                    p2planegrid.playgrid[r + 1, c + 2] = 1;
                    setupGrid[r + 1, c + 2].Enabled = false;
                    p2planegrid.playgrid[r + 2, c] = 1;
                    setupGrid[r + 2, c].Enabled = false;
                    p2planegrid.playgrid[r + 3, c - 1] = 1;
                    setupGrid[r + 3, c - 1].Enabled = false;
                    p2planegrid.playgrid[r + 3, c] = 1;
                    setupGrid[r + 3, c].Enabled = false;
                    p2planegrid.playgrid[r + 3, c + 1] = 1;
                    setupGrid[r + 3, c + 1].Enabled = false;


                }
                else if (orientation == 1)
                {
                    p2planegrid.playgrid[r, c] = 2;
                    setupGrid[r, c].Enabled = false;
                    p2planegrid.playgrid[r + 2, c + 1] = 1;
                    setupGrid[r + 2, c + 1].Enabled = false;
                    p2planegrid.playgrid[r + 1, c + 1] = 1;
                    setupGrid[r + 1, c + 1].Enabled = false;
                    p2planegrid.playgrid[r, c + 1] = 1;
                    setupGrid[r, c + 1].Enabled = false;
                    p2planegrid.playgrid[r - 1, c + 1] = 1;
                    setupGrid[r - 1, c + 1].Enabled = false;
                    p2planegrid.playgrid[r - 2, c + 1] = 1;
                    setupGrid[r - 2, c + 1].Enabled = false;
                    p2planegrid.playgrid[r, c + 2] = 1;
                    setupGrid[r, c + 2].Enabled = false;
                    p2planegrid.playgrid[r, c + 3] = 1;
                    setupGrid[r, c + 3].Enabled = false;
                    p2planegrid.playgrid[r - 1, c + 3] = 1;
                    setupGrid[r - 1, c + 3].Enabled = false;
                    p2planegrid.playgrid[r + 1, c + 3] = 1;
                    setupGrid[r + 1, c + 3].Enabled = false;
                }
                else if (orientation == 2)
                {
                    p2planegrid.playgrid[r, c] = 2;
                    setupGrid[r, c].Enabled = false;
                    p2planegrid.playgrid[r - 1, c + 2] = 1;
                    setupGrid[r - 1, c + 2].Enabled = false;
                    p2planegrid.playgrid[r - 1, c + 1] = 1;
                    setupGrid[r - 1, c + 1].Enabled = false;
                    p2planegrid.playgrid[r - 1, c] = 1;
                    setupGrid[r - 1, c].Enabled = false;
                    p2planegrid.playgrid[r - 1, c - 1] = 1;
                    setupGrid[r - 1, c - 1].Enabled = false;
                    p2planegrid.playgrid[r - 1, c - 2] = 1;
                    setupGrid[r - 1, c - 2].Enabled = false;
                    p2planegrid.playgrid[r - 2, c] = 1;
                    setupGrid[r - 2, c].Enabled = false;
                    p2planegrid.playgrid[r - 3, c + 1] = 1;
                    setupGrid[r - 3, c + 1].Enabled = false;
                    p2planegrid.playgrid[r - 3, c] = 1;
                    setupGrid[r - 3, c].Enabled = false;
                    p2planegrid.playgrid[r - 3, c - 1] = 1;
                    setupGrid[r - 3, c - 1].Enabled = false;

                }
                else
                {
                    p2planegrid.playgrid[r, c] = 2;
                    setupGrid[r, c].Enabled = false;
                    p2planegrid.playgrid[r - 2, c - 1] = 1;
                    setupGrid[r - 2, c - 1].Enabled = false;
                    p2planegrid.playgrid[r - 1, c - 1] = 1;
                    setupGrid[r - 1, c - 1].Enabled = false;
                    p2planegrid.playgrid[r, c - 1] = 1;
                    setupGrid[r, c - 1].Enabled = false;
                    p2planegrid.playgrid[r + 1, c - 1] = 1;
                    setupGrid[r + 1, c - 1].Enabled = false;
                    p2planegrid.playgrid[r + 2, c - 1] = 1;
                    setupGrid[r + 2, c - 1].Enabled = false;
                    p2planegrid.playgrid[r, c - 2] = 1;
                    setupGrid[r, c - 2].Enabled = false;
                    p2planegrid.playgrid[r - 1, c - 3] = 1;
                    setupGrid[r - 1, c - 3].Enabled = false;
                    p2planegrid.playgrid[r, c - 3] = 1;
                    setupGrid[r, c - 3].Enabled = false;
                    p2planegrid.playgrid[r + 1, c - 3] = 1;
                    setupGrid[r + 1, c - 3].Enabled = false;
                }
            }
            
        }

        //when mouse hovers over a button, if there are less than three planes on the grid, then the plane will appear on the grid
        private void setupGridHover(object sender, EventArgs e)
        {
            if (planescount < 3)
            {
                if (((Button)sender).Enabled == true)
                {
                    planehover = Convert.ToString((sender as Button).Tag);
                    r = Convert.ToInt32(planehover.Substring(0, 1));
                    c = Convert.ToInt32(planehover.Substring(2, 1));


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
                        //((Button)sender).Enabled = false;
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

        //click button to change orientation of the planes placed
        private void turnbtn_Click(object sender, EventArgs e)
        {
            orientation = (orientation + 1) % 4;
        }

        //when the mouse leaves a button, if a plane hasn't already been placed there, the button turns to normal
        private void setupGridLeave(object sender, EventArgs e)
        {
            if(p2planegrid.playgrid[r, c] == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        setupGrid[i, j].BackColor = Color.Transparent;
                    }
                }
            ((Button)sender).Enabled = true;
            }           
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
            if(planescount == 3)
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

                if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("gamepageUC"))
                {
                    gamepageUC p2confirm = new gamepageUC();
                    p2confirm.Dock = DockStyle.Fill;
                    MainForm.Instance.pagecontainer.Controls.Add(p2confirm);
                }
                MainForm.Instance.pagecontainer.Controls["gamepageUC"].BringToFront();
            }
            else
            {
                p2currentlbl.Text = "You have not yet placed 3 planes on your grid";
            }
        }

        private void setP2UC_Load(object sender, EventArgs e)
        {
            CreateGrid(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
        }


    }
}
