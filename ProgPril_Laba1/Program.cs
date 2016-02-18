using System;
using System.Collections.Generic;


namespace ProgPril_Laba1
{
    class Program
    {
        static void Main()
        {
            int objCount = 5;
            int[] intArray = new int[objCount];
            Rectangle[] rectArray = new Rectangle[objCount];
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; i++) intArray[i] = rnd.Next(1,15);
            for (int i = 0; i < rectArray.Length; i++) rectArray[i] = new Rectangle(rnd.Next(2, 10), rnd.Next(2, 10));

			RectSorter rSort = new RectSorter (rectArray);
			IntegerSorter iSort = new IntegerSorter (intArray);

			for (int i = 0; i < objCount; i++) 
			{
				Console.WriteLine (iSort.GetElement (i));
			}
			iSort.doSort ();
			Console.WriteLine ();
			for (int i = 0; i < objCount; i++) 
			{
				Console.WriteLine (iSort.GetElement (i));
			}

			Console.ReadKey();
			Console.Clear ();

			for (int i = 0; i < objCount; i++) 
			{
				rSort.GetElement (i).draw();
			}

			rSort.doSort ();
			Console.WriteLine ();
			for (int i = 0; i < objCount; i++) 
			{
				rSort.GetElement (i).draw();
			}

            Console.ReadKey();
        }
    }
}
