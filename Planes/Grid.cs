using System;
using System.Collections.Generic;
using System.Text;

namespace Planes
{
    public class Grid
    {
        protected Plane[] planearray = new Plane[3];
        public int[,] playgrid = new int[10, 10];
        protected int lastplane = 0;
        Random rnd = new Random();

        public Grid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playgrid[i, j] = 0;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                planearray[i] = new Plane(0, 0, 0);
            }
        }

        public void ClearGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playgrid[i, j] = 0;
                }
            }
            for (int i = 0; i < lastplane; i++)
            {
                planearray[i].SetPlane(0, 0, 0);
            }
            lastplane = 0;
        }

        //make method to create a grid
        public void CreateGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playgrid[i, j] = 0;
                }
            }
            lastplane = 0;
            while(lastplane < 3)
            {
                int r = rnd.Next(10);
                int c = rnd.Next(10);
                int orientation = rnd.Next(4);
                if (playgrid[r, c] == 0)
                {
                    if (orientation == 0)
                    {
                        if (c + 2 <= 9 && c - 2 >= 0 && r + 3 <= 9)
                        {
                            if (playgrid[r + 1, c - 2] == 0 && playgrid[r + 1, c - 1] == 0 && playgrid[r + 1, c] == 0 && playgrid[r + 1, c + 1] == 0 && playgrid[r + 1, c + 2] == 0 && playgrid[r + 2, c] == 0 && playgrid[r + 3, c - 1] == 0 && playgrid[r + 3, c] == 0 && playgrid[r + 3, c + 1] == 0)
                            {
                                planearray[lastplane].SetPlane(r, c, orientation);
                                playgrid[r, c] = 2;
                                playgrid[r + 1, c - 2] = 1;
                                playgrid[r + 1, c - 1] = 1;
                                playgrid[r + 1, c] = 1;
                                playgrid[r + 1, c + 1] = 1;
                                playgrid[r + 1, c + 2] = 1;
                                playgrid[r + 2, c] = 1;
                                playgrid[r + 3, c - 1] = 1;
                                playgrid[r + 3, c] = 1;
                                playgrid[r + 3, c + 1] = 1;
                                lastplane++;
                            }
                        }
                    }
                    else if (orientation == 1)
                    {
                        if (r + 2 <= 9 && r - 2 >= 0 && c + 3 <= 9)
                        {
                            if (playgrid[r + 2, c + 1] == 0 && playgrid[r + 1, c + 1] == 0 && playgrid[r, c + 1] == 0 && playgrid[r - 1, c + 1] == 0 && playgrid[r - 2, c + 1] == 0 && playgrid[r, c + 2] == 0 && playgrid[r, c + 3] == 0 && playgrid[r - 1, c + 3] == 0 && playgrid[r + 1, c + 3] == 0)
                            {
                                planearray[lastplane].SetPlane(r, c, orientation);
                                playgrid[r, c] = 2;
                                playgrid[r + 2, c + 1] = 1;
                                playgrid[r + 1, c + 1] = 1;
                                playgrid[r, c + 1] = 1;
                                playgrid[r - 1, c + 1] = 1;
                                playgrid[r - 2, c + 1] = 1;
                                playgrid[r, c + 2] = 1;
                                playgrid[r, c + 3] = 1;
                                playgrid[r - 1, c + 3] = 1;
                                playgrid[r + 1, c + 3] = 1;
                                lastplane++;
                            }
                        }
                    }
                    else if (orientation == 2)
                    {
                        if (c + 2 <= 9 && c - 2 >= 0 && r - 3 >= 0)
                        {
                            if (playgrid[r - 1, c + 2] == 0 && playgrid[r - 1, c + 1] == 0 && playgrid[r - 1, c] == 0 && playgrid[r - 1, c - 1] == 0 && playgrid[r - 1, c - 2] == 0 && playgrid[r - 2, c] == 0 && playgrid[r - 3, c + 1] == 0 && playgrid[r - 3, c] == 0 && playgrid[r - 3, c - 1] == 0)
                            {
                                planearray[lastplane].SetPlane(r, c, orientation);
                                playgrid[r, c] = 2;
                                playgrid[r - 1, c + 2] = 1;
                                playgrid[r - 1, c + 1] = 1;
                                playgrid[r - 1, c] = 1;
                                playgrid[r - 1, c - 1] = 1;
                                playgrid[r - 1, c - 2] = 1;
                                playgrid[r - 2, c] = 1;
                                playgrid[r - 3, c + 1] = 1;
                                playgrid[r - 3, c] = 1;
                                playgrid[r - 3, c - 1] = 1;
                                lastplane++;
                            }
                        }
                    }
                    else
                    {
                        if (r + 2 <= 9 && r - 2 >= 0 && c - 3 >= 0)
                        {
                            if (playgrid[r - 2, c - 1] == 0 && playgrid[r - 1, c - 1] == 0 && playgrid[r, c - 1] == 0 && playgrid[r + 1, c - 1] == 0 && playgrid[r + 2, c - 1] == 0 && playgrid[r, c - 2] == 0 && playgrid[r - 1, c - 3] == 0 && playgrid[r, c - 3] == 0 && playgrid[r + 1, c - 3] == 0)
                            {
                                planearray[lastplane].SetPlane(r, c, orientation);
                                playgrid[r, c] = 2;
                                playgrid[r - 2, c - 1] = 1;
                                playgrid[r - 1, c - 1] = 1;
                                playgrid[r, c - 1] = 1;
                                playgrid[r + 1, c - 1] = 1;
                                playgrid[r + 2, c - 1] = 1;
                                playgrid[r, c - 2] = 1;
                                playgrid[r - 1, c - 3] = 1;
                                playgrid[r, c - 3] = 1;
                                playgrid[r + 1, c - 3] = 1;
                                lastplane++;
                            }
                        }
                    }

                }
            }
        }

        public int GetSquare(int r, int c)
        {
            return playgrid[r, c];
        }


        public void RemovePlane()
        {
            if (lastplane != 0)
            {
                int r = planearray[lastplane - 1].GetRow();
                int c = planearray[lastplane - 1].GetCol();
                int orientation = planearray[lastplane - 1].GetOrientation();

                if (orientation == 0)
                {
                    playgrid[r, c] = 0;
                    playgrid[r + 1, c - 2] = 0;
                    playgrid[r + 1, c - 1] = 0;
                    playgrid[r + 1, c] = 0;
                    playgrid[r + 1, c + 1] = 0;
                    playgrid[r + 1, c + 2] = 0;
                    playgrid[r + 2, c] = 0;
                    playgrid[r + 3, c - 1] = 0;
                    playgrid[r + 3, c] = 0;
                    playgrid[r + 3, c + 1] = 0;
                }
                else if (orientation == 1)
                {
                    playgrid[r, c] = 0;
                    playgrid[r + 2, c + 1] = 0;
                    playgrid[r + 1, c + 1] = 0;
                    playgrid[r, c + 1] = 0;
                    playgrid[r - 1, c + 1] = 0;
                    playgrid[r - 2, c + 1] = 0;
                    playgrid[r, c + 2] = 0;
                    playgrid[r, c + 3] = 0;
                    playgrid[r - 1, c + 3] = 0;
                    playgrid[r + 1, c + 3] = 0;
                }
                else if (orientation == 2)
                {
                    playgrid[r, c] = 0;
                    playgrid[r - 1, c + 2] = 0;
                    playgrid[r - 1, c + 1] = 0;
                    playgrid[r - 1, c] = 0;
                    playgrid[r - 1, c - 1] = 0;
                    playgrid[r - 1, c - 2] = 0;
                    playgrid[r - 2, c] = 0;
                    playgrid[r - 3, c + 1] = 0;
                    playgrid[r - 3, c] = 0;
                    playgrid[r - 3, c - 1] = 0;
                }
                else
                {
                    playgrid[r, c] = 0;
                    playgrid[r - 2, c - 1] = 0;
                    playgrid[r - 1, c - 1] = 0;
                    playgrid[r, c - 1] = 0;
                    playgrid[r + 1, c - 1] = 0;
                    playgrid[r + 2, c - 1] = 0;
                    playgrid[r, c - 2] = 0;
                    playgrid[r - 1, c - 3] = 0;
                    playgrid[r, c - 3] = 0;
                    playgrid[r + 1, c - 3] = 0;
                }
                lastplane--;
            }
        }

        public void AddPlane(int r, int c, int orientation)
        {
            if(lastplane < 3)
            {
                planearray[lastplane].SetPlane(r, c, orientation);
                lastplane++;
            }
        }


    }
}
