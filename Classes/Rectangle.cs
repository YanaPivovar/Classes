using System;

namespace Classes
{
    public class Rectangle
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;

        public Rectangle()
        {
        }

        public Rectangle(double side_a, double side_b, double side_c, double side_d)
        {
            this._a = side_a;
            this._b = side_b;
            this._c = side_c;
            this._d = side_d;
        }

        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }
        }
        public double D
        {
            get
            {
                return _d;
            }
            set
            {
                _d = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"a={_a}, b={_b}, c={_c}, d={_d}");
        }

        public double Perimetr()
        {
            return _a + _b + _c + _d;
        }

        public double Area()
        {
            return _a * _b;
        }

        public bool IsSquare
        {
            get
            {
                return (_a == _b && _b == _c && _c == _d);
            }
        }
    }
}
