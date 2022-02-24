using System;
using System.Collections.Generic;
using System.Text;

namespace Planes
{
    public class Plane
    {
        // variables define position of plane
        protected int headrow;
        protected int headcol;
        protected int planeorientation;

        public Plane(int r, int c, int o)
        {
            headrow = r;
            headcol = c;
            planeorientation = o;
        }

        public int GetRow()
        {
            return headrow;
        }

        public void SetPlane(int row, int col, int orientation)
        {
            headrow = row;
            headcol = col;
            planeorientation = orientation;
        }

        public int GetCol()
        {
            return headcol;
        }

        public int GetOrientation()
        {
            return planeorientation;
        }
    }
}
