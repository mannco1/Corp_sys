
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] sequence = { 2, 4, -1, 6, -3, 8, -5, 10 };

        int firstPositive = sequence.FirstOrDefault(x => x > 0);
        int lastNegative = sequence.LastOrDefault(x => x < 0);

        if (firstPositive != 0)
            Console.WriteLine("Первое положительное число: " + firstPositive);
        else
            Console.WriteLine("В последовательности нет положительных чисел.");

        if (lastNegative != 0)
            Console.WriteLine("Последнее отрицательное число: " + lastNegative);
        else
            Console.WriteLine("В последовательности нет отрицательных чисел.");
    }
}
