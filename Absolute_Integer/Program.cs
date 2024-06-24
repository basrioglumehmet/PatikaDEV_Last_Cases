using System;

class Program
{
    static void Main()
    {
        int[] inputs = { 56, 45, 68, 77 };
        const int refInteger = 67;
        int totalDifference = 0;
        int totalSquareDifference = 0;

        for (int i = 0; i < inputs.Length; i++)
        {
            if (inputs[i] < refInteger)
            {
                totalDifference += refInteger - inputs[i];
            }
            else
            {
                int difference = inputs[i] - refInteger;
                totalSquareDifference += difference * difference;
            }
        }

        Console.WriteLine($"{refInteger}'den küçük olanların farklarının toplamı: {totalDifference}");
        Console.WriteLine($"{refInteger}'den büyük olanların farklarının mutlak kareleri toplamı: {totalSquareDifference}");
    }
}
