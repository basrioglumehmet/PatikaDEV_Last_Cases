using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string magicWord = "Merhaba Hello Algoritma x";
        string[] splittedWords = magicWord.Split(' ');
        List<string> transformed = new List<string>();

        for (int i = 0; i < splittedWords.Length; i++)
        {
            var word = splittedWords[i];
            char[] converted = word.ToCharArray();

            if (converted.Length > 1)
            {
                char tmpFirstCharacter = converted[0];
                converted[0] = converted[converted.Length - 1];
                converted[converted.Length - 1] = tmpFirstCharacter;
            }

            transformed.Add(new string(converted));
        }

        Console.WriteLine(String.Join(" ", transformed));
    }
}
