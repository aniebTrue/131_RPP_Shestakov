using Shapes.Interface;
using Sorter;
using System;
namespace ProgPril_Laba1
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            IRectangle[] rectArray = new Shapes.Mock.Mock.Rectangle[10];
            for(int i=0;i<rectArray.Length;i++)
            {
                Shapes.Mock.Mock.Rectangle rect = new Shapes.Mock.Mock.Rectangle();
                rect.Height = rnd.Next(1,10);
                rect.Width= rnd.Next(1,10); ;
                rectArray[i] = rect;
            }
            Sorter<IRectangle> sort = new Sorter<IRectangle>();
            compareRectangle context = new compareRectangle();
            sort._Compare = context;
            sort.Sort(rectArray);
            foreach(Shapes.Mock.Mock.Rectangle r in rectArray)
            {
                Console.WriteLine(r.Height * r.Width);
            }
            Console.ReadKey();
        }
    }
}
