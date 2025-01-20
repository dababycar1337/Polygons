using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Input;
using System;
using System.Collections.Generic;

namespace Polygons;

public class CustomControl: UserControl
{
    private int x, y;
    private bool mouseDown = false;
    List<Shape> polygons = new List<Shape>();
    public override void Render(DrawingContext drawingContext)
    {
        
    }
    
    public void Pressed(int x, int y, bool mouseDown)
    {
        this.x = x;
        this.y = y;
        this.mouseDown = mouseDown;
    }

    public void IsMoving(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public void Released(bool mouseDown)
    {
        this.mouseDown = mouseDown;
    }
}