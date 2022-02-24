using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Planes
{
    public partial class saveform : Form
    {
        private string filename;
        public Grid p2planegrid;
        public Grid p1planegrid;
        public int[,] p1refgrid = new int[10, 10];
        public int[,] p2refgrid = new int[10, 10];
        public int playerturn;
        public int p1headno = 0;
        public int p2headno = 0;
        public int nousers;
        public int difficulty;

        public saveform()
        {
            gamepageUC gamescreen = gamepageUC.gamepagescreen;
            p1planegrid = gamescreen.p1planegrid;
            p2planegrid = gamescreen.p2planegrid;
            p1refgrid = gamescreen.p1refgrid;
            p2refgrid = gamescreen.p2refgrid;
            playerturn = gamescreen.playerturn;
            p1headno = gamescreen.p1headno;
            p2headno = gamescreen.p2headno;
            nousers = gamescreen.nousers;
            difficulty = gamescreen.difficulty;
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slotonebtn_Click(object sender, EventArgs e)
        {
            filename = "slotone.txt";
            SaveGame();
            this.Close();
        }

        private void slottwobtn_Click(object sender, EventArgs e)
        {
            filename = "slottwo.txt"; 
            SaveGame();
            this.Close();
        }

        private void slotthreebtn_Click(object sender, EventArgs e)
        {
            filename = "slotthree.txt";
            SaveGame();
            this.Close();
        }

        private void slotfourbtn_Click(object sender, EventArgs e)
        {
            filename = "slotfour.txt";
            SaveGame();
            this.Close();
        }

        private void slotfivebtn_Click(object sender, EventArgs e)
        {
            filename = "slotfive.txt";
            SaveGame();
            this.Close();
        }

        private void SaveGame()
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
    }
}
