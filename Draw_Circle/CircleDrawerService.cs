using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Circle
{
    internal class CircleDrawerService : IDrawer
    {
        public void Draw(int yaricap)
        {

            // Daireyi içine alacak bir dikdörtgen oluştur
            for (int y = -yaricap; y <= yaricap; y++)
            {
                for (int x = -yaricap; x <= yaricap; x++)
                {
                    // Eğer (x, y) noktasının dairenin merkezine olan uzaklığı yarıçaptan küçük veya eşitse, bu noktayı çiz
                    if (Math.Abs(x * x + y * y - yaricap * yaricap) < yaricap)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Her satırın sonunda bir alt satıra geç
            }
        }
    }
}
