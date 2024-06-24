using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Triangle
{
    internal class TriangleShapeService : IDrawer
    {
        public void Draw(int max)
        {
            for (int i = 0; i < max; i++)
            {
                for (int j = i; j < max; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            };
        }
    }
}
