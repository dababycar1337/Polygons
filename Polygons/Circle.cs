using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    sealed class Circle : Shape
    {
        public Circle(int x, int y, string color) : base(x, y, color)
        {
        }
        static Circle()
        {
            radius = 2;
        }
    }
}
