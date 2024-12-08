using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    abstract class Shape
    {
        protected int x;
        protected int y;
        protected static int radius;
        protected string color; 
        public Shape(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        static Shape()
        {
            radius = 3;
        }
    }
}
