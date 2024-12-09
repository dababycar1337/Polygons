using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using System;
namespace MyApp
{
    public class CustomControl: UserControl
    {
        public override void Render(DrawingContext drawingContext)
        {
            Pen pen = new Pen(Brushes.Aqua, 1, lineCap: PenLineCap.Square);
            Brush brush = new SolidColorBrush(Colors.Black);
            drawingContext.DrawEllipse(brush, pen, new Point(1, 1), 10, 10);
            Console.WriteLine("Drawing");
        }
    }
}