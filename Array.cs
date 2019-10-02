using System;

namespace Classes
{
    public class MyArray
    {
        private int _size;
        public int[] _Array;

        public MyArray(int arraySize)
        {
            _size = arraySize;
            _Array = new int[_size];
        }

        public void InputArray()
        {
            for (int i = 0; i < _size; i++)
            {
                _Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Show()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(_Array[i]);
            }
        }

        public void SortUp()
        {
            Array.Sort(_Array);
            Show();
        }

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }

        public int Scalar
        {

            set
            {
                for (int i = 0; i < _size; i++)
                    _Array[i] *= value;
            }
        }
    }
}

