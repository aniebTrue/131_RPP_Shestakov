namespace ProgPril_Laba1
{
    abstract class SorteTemp<T>
    {
        protected T[] array;

		public SorteTemp()
		{
			this.array = null;
		}

        public SorteTemp(T[] array)
        {
            this.array = array;
        }

		public T GetElement(int Num)
		{
			return array [Num];
		}

        public void doSort()
        {
            for(int i = 0; i<this.array.GetLength(0);i++)
            {
                int min = i;
                for(int j = i+1; j<this.array.GetLength(0); j++)
                {
					if (IsBiger(array[min],array[j]) == true) Swap(ref array[min],ref array[j]);
                }
            }
        }
        abstract protected bool IsBiger(T a, T b);
        public void Swap(ref T a,ref T b)
         {
             T c = a;
             a = b;
             b = c;
         }


    }
    class RectSorter : SorteTemp<Rectangle>
    {
		
		public RectSorter()
		{
			this.array = null;
		}

		public RectSorter(Rectangle[] array)
        {
            this.array = array;
        }

		protected override bool IsBiger(Rectangle a, Rectangle b)
        {
            return a.Square > b.Square;
        }
    }
	class IntegerSorter : SorteTemp<int>
	{
		public IntegerSorter()
		{
			this.array = null;
		}
		public IntegerSorter(int[] array)
		{
			this.array = array;
		}

		protected override bool IsBiger(int a, int b)
		{
			return a>b;
		}

	}
}
