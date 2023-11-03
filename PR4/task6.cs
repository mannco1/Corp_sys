
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int D = 4; // Заданное число D
        int K = 6; // Заданное число K

        var firstFragment = sequence.TakeWhile(x => x < D); // Выбираем элементы до первого элемента, большего D
        var secondFragment = sequence.Skip(K - 1); // Пропускаем первые K - 1 элементов

        var union = firstFragment.Union(secondFragment).OrderByDescending(x => x);

        if (union.Any())
        {
            Console.WriteLine("Union of two fragments: " + string.Join(", ", union));
        }
        else
        {
            Console.WriteLine("No matching elements found.");
        }
    }
}
