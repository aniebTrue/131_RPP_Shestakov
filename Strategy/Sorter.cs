using Shapes.Interface;

namespace Sorter
{
    public class Sorter<T>
    {
        public iSorter<T> _sort { get; set; }
        public T[] Sort(T[] array)
        {
            return _sort.Sort(array);
        }
    }



    public interface iSorter<T>
    {
        T[] Sort(T[] array);
    }
    
    public interface ICompare<T>
    {
        bool IsBigger(T a, T b);
    }
    public class SortShapes<T> : iSorter<T>
    {
        public ICompare<T> comp { get; set; }
        T[] iSorter<T>.Sort(T[] array)
        {           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = i;
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    if (comp.IsBigger(array[min], array[j]))
                    {
                        Swap(ref array[min], ref array[j]);
                    }
                }
            }
            return array;
        }
        protected void Swap(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }


        public void Sort(IRectangle[] rect)
        {
            throw new System.NotImplementedException();
        }
    }
    public class CompareRectangles:ICompare<IRectangle>
        {

            public bool IsBigger(IRectangle a, IRectangle b)
            {
                return a.Height * a.Width > b.Height * b.Width;
            }
        }
    public class CompareTriangle:ICompare<ITriangle>
        {

            public bool IsBigger(ITriangle a, ITriangle b)
            {
                return 0.5 * a.Base * a.Height > 0.5 * b.Base * b.Height;
            }
        }


}