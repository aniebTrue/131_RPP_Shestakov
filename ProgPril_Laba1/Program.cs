using Shapes.Interface;
using Sorter;
using System;
namespace ProgPril_Laba1
{
    class Program
    {
        static void Main()
        {
            SortShapes<IRectangle> sort = new SortShapes<IRectangle>();
            sort._compare = new CompareRectangles();
            var rect = new IRectangle[10];
            sort.Sort(rect);
        }
    }
}
