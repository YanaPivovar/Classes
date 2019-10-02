using System;

namespace Classes
{
    public class Money
    {
        private int _first;
        private int _second;

        public int First
        {
            get
            {
                return _first;
            }
            set
            {
                _first = value;
            }
        }

        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
            }
        }

        public Money()
        {
        }

        public Money(int v1, int v2)
        {
            if (v1 >= 0 && v2 >= 0)
            {
                _first = v1;
                _second = v2;
            }
            else
            {
                _first = 100;
                _second = 10;
            }

        }

        public void GetInfo()
        {
            Console.WriteLine($"rating={_first}, quantity={_second}");
        }

        public bool EnoughMoney(int N = 123)
        {
            return ((_first * _second) / N > 0);
        }


        public int QuantityBought(int N = 20)
        {
            return ((_first * _second) / N);
        }

        public int GetSumm
        {
            get
            {
                return _first * _second;
            }
        }
    }
}
