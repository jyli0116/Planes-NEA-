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
    public partial class SavedUC : UserControl
    {
        public static SavedUC savedscreen;
        public string filename = "";
        public bool saved = false;
        public Grid p2planegrid = new Grid();
        public Grid p1planegrid = new Grid();
        public int[,] p1refgrid = new int[10, 10];
        public int[,] p2refgrid = new int[10, 10];
        public int playerturn;
        public int p1headno = 0;
        public int p2headno = 0;
        public int nousers;
        public int difficulty;

        public SavedUC()
        {
            savedscreen = this;
            InitializeComponent();
            if (File.Exists("slotone.txt"))
            {
                using (StreamReader sr = new StreamReader("slotone.txt"))
                {
                    if (String.IsNullOrWhiteSpace(sr.ReadLine()))
                    {
                        slotonebtn.Text = "Slot One : Empty";
                    }
                }
            }
            else
            {
                slotonebtn.Text = "Slot One : Empty";
            }

            if (File.Exists("slottwo.txt"))
            {
                using (StreamReader sr = new StreamReader("slottwo.txt"))
                {
                    if (String.IsNullOrWhiteSpace(sr.ReadLine()))
                    {
                        slottwobtn.Text = "Slot Two : Empty";
                    }
                }
            }
            else
            {
                slottwobtn.Text = "Slot Two : Empty";
            }

            if (File.Exists("slotthree.txt"))
            {
                using (StreamReader sr = new StreamReader("slotthree.txt"))
                {
                    if (String.IsNullOrWhiteSpace(sr.ReadLine()))
                    {
                        slotthreebtn.Text = "Slot Three : Empty";
                    }
                }
            }
            else
            {
                slotthreebtn.Text = "Slot Three : Empty";
            }

            if (File.Exists("slotfour.txt"))
            {
                using (StreamReader sr = new StreamReader("slotfour.txt"))
                {
                    if (String.IsNullOrWhiteSpace(sr.ReadLine()))
                    {
                        slotfourbtn.Text = "Slot Four : Empty";
                    }
                }
            }
            else
            {
                slotfourbtn.Text = "Slot Four : Empty";
            }

            if (File.Exists("slotfive.txt"))
            {
                using (StreamReader sr = new StreamReader("slotfive.txt"))
                {
                    if (String.IsNullOrWhiteSpace(sr.ReadLine()))
                    {
                        slotfivebtn.Text = "Slot Five : Empty";
                    }
                }
            }
            else
            {
                slotfivebtn.Text = "Slot Five : Empty";
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            filename = "slotone.txt";
            OpenGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = "slottwo.txt";
            OpenGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filename = "slotthree.txt";
            OpenGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filename = "slotfour.txt";
            OpenGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filename = "slotfive.txt";
            OpenGame();
        }

        private void OpenGame()
        {
            
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    if (!String.IsNullOrWhiteSpace(sr.ReadLine()))
                    {
                        saved = true;

                        using (StreamReader reader = new StreamReader(filename))
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    p1planegrid.playgrid[i,j] = Convert.ToInt32(reader.ReadLine());
                                }
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    p2planegrid.playgrid[i, j] = Convert.ToInt32(reader.ReadLine());
                                }
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    p1refgrid[i, j] = Convert.ToInt32(reader.ReadLine());
                                }
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    p2refgrid[i, j] = Convert.ToInt32(reader.ReadLine());
                                }
                            }
                            playerturn = Convert.ToInt32(reader.ReadLine());
                            p1headno = Convert.ToInt32(reader.ReadLine());
                            p2headno = Convert.ToInt32(reader.ReadLine());
                            nousers = Convert.ToInt32(reader.ReadLine());
                            difficulty = Convert.ToInt32(reader.ReadLine());

                        }


                        /*for (int i = 0; i < 405; i++)
                        {
                            int line = Convert.ToInt32(sr.ReadLine());
                            
                            if (i <= 99)
                            {
                                c = i % 10;
                                r = i / 10;                                
                                p1planegrid.playgrid[r, c] = line;
                            }
                            else if (i <= 199 && i >= 100)
                            {
                                c = (i - 100) % 10;
                                r = (i - 100) / 10;                               
                                p2planegrid.playgrid[r, c] = line;
                            }
                            else if (i <= 299 && i >= 200)
                            {
                                c = (i - 200) % 10;
                                r = (i - 200) / 10;
                                
                                p1refgrid[r, c] = line;
                            }
                            else if (i <= 399 && i >= 300)
                            {
                                c = (i - 300) % 10;
                                r = (i - 300) / 10;
                                
                                p2refgrid[r, c] = line;
                            }
                            else if (i == 400)
                            {
                                playerturn = line;
                            }
                            else if (i == 401)
                            {
                                p1headno = line;
                            }
                            else if (i == 402)
                            {
                                p2headno = line;
                            }
                            else if (i == 403)
                            {
                                nousers = line;
                            }
                            else if (i == 404)
                            {
                                difficulty = line;
                            }


                        }*/
                        


                        if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("gamepageUC"))
                        {
                            gamepageUC savedgame = new gamepageUC();
                            savedgame.Dock = DockStyle.Fill;
                            MainForm.Instance.pagecontainer.Controls.Add(savedgame);
                        }
                        MainForm.Instance.pagecontainer.Controls["gamepageUC"].BringToFront();
                    }
                }
            }


        }

        private void savedbackbtn_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.pagecontainer.Controls.ContainsKey("HomeUC"))
            {
                HomeUC returnhome = new HomeUC();
                returnhome.Dock = DockStyle.Fill;
                MainForm.Instance.pagecontainer.Controls.Add(returnhome);
            }
            MainForm.Instance.pagecontainer.Controls["HomeUC"].BringToFront();
            MainForm.Instance.pagecontainer.Controls.RemoveByKey("SavedUC");
        }
    }
}
