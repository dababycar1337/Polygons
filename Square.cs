using Avalonia.Media;
using System;
using Avalonia;

namespace Polygons;

sealed class Square : Shape
{
    public Square(int x, int y) : base(x, y)
    {
    }

    public override void Draw(DrawingContext dc)
    {
        Pen pen = new Pen(Brushes.White, 1, lineCap:PenLineCap.Square);
        Brush brush = new SolidColorBrush(Colors.Red);
        
        double helper = R * Math.Sqrt(2); 
        
        dc.DrawRectangle(brush, pen, new Rect(new Point(x - helper / 2, y - helper / 2), new Size(helper, helper)));
        Console.WriteLine("SQUARE");
    }
}
