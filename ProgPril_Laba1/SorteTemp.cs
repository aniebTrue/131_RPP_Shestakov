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
					if (IsBiger(min,j) == true) SwapByIndex(min, j);
                }
            }
        }
        abstract protected bool IsBiger(int a, int b);
        public void SwapByIndex(int a, int b)
         {
             T c = array[a];
             array[a]=array[b];
             array[b]=c;
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

		protected override bool IsBiger(int a, int b)
        {
			if (array[a].GET_S > array[b].GET_S) return true;
            return false;
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
			if (array[a]>array[b]) return true;
			return false;
		}

	}
}
