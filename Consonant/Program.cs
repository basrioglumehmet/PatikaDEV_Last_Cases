using System;

class Program
{
    static void Main()
    {
        // Sessiz Harfler
        string[] consonants = { "b", "c", "ç", "d", "f", "g", "ğ", "h", "j", "k", "l", "m", "n", "p", "r", "s", "ş", "t", "v", "y", "z" };

        // Verilen string ifade
        string input = "Merhaba Umut Arya";

        // Input'u boşluklardan ayırarak parçalıyoruz
        string[] words = input.Split(" ");

        // Her kelime için kontroller
        foreach (string word in words)
        {
            bool found = false;
            // Her kelimenin karakterlerini tek tek kontrol ediyoruz
            for (int j = 0; j < word.Length - 1; j++)
            {
                string char1 = word[j].ToString().ToLower();
                string char2 = word[j + 1].ToString().ToLower();

                // Ardışık sessiz harfleri bulduysak true olarak işaretliyoruz
                if (Array.IndexOf(consonants, char1) != -1 && Array.IndexOf(consonants, char2) != -1)
                {
                    found = true;
                    break;
                }
            }

            // Her kelime için bulunan sonucu ekrana yazdırıyoruz
            Console.WriteLine(found);
        }
    }
}
