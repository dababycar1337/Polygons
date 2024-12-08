using System;
namespace Polygons
{
    class Program
    {
        static void Main()
        {
            Circle c = new Circle(1, 1, "blue");
            Square q = new Square(1, 1, "red");
            Triangle t = new Triangle(1, 1, "green");
            c.Returning();
        }
    }
}
