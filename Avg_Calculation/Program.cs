// Fibonacci Dizisini Tanıyalım
// 
// Fibonacci dizisi, her sayının kendisinden önceki iki sayının toplamı ile elde edildiği bir sayı dizisidir.
// Dizinin ilk iki terimi şu şekildedir:
// f(0) = 0
// f(1) = 1
//
// Sonraki terimler ise şu şekilde hesaplanır:
// f(n) = f(n-1) + f(n-2) (n ≥ 2)
//
// Şimdi, Fibonacci dizisinin ilk birkaç terimini adım adım hesaplayalım:

// İlk iki terim sabittir:
// f(0) = 0
// f(1) = 1

// İkinci terimden itibaren her terim, önceki iki terimin toplamıdır:

// Üçüncü terimi hesaplayalım:
// f(2) = f(1) + f(0) = 1 + 0 = 1

// Dördüncü terimi hesaplayalım:
// f(3) = f(2) + f(1) = 1 + 1 = 2

// Beşinci terimi hesaplayalım:
// f(4) = f(3) + f(2) = 2 + 1 = 3

// Altıncı terimi hesaplayalım:
// f(5) = f(4) + f(3) = 3 + 2 = 5

// Yedinci terimi hesaplayalım:
// f(6) = f(5) + f(4) = 5 + 3 = 8

// Sekizinci terimi hesaplayalım:
// f(7) = f(6) + f(5) = 8 + 5 = 13

// Fibonacci dizisinin ilk 8 terimi bu şekilde hesaplanır:
// 0, 1, 1, 2, 3, 5, 8, 13

// Solid prensiplerinden Single Responsibility'e uygundur yani tek bir iş yapar.

using Avg_Calculation;
using System;

class Program
{
    static void Main()
    {
        int depth = int.Parse(Console.ReadLine());
        var helper = new FibonacciHelperService();
        var seriesList = helper.generateSeries(depth);
        Console.WriteLine(String.Join(",", seriesList));
        Console.WriteLine($"Ortalama:{helper.getAverage(seriesList)}");
    }
}
