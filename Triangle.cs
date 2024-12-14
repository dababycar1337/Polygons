using System.Linq;
using Avalonia.Platform;
using System;

namespace Polygons;
using Avalonia;
using System;
using Avalonia.Media;

sealed class Triangle : Shape
{
    public Triangle(int x, int y) : base(x, y)
    {
    }
    
    public override void Draw(DrawingContext dc)
    {
        Pen pen = new Pen(Brushes.Black, 5, lineCap:PenLineCap.Square);
        Brush brush = new SolidColorBrush(Colors.Red);

        double x1 = Math.Sqrt(3) * R / 2;
        double y1 = R / 2;
        
        StreamGeometry geometry = new StreamGeometry();
        using (var ctx = geometry.Open())
        {
            ctx.BeginFigure(new Point(x, y - R), true);
            ctx.LineTo(new Point(x + x1, y + y1));
            ctx.LineTo(new Point(x - x1, y + y1));
            ctx.LineTo(new Point(x, y - R));    
        }
        dc.DrawGeometry(brush, pen, geometry);
        Console.WriteLine("triangle");
    }
}