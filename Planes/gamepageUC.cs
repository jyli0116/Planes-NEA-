using System;
using System.IO;
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
        // grids of buttons users interact with
        public static gamepageUC gamepagescreen;
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
        // the grids set up beforehand
        public Grid p2planegrid;
        public Grid p1planegrid;
        // the grids that show what is displayed on the buttons
        public int[,] p1refgrid = new int[10, 10];
        public int[,] p2refgrid = new int[10, 10];
        public int playerturn;
        public int p1headno = 0;
        public int p2headno = 0;
        public int nousers;
        public int difficulty = 0;
        private Random rnd = new Random();
        private Grid simgrid = new Grid();
        private int[,] computergrid = new int[10, 10];
        private bool win = false;
        private Button showwin;
        private bool lastturn = false;
        private bool saved = false;
        private string filename = "";

        // access grids previously set up and sets no of player/difficulty
        public gamepageUC()
        {
            gamepagescreen = this;
            InitializeComponent();

            if (MainForm.Instance.pagecontainer.Controls.ContainsKey("SavedUC"))
            {
                SavedUC savedscreen = SavedUC.savedscreen;
                saved = savedscreen.saved;
                if (saved == true)
                {
                    p1planegrid = savedscreen.p1planegrid;
                    p2planegrid = savedscreen.p2planegrid;
                    p1refgrid = savedscreen.p1refgrid;
                    p2refgrid = savedscreen.p2refgrid;
                    difficulty = savedscreen.difficulty;
                    nousers = savedscreen.nousers;
                    p1headno = savedscreen.p1headno;
                    p2headno = savedscreen.p2headno;
                    playerturn = savedscreen.playerturn;
                    filename = savedscreen.filename;
                    savedscreen.saved = false;

                }

            }

            if (saved == false)
            {
                setP2UC setP2 = setP2UC.setP2screen;
                p1planegrid = setP2.p2planegrid;
                noPlayersUC noplayers = noPlayersUC.noplayersscreen;
                nousers = noplayers.noplayers;
                if (nousers == 2)
                {
                    p1lbl.Text = "Player 1";
                    p2lbl.Text = "Player 2";
                    statuslbl.Text = "Player 1's Turn";
                    setP1UC setP1 = setP1UC.setP1screen;
                    p2planegrid = setP1.p1planegrid;
                    playerturn = 1;
                }
                else
                {
                    p1lbl.Text = "Computer";
                    p2lbl.Text = "You";
                    playerturn = 0;
                    p2planegrid = new Grid();
                    p2planegrid.CreateGrid();
                    difficultyUC difficultyscreen = difficultyUC.difficultyscreen;
                    difficulty = difficultyscreen.difficultylvl;
                }
            }

            CreateGrids(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
            GridColour();
            //Form displayform = new DisplayForm();
            //displayform.Show();
        }

        // used for computer to make a move
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

        int r;
        int c;
        // computer move for easy difficulty
        // randomly generates next move
        private void EasyMove()
        {

            bool played = false;
            int[,] huntmoves = { {1, 1, 1, 1, 1, 2, 3, 3, 3, -2, -1, 0, 1, 2, 0, -1, 0, 1, 2, 1, 0, -1, -2, 0, 1, 0, -1, -1, -1, -1, -1, -1, -2, -3, -3, -3}, {2, 1, 0, -1, -1, 0, 1, 0, -1, 1, 1, 1, 1, 1, 2, 3, 3, 3, -1, -1, -1, -1, -1, -2, -3, -3, -3, 2, 1, 0, -1, -2, 0, 1, 0, 1} };
            int huntmove = 0;
            

            if (lastturn == false)
            {
                while (played == false)
                {
                    r = rnd.Next(10);
                    c = rnd.Next(10);
                    if (p1refgrid[r, c] == 0)
                    {
                        played = true;
                    }
                }
            }
            else if (lastturn == true)
            {
                while (played == false)
                {
                    huntmove = rnd.Next(36);

                    if ((r + huntmoves[0, huntmove] < 10) && (r + huntmoves[0, huntmove] >= 0) && (c + huntmoves[1, huntmove] < 10) && (c + huntmoves[1, huntmove] >= 0))
                    {
                        if (p1refgrid[r + huntmoves[0, huntmove], c + huntmoves[1, huntmove]] == 0)
                        {
                            played = true;
                        }
                    }


                }

            }

            if (lastturn == false)
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
                else if (p1planegrid.playgrid[r, c] == 1)
                {
                    lastturn = true;
                }
            }
            else
            {
                if (p1planegrid.playgrid[r + huntmoves[0, huntmove], c + huntmoves[1, huntmove]] == 0)
                {
                    p1refgrid[r + huntmoves[0, huntmove], c + huntmoves[1, huntmove]] = -1;
                }
                else
                {
                    p1refgrid[r + huntmoves[0, huntmove], c + huntmoves[1, huntmove]] = p1planegrid.playgrid[r + huntmoves[0, huntmove], c + huntmoves[1, huntmove]];
                }


                if (p1refgrid[r + huntmoves[0, huntmove], c + huntmoves[1, huntmove]] == 2)
                {
                    p1headno++;
                    lastturn = false;
                }

            }



            GridColour();
            saved = false;

            // checks if win, and message appears
            if (CheckWin(p1headno))
            {
                playerturn = 3;
                MessageBox.Show("Player 1 Won :)");
                ShowWinBtn();
                DeleteSlot();
            }
            else
            {
                playerturn = 0;
            }
        }

        // generates computer move for medium difficulty
        // not particularly sophisticated Monte Carlo Sim.
        private void MediumMove()
        {
            int r = 0, c = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    computergrid[i, j] = 0;
                }
            }

            int loopno = 0;

            while (loopno < 100)
            {
                loopno ++;
                simgrid.CreateGrid();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        computergrid[i, j] = computergrid[i, j] + simgrid.playgrid[i, j];
                    }
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (computergrid[i, j] > computergrid[r, c] && p1refgrid[i, j] == 0)
                    {
                        r = i;
                        c = j;
                    }
                }
            }

            if (p1planegrid.playgrid[r, c] == 0)
            {
                p1refgrid[r, c] = -1;
            }
            else
            {
                p1refgrid[r, c] = p1planegrid.playgrid[r, c];
            }

            if (p1refgrid[r,c] == 2)
            {
                p1headno++;
            }
            GridColour();
            saved = false;

            if (CheckWin(p1headno))
            {
                playerturn = 3;
                MessageBox.Show("Player 1 Won :)");
                ShowWinBtn();
                DeleteSlot();
            }
            else
            {
                playerturn = 0;
            }

            

        }

        // generates computer move at hard difficulty
        // More sophisticated Monte Carlo
        // Slow in later moves
        private void HardMove()
        {
            int r = 0, c = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    computergrid[i, j] = 0;
                }
            }

            int loopno = 0;
            bool scrap = false;


            while (loopno < 50)
            {
                simgrid.CreateGrid();
                // grid only passes if it matches current played moves
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (p1refgrid[i, j] != 0)
                        {
                            if (p1refgrid[i, j] == -1)
                            {
                                if (simgrid.playgrid[i, j] != 0)
                                {
                                    scrap = true;
                                }
                            }
                            else
                            {
                                if (p1refgrid[i, j] != simgrid.playgrid[i, j])
                                {
                                    scrap = true;
                                }
                            }

                        }
                    }
                }


                if (scrap == false)
                {
                    loopno++;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            computergrid[i, j] = simgrid.playgrid[i, j];
                        }
                    }
                }
                else
                {
                    scrap = false;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (computergrid[i, j] > computergrid[r, c] && p1refgrid[i, j] == 0)
                    {
                        r = i;
                        c = j;
                    }
                }
            }

            if (p1planegrid.playgrid[r, c] == 0)
            {
                p1refgrid[r, c] = - 1;
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
            saved = false;

            if (CheckWin(p1headno))
            {
                playerturn = 3;
                MessageBox.Show("Player 1 Won :)");
                ShowWinBtn();
                DeleteSlot();
            }
            else
            {
                playerturn = 0;
                statuslbl.Text = "Playing...";
            }
        }

        // checks if player has won yet (hit three plane heads)
        private bool CheckWin(int planeheads)
        {
            if(planeheads == 3)
            {
                win = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DeleteSlot()
        {
            if (!String.IsNullOrWhiteSpace(filename))
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    sw.WriteLine();
                }
            }
        }

        // changes the colour of the grid of buttons in accordance to ref grid
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
        

        //generates and adds the grids of buttons for either player
        private void CreateGrids(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            p1Grid = new Button[rows, cols];
            p2Grid = new Button[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    //p1refgrid[r, c] = 0;
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
                    //p2refgrid[r, c] = 0;
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

        // allows player one to play a move if two player game and is their turn
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
                    saved = false;

                    if (CheckWin(p1headno))
                    {
                        playerturn = 3;
                        MessageBox.Show("Player 1 Won :)");
                        ShowWinBtn();
                        DeleteSlot();
                    }
                    else
                    {
                        statuslbl.Text = "Player 2's Turn";
                        playerturn = 0;
                    }


                }
            }

        }

        // allows player 2 to playa move when their turn
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
                    saved = false;

                    if (CheckWin(p2headno))
                    {
                        playerturn = 3;
                        MessageBox.Show("Player 2 Won :)");
                        ShowWinBtn();
                        DeleteSlot();
                    }


                    if (playerturn != 3)
                    {

                        playerturn = 1;


                        if (nousers == 1)
                        {
                            GamePlay();
                        }
                        else
                        {
                            statuslbl.Text = "Player 1's Turn";
                        }
                    }

                }

            }
        }

        // buttons changes colour when hovered over on P1 turn
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

        // button changes colour when P1 leaves button
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

        // button changes colour when P2 hovers over on their turn
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

        // button returns when P2 leaves 
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
            if (win == true || saved == true)
            {
                saved = false;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        p2planegrid.playgrid[i, j] = 0;
                        p1planegrid.playgrid[i, j] = 0;
                    }
                }
                
                /*if (nousers == 2)
                {

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            p1planegrid.playgrid[i, j] = 0;
                        }
                    }
                }*/
                if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
                {
                    HomeUC returnhome = new HomeUC();
                    returnhome.Dock = DockStyle.Fill;
                    MainForm.Instance.pagecontainer.Controls.Add(returnhome);
                }
                MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
                
                MainForm.Instance.pagecontainer.Controls.RemoveByKey("setP2UC");
                if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("setP1UC"))
                {
                    MainForm.Instance.pagecontainer.Controls.RemoveByKey("setP1UC");
                }
                if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("SavedUC"))
                {
                    MainForm.Instance.pagecontainer.Controls.RemoveByKey("SavedUC");
                }
                MainForm.Instance.pagecontainer.Controls.RemoveByKey("gamepageUC");

            }
            else
            {
                Form exitform = new ExitForm();
                exitform.Show();
            }
            
        }

        // shows button once either player has won
        // allows user to see boards
        private void ShowWinBtn()
        {
            showwin = new Button()
            {
                Size = new Size(150, 50),
                Location = new Point(700, 25),
                Font = new Font("Segoe UI", 9),
                Text = "Show Grid"
            };
            showwin.MouseClick += new MouseEventHandler(showwinClick);
            Controls.Add(showwin);
        }

        // when button clicked, form appears with boards
        private void showwinClick(object sender, EventArgs e)
        {
            Form displayform = new DisplayForm();
            displayform.Show();
        }

        private void gamepageUC_Load(object sender, EventArgs e)
        {           
            GamePlay();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filename))
            {
                Form saveform = new saveform();
                saveform.Show();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            sw.WriteLine(p1planegrid.playgrid[i, j]);
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            sw.WriteLine(p2planegrid.playgrid[i, j]);
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            sw.WriteLine(p1refgrid[i, j]);
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            sw.WriteLine(p2refgrid[i, j]);
                        }
                    }
                    sw.WriteLine(playerturn);
                    sw.WriteLine(p1headno);
                    sw.WriteLine(p2headno);
                    sw.WriteLine(nousers);
                    sw.WriteLine(difficulty);
                }
            }
            saved = true;
        }
    }
}
