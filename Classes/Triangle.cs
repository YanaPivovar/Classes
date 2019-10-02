using System;

namespace Classes
{
    public class Triangle
    {
        double _a;
        double _b;
        double _c;

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

        public bool IsReal
        {
            get
            {
                return !(_a <= 0 || _b <= 0 || _c <= 0);
            }
        }

        public Triangle()
        {
        }

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public void GetInfo()
        {
            Console.WriteLine($"a={_a}, b={_b}, c={_c}");
        }

        public double GetPerimetr()
        {
            return _a + _b + _c;
        }

        public double GetArea()
        {
            return _a * _b * _c;
        }
    }
}
