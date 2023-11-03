using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string[] sequence = { "Apple123", "Banana456", "Carrot789", "Dog123", "Elephant456", "Fish789", "Giraffe123" };
        int K = 2; // Заданное число K

        var firstFragment = sequence.Take(3 * K); // Выбираем первые 3K элементов
        var lastDigit = sequence.Last(str => char.IsDigit(str.Last())); // Находим последний элемент, оканчивающийся цифрой
        var secondFragment = sequence.SkipWhile(str => str != lastDigit).Skip(1); // Пропускаем элементы до последнего элемента и сам последний элемент

        var intersection = firstFragment.Intersect(secondFragment).Distinct(); // Выполняем теоретико-множественное пересечение и удаляем дубликаты

        var sortedIntersection = intersection
            .OrderBy(str => str.Length) // Сортируем по возрастанию длин строк
            .ThenBy(str => str); // Затем сортируем в лексикографическом порядке по возрастанию

        if (sortedIntersection.Any())
        {
            Console.WriteLine("Intersection of two fragments: " + string.Join(", ", sortedIntersection));
        }
        else
        {
            Console.WriteLine("No matching elements found.");
        }
    }
}
