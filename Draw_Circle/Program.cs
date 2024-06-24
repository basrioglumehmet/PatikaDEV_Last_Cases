using Draw_Circle;
using System;

class Program
{
    static void Main()
    {
        int yaricap = 7; // Dairenin yarıçapı
        IDrawer shape = new CircleDrawerService();
        shape.Draw(yaricap);
    }
}
