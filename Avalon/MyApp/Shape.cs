using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
namespace MyApp
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