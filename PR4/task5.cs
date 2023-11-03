using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string[] sequence = { "Apple", "Banana", "Carrot", "Dog", "Elephant", "Fish", "Giraffe" };
        int K = 4; // Заданное число K

        var extractedStrings = sequence
            .TakeWhile((str, index) => index < K) // Извлекаем строки до элемента с порядковым номером K
            .Where(str => str.Length % 2 != 0 && char.IsUpper(str[0])) // Фильтруем строки с нечетной длиной и заглавной буквой
            .Reverse(); // Меняем порядок извлеченных строк на обратный

        if (extractedStrings.Any())
        {
            Console.WriteLine("Extracted strings: " + string.Join(", ", extractedStrings));
        }
        else
        {
            Console.WriteLine("No matching strings found.");
        }
    }
}

