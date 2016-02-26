using System;

namespace ProgPril_Laba1
{
    class Rectangle
    {
       int h, w;


		public Rectangle()
		{
			this.h = 0;
			this.w = 0;
		}
       public Rectangle(int h, int w)
        {
            this.h = h;
            this.w = w;
        }

       public void draw()
        {
            for(int i=0; i<this.h; i++)
            {
                for (int j = 0; j < this.w; j++) Console.Write("*");
                Console.Write('\n');
            }
            Console.WriteLine();
        }
        public int Square
            {
                get { return this.h * this.w; }
            }
    }
}
