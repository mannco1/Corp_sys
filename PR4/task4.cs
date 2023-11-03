using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] sequence = { 2, 5, 8, 3, 9, 4, 7, 1 };
        int D = 4; // Заданное число D

        var extractedNumbers = sequence
            .SkipWhile(x => x <= D) // Пропускаем элементы, меньшие или равные D
            .Where(x => x > 0 && x % 2 != 0) // Фильтруем нечетные положительные числа
            .Reverse(); // Меняем порядок извлеченных чисел на обратный

        if (extractedNumbers.Any())
        {
            Console.WriteLine("Extracted numbers: " + string.Join(", ", extractedNumbers));
        }
        else
        {
            Console.WriteLine("No matching numbers found.");
        }
    }
}

