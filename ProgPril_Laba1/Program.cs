using System;
using System.Collections.Generic;


namespace ProgPril_Laba1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число генерируемых объектов: ");
            int ObjNum = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int[] intArray = new int[ObjNum];
            Rectangle[] rectArray = new Rectangle[ObjNum];
            Random rnd = new Random();
            Console.WriteLine("Неотсортированый массив");
            for (int i=0;i<intArray.Length; i++)
            {                               
                intArray[i] = rnd.Next(1, 20);
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine("Отсортированый массив");
            Sort(ref intArray);
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Неотсортированый массив");
            for (int i = 0; i < rectArray.Length; i++)
            {
                Rectangle r = new Rectangle(rnd.Next(2, 5), rnd.Next(2, 5));
                rectArray[i] = r;
                rectArray[i].draw();
            }

            Console.WriteLine("Отсортированый массив");
            SortRect(ref rectArray);
            for (int i = 0; i < rectArray.Length; i++)
            {
                rectArray[i].draw();
            }
            Console.ReadKey();


        }
        static void Sort(ref int[] array)
        {
           for(int i=0;i<array.Length;i++)
            {
                int min = i;
                {
                    for(int j= i;j<array.Length;j++)
                    {
                        if(array[i]>array[j])
                        {
                            swap(ref array[i],ref array[j]);
                        }
                    }
                }
            } 
        }

        static void SortRect(ref Rectangle[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        if (array[i].GET_S > array[j].GET_S)
                        {
                            swapRect(ref array[i], ref array[j]);
                        }
                    }
                }
            }
        }

        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void swapRect(ref Rectangle a, ref Rectangle b)
        {
            Rectangle c = a;
            a = b;
            b = c;
        }
    }
}
