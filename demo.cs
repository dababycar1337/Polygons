using Avalonia.Controls;
using Avalonia.Media;
using Avalonia;
using System;

namespace Polygons;

public class CustomControl: UserControl
{
    public override void Render(DrawingContext drawingContext)
    {
        Square square = new Square(300, 500);
        square.Draw(drawingContext);
        
        Circle circle = new Circle(600, 500);
        circle.Draw(drawingContext);
        
        Triangle triangle = new Triangle(900, 500);
        triangle.Draw(drawingContext);
    }
}