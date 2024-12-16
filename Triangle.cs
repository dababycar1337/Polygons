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
        
        Point[] points = new Point[4]
        {
            new Point(x, y - y1), 
            new Point(x + x1, y + y1), 
            new Point(x - x1, y + y1),
            new Point(x, y - y1)
        };
        
        PolylineGeometry geometry = new PolylineGeometry(points, true);
        
        
        dc.DrawGeometry(brush, pen, geometry);
        Console.WriteLine("triangle");
    }
}