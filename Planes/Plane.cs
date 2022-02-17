using System;
using System.Collections.Generic;
using System.Text;

namespace Planes
{
    public class Plane
    {
        protected int headrow;
        protected int headcol;
        protected int planeorientation;

        public Plane(int r, int c, int o)
        {
            headrow = r;
            headcol = c;
            planeorientation = 0;
        }

        public int GetRow()
        {
            return headrow;
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
