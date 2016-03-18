using System;
using Shapes.Interface;

namespace Sorter
{
    public interface ISorter<T>
    {
        T[] Sort(T[] array, ICompare<T> Comparer);
        T[] Sort(T[] array, Func<T, T, int> comparison);
    }
    public interface ICompare<T>
    {
        int Compare(T x, T y);
    }
    public class compareInt : ICompare<int>
    {
        public int Compare(int x, int y)
        {
            if (x > y) return 1;
            if (x < y) return -1;
            return 0;
        }
    }
    public class compareRectangle : ICompare<IRectangle>
    {
        public int Compare(IRectangle x, IRectangle y)
        {
            if (x.Height * x.Width > y.Height * y.Width) return 1;
            if (x.Height * x.Width < y.Height * y.Width) return -1;
            return 0;
        }
    }
    public class compareTriangle : ICompare<ITriangle>
    {
        public int Compare(ITriangle x, ITriangle y)
        {
            if (x.Base * x.Height > y.Base * y.Height) return 1;
            if (x.Base * x.Height < y.Base * y.Height) return -1;
            return 0;
        }
    }
    public class Comp
    {
        public static int CompareInt(int a, int b)
        {
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        }
        public static int CompareRect(IRectangle a, IRectangle b)
        {
            if (a.Height * a.Width > b.Height * b.Width) return 1;
            if (a.Height * a.Width < b.Height * b.Width) return -1;
            return 0;
        }
    }

    public class Sorter<T>:ISorter<T>
    {

        public T[] Sort(T[] array, Func<T, T, int> comparison)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = i;
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    if (comparison(array[min], array[j]) == 1)
                    {
                        var a = array[min];
                        array[min] = array[j];
                        array[j] = a;
                    }

                }

            }
            return array;
        }

        public T[] Sort(T[] array, ICompare<T> comparer)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = i;
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    if (comparer.Compare(array[min], array[j]) == 1)

                    {
                        var a = array[min];
                        array[min] = array[j];
                        array[j] = a;
                    }
                        
                }
            }
            return array;
        }
    }
}