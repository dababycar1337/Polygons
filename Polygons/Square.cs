using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Square: Shape
    {
        public Square(int x, int y, string color) : base(x, y, color)
        {
        }
        static Square()
        {
            radius = 2;
        }
    }
}
