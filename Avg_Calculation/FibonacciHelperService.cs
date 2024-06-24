using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_Calculation
{
    internal class FibonacciHelperService : IFibonacciHelper
    {
        public int[] generateSeries(int depth)
        {
            int[] series = new int[depth];
            // İlk terimler
            series[0] = 0; // f(n) = f(0) = 0;
            series[1] = 1; // f(n) = f(1) = 1

            for (int i = 2; i < depth; i++) // n >= 2 olmak zorundadır.
            {
                series[i] = series[i - 1] + series[i - 2]; // f(n) = f(n-1) +  f(n-2)
            }
            return series;
        }

        public double getAverage(int[] fibonacciSeriesResult)
        {
            return fibonacciSeriesResult.Average();
        }
    }
}
