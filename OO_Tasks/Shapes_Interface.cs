using System;

namespace OO_Tasks_Interface {
    public interface IShapeProps
    {
        double GetArea();
        double GetPerimeter();
    }

    public interface ICircleProps
    {
        double GetArea();
        double GetCircumference();
    }

    public class Shape {
        private string _name;
        private string _colour;

        public string Name => _name;
        public string Colour => _colour;

        public Shape(string Nname, string Ncolour)
        {
            _name = Nname;
            _colour = Ncolour;
        }
    }

    public class Quadrilateral : Shape
    {
        private int _NumSides = 4;

        public int NumSides => _NumSides;

        public Quadrilateral(string Nname, string Ncolour) : base(Nname, Ncolour)
        {

        }
    }

    public class Square : Quadrilateral, IShapeProps
    {
        private double _sideLength;

        public double sideLength => _sideLength;

        public Square(string Nname, string Ncolour, double NsideLength) : base(Nname, Ncolour)
        {
            _sideLength = NsideLength;
        }

        public double GetArea()
        {
            double Area = sideLength * sideLength;
            return Math.Round(Area,2);
        }

        public double GetPerimeter()
        {
            double Perimeter = 4 * sideLength;
            return Math.Round(Perimeter,2);
        }
    }

    public class Rectangle : Quadrilateral, IShapeProps
    {
        private double _length;
        private double _width;

        public double length => _length;
        public double width => _width;
        public Rectangle(string Nname, string Ncolour, double Nlength, double Nwidth) : base(Nname, Ncolour)
        {
            _length = Nlength;
            _width = Nwidth;
        }

        public double GetArea()
        {
            double Area = _length * _width;
            return Math.Round(Area,2);
        }

        public double GetPerimeter()
        {
            double Perimeter = 2 * _length + 2 * _width;
            return Math.Round(Perimeter,2);
        }
    }

    public class Circle : Shape, ICircleProps
    {
        private double _radius;
        public const double PI = 3.142;

        public double radius => _radius;

        public Circle(string Nname, string Ncolour, double Nradius) : base(Nname, Ncolour)
        {
            _radius = Nradius;
        }

        public double GetArea()
        {
            double Area = _radius * _radius * PI;
            return Math.Round(Area,2);
        }

        public double GetPerimeter()
        {
            double Perimeter = 2 * _radius * PI;
            return Math.Round(Perimeter,2);
        }

        public double GetCircumference()
        {
            double Circumference = 2 * _radius * PI;
            return Math.Round(Circumference,2);
        }
    }
}