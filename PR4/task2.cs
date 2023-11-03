using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] sequence = { 15, 24, 37, 42, 53, 68, 79, 100 };
        int digitD = 7; // Заданная цифра D

        int result = sequence.FirstOrDefault(x => x > 0 && x % 10 == digitD);

        if (result != 0)
            Console.WriteLine("First positive number ending with " + digitD + ": " + result);
        else
            Console.WriteLine("No matching element found in the sequence.");
    }
}


