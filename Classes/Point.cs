using System;

namespace Classes
{
    public class Point
    {
        private double _x;
        private double _y;

        public Point()
        {
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public double Distanse()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }

        public void MoveByVector(double a, double b)
        {
            _x += a;
            _y += b;
        }

        public double Scalar
        {
            set
            {
                _y *= value;
                _x *= value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"x={_x}, y={_y}");
        }
    }
}
