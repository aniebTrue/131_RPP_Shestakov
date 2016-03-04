using Shapes.Interface;
using Sorter;
using System;
namespace ProgPril_Laba1
{
    class Program
    {
        static void Main()
        {
            var sort = new Sorter<IRectangle>();
            
            IRectangle[] rects = new IRectangle[15];
            

            sort.Sort(rects);


        }
    }
}
