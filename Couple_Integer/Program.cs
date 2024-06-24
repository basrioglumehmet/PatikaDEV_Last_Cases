/*
 * Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, 
 * sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

Örnek Input: 2 3 1 5 2 5 3 3

Output: 5 6 7 81
*/

int[] inputs = { 2, 3, 1, 5, 2, 5, 3, 3 };
//Aslında comparable kullanılabilir best practice çözüm.

for (int i = 0; i < inputs.Length; i += 2)
{

    int sum = inputs[i] + inputs[i + 1];
    if (inputs[i] == inputs[i + 1])
    {
        Console.WriteLine($"Girdiğiniz sayılar aynı ({inputs[i]}, {inputs[i + 1]}), toplamlarının karesi: {sum * sum}");
    }
    else
    {
        Console.WriteLine($"Girdiğiniz sayılar farklı ({inputs[i]}, {inputs[i + 1]}), toplamları: {sum}");
    }
}