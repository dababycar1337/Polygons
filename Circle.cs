﻿namespace Polygons;
using Avalonia;
using Avalonia.Media;
using System;

sealed class Circle : Shape
{
    public Circle(int x, int y) : base(x, y)
    {
    }
    
    public override void Draw(DrawingContext dc)
    {
        Pen pen = new Pen(Brushes.Black, 5, lineCap:PenLineCap.Square);
        Brush brush = new SolidColorBrush(Colors.Yellow);
        
        dc.DrawEllipse(brush, pen, new Point(x, y), R, R);
        Console.WriteLine("circle");
    }
}