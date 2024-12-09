using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
namespace MyApp
{
    sealed class Circle : Shape
    {
        public Circle(int x, int y, string color) : base(x, y, color)
        {
        }
    }
}