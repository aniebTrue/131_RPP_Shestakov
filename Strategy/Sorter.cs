using System;
using Shapes.Interface;

namespace Sorter
{

    public interface ICompare<T>
    {
        int Compere(T x, T y);
    }
    public class compareInt : ICompare<int>
    {

        public int Compere(int x, int y)
        {
            if (x > y) return 1;
            if (x < y) return -1;
            return 0;
        }
    }
    public class compareRectangle : ICompare<IRectangle>
    {
        public int Compere(IRectangle x, IRectangle y)
        {
            if (x.Height * x.Width > y.Height * y.Width) return 1;
            if (x.Height * x.Width < y.Height * y.Width) return -1;
            return 0;
        }
    }
    public class compareTriangle : ICompare<ITriangle>
    {
        public int Compere(ITriangle x, ITriangle y)
        {
            if (x.Base * x.Height > y.Base * y.Height) return 1;
            if (x.Base * x.Height < y.Base * y.Height) return -1;
            return 0;
        }
    }

    public class Sorter<T>
    {
        public ICompare<T> _Compare { get; set; }



        private void Swap(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        public T[] Sort(T[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = i;
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    if (_Compare.Compere(array[min], array[j]) == 1)
                        Swap(ref array[min], ref array[j]);
                }
            }
            return array;
        }
    }
}