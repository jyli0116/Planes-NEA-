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

        public Grid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playgrid[i, j] = 0;
                }
            }
        }

        //make method to create a grid
        public void CreateGrid()
        {

        }

        public int GetSquare(int r, int c)
        {
            return playgrid[r, c];
        }

        public void AddPlane(int r, int c, int orientation)
        {
            if(lastplane < 3)
            {
                planearray[lastplane] = new Plane(r, c, orientation);
                lastplane++;
            }
        }


    }
}
