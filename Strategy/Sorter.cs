using System;
using Shapes.Interface;

namespace Sorter

{
    interface iSorter<T>
    {
        T[] Sort(T[] array);                
    }

    public abstract class SortShapes<T> : iSorter<T>
    {

        T[] iSorter<T>.Sort(T[] array)
        {
            for(int i = 0; i< array.GetLength(0);i++)
            {
                int min = i;
                for(int j = i+1; j<array.GetLength(0); j++)
                {
                    if(IsBiger(array[min],array[j]))
                    {
                        Swap(ref array[min],ref array[j]);
                    }
                } 
            }
            return array;
        }
        abstract protected bool IsBiger(T a, T b);
        public void Swap(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

    }

    public class SortRectamgle : SortShapes<IRectangle>
    {
        protected override bool IsBiger(IRectangle a, IRectangle b)
        {
            return a.Height * a.Width > b.Height * b.Width;
        }
    }
    public class SortTreangle : SortShapes<ITriangle>
    {
        protected override bool IsBiger(ITriangle a, ITriangle b)
        {
            return 0.5 * a.Height * a.Base > 0.5 * b.Height * b.Base;
        }
    }
}
