using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int K = 5; // Заданное число K

        var firstFragment = sequence.Where(x => x % 2 == 0); // Выбираем все четные числа
        var secondFragment = sequence.Skip(K); // Пропускаем первые K элементов

        var difference = firstFragment.Except(secondFragment).Reverse();

        if (difference.Any())
        {
            Console.WriteLine("Difference of two fragments: " + string.Join(", ", difference));
        }
        else
        {
            Console.WriteLine("No matching elements found.");
        }
    }
}
