
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] sequence = { "123abc", "45xyz", "789def", "abc123", "xyz45" };
        int requiredLength = 3; // Заданная длина L

        string result = sequence.LastOrDefault(s => s.Length == requiredLength && char.IsDigit(s[0]));

        if (result != null)
            Console.WriteLine("Last string starting with a digit and having length " + requiredLength + ": " + result);
        else
            Console.WriteLine("Not found.");
    }
}
