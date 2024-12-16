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
        Pen pen = new Pen(Brushes.White, 1, lineCap:PenLineCap.Square);
        Brush brush = new SolidColorBrush(Colors.Blue);

        double helperX = Math.Sqrt(3) * R / 2;
        double helperY = R / 2;
        
        Point[] points = new Point[4]
        {
            new Point(x, y - R), 
            new Point(x + helperX, y + helperY), 
            new Point(x - helperX, y + helperY),
            new Point(x, y - R)
        };
        
        PolylineGeometry geometry = new PolylineGeometry(points, true);
        
        dc.DrawGeometry(brush, pen, geometry);
        Console.WriteLine("TRIANGLE");
    }
}
