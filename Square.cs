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
        Pen pen = new Pen(Brushes.Black, 5, lineCap:PenLineCap.Square);
        Brush brush = new SolidColorBrush(Colors.Green);
        double helper = R * Math,Sqrt(2) / 2;
        
        dc.DrawRectangle(brush, pen, new Rect(new Point(x - helper, y - helper), new Size(R, R)));
        Console.WriteLine("square");
    }
}