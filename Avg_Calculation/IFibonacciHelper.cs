using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_Calculation
{
    internal interface IFibonacciHelper
    {
        public double getAverage(int[] fibonacciSeriesResult);
        public int[] generateSeries(int depth);
    }
}
