using System;

namespace ProgPril_Laba1
{
    abstract class Sorter
    {
        protected void doSort()
        {
            for(int i = 0; i<GetLenght();i++)
            {
                int min = i;
                for(int j = i+1; j<GetLenght(); j++)
                {
                    if (Compare(min, j) == true) Swap(min, j);
                }
            }
        }
        public abstract int GetLenght();
        public abstract bool Compare(int a , int b);
        public abstract void Swap(int i, int j);
    }
    class IntSorter:Sorter
    {
        int[] array;

        public IntSorter(int[] Array)
        {
            this.array = Array;
        }

        public override int GetLenght()
        {
            return array.Length;
        }

        public override bool Compare(int a, int b)
        {
            if (array[a] > array[b]) return true;
            return false;
        }

        public override void Swap(int i, int j)
        {
            int a = array[i];
            array[i] = array[j];
            array[j] = a;
        }
        
        public void Sort()
        {
            doSort();
        }
        
        public int GetElem(int a)
        {
            return array[a];
        }
    }
    class RectSorter : Sorter
    {
        Rectangle[] rectArray;

        public Rectangle GetElem(int a)
        {
            return rectArray[a];
        }

        public RectSorter(Rectangle[] rectArray)
        {
            this.rectArray = rectArray;
        }
        public override int GetLenght()
        {
            return rectArray.Length;
        }

        public override bool Compare(int a, int b)
        {
            if (rectArray[a].GET_S > rectArray[b].GET_S) return true;
            return false;
        }
        public void Sort()
        {
            doSort();
        }
        public override void Swap(int i, int j)
        {
            Rectangle rect = rectArray[i];
            rectArray[i] = rectArray[j];
            rectArray[j] = rect;
        }
    }
}
