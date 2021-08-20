using System;

namespace _06_BridgePattern_ShapesAndColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Color blue = new Blue();
            Shape blueCircle = new Circle(blue);
            Shape redSquare = new Square(new Red());

            blueCircle.DescribeShape();
            redSquare.DescribeShape();
        }
    }

    /*
     *      This is a IS A class. Without "injecting" the color int this class we'd have a mess very quickly.
     *      Without this approach adding new shapes and colors would make our code explode in no time.
     */
    public class Shape
    {
        public string Name;
        // The class HAS A color and this is the BRIDGE that connects the two abstract classes
        public Color _color;

        public Shape(Color color)
        {
            this._color = color;
        }

        public virtual void DescribeShape()
        {
            Console.WriteLine($"This is a { _color.Name } { Name }");
        }
    }

    public class Circle : Shape
    {
        public Circle(Color color) : base(color)
        {
            Name = "Circle";
        }
    }

    public class Square : Shape
    {
        public Square(Color color) : base(color)
        {
            Name = "Square";
        }
    }

    public class Color
    {
        public string Name;
    }

    public class Red : Color
    {
        public new string Name = "Red";
    }

    public class Blue : Color
    {
        public new string Name = "Blue";
    }
}
