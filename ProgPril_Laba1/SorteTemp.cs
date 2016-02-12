namespace ProgPril_Laba1
{
    abstract class SorteTemp<T>
    {
        T[] array;
        public SorteTemp(T[] array)
        {
            this.array = array;
        }

        public void doSort()
        {
            for(int i = 0; i<this.array.GetLength(0);i++)
            {
                int min = i;
                for(int j = i+1; j<this.array.GetLength(0); j++)
                {
                    if (IsBiger(array[min], array[i]) == true) SwapByIndex(min, j);
                }
            }
        }
        abstract protected bool IsBiger(T a, T b);
        public void SwapByIndex(int a, int b)
         {
             T c = array[a];
             array[a]=array[b];
             array[b]=c;
         }

    }
    class RectSorter : SorteTemp<Rectangle>
    {
        Rectangle[] r;

        public RectSorter(Rectangle[] array)
        {
            this.r = array;
        }

        protected override bool IsBiger(Rectangle a, Rectangle b)
        {
            if (a.GET_S > b.GET_S) return true;
            return false;
        }
    }
}
