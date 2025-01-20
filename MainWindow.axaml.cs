using System;
using Avalonia.Controls;
using Avalonia.Input;

namespace Polygons;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void MousePressed(object? sender, PointerPressedEventArgs e)
    {
        CustomControl cc = this.FindControl<CustomControl>("CustomControl");
        cc.Pressed(Convert.ToInt32(e.GetPosition(cc).X), Convert.ToInt32(e.GetPosition(cc).Y), true);
    }

    private void MouseMoved(object? sender, PointerEventArgs e)
    {
        CustomControl cc = this.FindControl<CustomControl>("CustomControl");
        cc.IsMoving(Convert.ToInt32(e.GetPosition(cc).X), Convert.ToInt32(e.GetPosition(cc).Y));
    }

    private void MouseReleased(object? sender, PointerReleasedEventArgs e)
    {
        CustomControl cc = this.FindControl<CustomControl>("CustomControl");
        cc.Released(false);
    }
    
}