using Avalonia.Media;

namespace Polygons;

abstract class Shape
{
    protected int x, y;
    static int r;

    public int R
    {
        get => r;
    }
    protected Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    static Shape()
    {
        r = 50;
    }

    public abstract void Draw(DrawingContext dc);
}