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
            IntSorter iSort = new IntSorter(intArray);
            RectSorter rSort = new RectSorter(rectArray);
            for (int i = 0; i < objCount; i++) Console.WriteLine(iSort.GetElem(i));
            Console.WriteLine();
            Console.ReadKey();
            iSort.Sort();
            for (int i = 0; i < objCount; i++) Console.WriteLine(iSort.GetElem(i));
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Неотсортированый массив:");
            for (int i = 0; i < objCount; i++) rSort.GetElem(i).draw();
            rSort.Sort();
            Console.ReadKey();
            Console.WriteLine("Отсортированый массив:");
            for (int i = 0; i < objCount; i++) rSort.GetElem(i).draw();

            Console.ReadKey();
        }
    }
}
