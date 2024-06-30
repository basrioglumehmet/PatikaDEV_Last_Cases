using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Application.Core.Utilities
{
    internal class ConsoleUtilities
    {
        public static void DrawProgressCircle(int progress)
        {
            Console.Write("\r[");

            const int totalDots = 20;
            int completedDots = progress * totalDots / 100;

            for (int i = 0; i < totalDots; i++)
            {
                if (i < completedDots)
                    Console.Write("■");
                else
                    Console.Write(" ");
            }

            Console.Write($"] {progress}%");
        }
    }
}
