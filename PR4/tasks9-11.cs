using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Abiturient
{
    public int SchoolNumber { get; set; }
    public int AdmissionYear { get; set; }
    public string LastName { get; set; }
}

class FitnessClient
{
    public int ClientCode { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Hours { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Задача 9: Сведения об абитуриентах
        List<Abiturient> abiturients = new List<Abiturient>
        {
            new Abiturient { SchoolNumber = 1, AdmissionYear = 2010, LastName = "Smith" },
            new Abiturient { SchoolNumber = 2, AdmissionYear = 2010, LastName = "Johnson" },
            new Abiturient { SchoolNumber = 1, AdmissionYear = 2011, LastName = "Williams" },
            new Abiturient { SchoolNumber = 3, AdmissionYear = 2012, LastName = "Brown" },
            new Abiturient { SchoolNumber = 2, AdmissionYear = 2012, LastName = "Jones" },
        };

        var schoolYears = abiturients.GroupBy(a => a.AdmissionYear)
            .Select(g => new { Year = g.Key, SchoolsCount = g.Select(a => a.SchoolNumber).Distinct().Count() })
            .OrderBy(y => y.SchoolsCount)
            .ThenBy(y => y.Year);

        Console.WriteLine("Задача 9: Сведения об абитуриентах");
        foreach (var yearInfo in schoolYears)
        {
            Console.WriteLine($"{yearInfo.SchoolsCount} {yearInfo.Year}");
        }

        // Задача 10: Определение годов с наибольшим и наименьшим числом абитуриентов
        var admissionYears = abiturients.GroupBy(a => a.AdmissionYear)
            .Select(g => new { Year = g.Key, Count = g.Count() })
            .OrderBy(y => y.Count)
            .ThenBy(y => y.Year);

        Console.WriteLine("\nЗадача 10: Определение годов с наибольшим и наименьшим числом абитуриентов");
        var minYear = admissionYears.First();
        var maxYear = admissionYears.Last();
        Console.WriteLine($"Наименьшее число абитуриентов: {minYear.Count}, Год: {minYear.Year}");
        Console.WriteLine($"Наибольшее число абитуриентов: {maxYear.Count}, Год: {maxYear.Year}");

        // Задача 11: Сведения о клиентах фитнес-центра
        List<FitnessClient> fitnessClients = new List<FitnessClient>
        {
            new FitnessClient { ClientCode = 1, Year = 2020, Month = 1, Hours = 10 },
            new FitnessClient { ClientCode = 2, Year = 2020, Month = 2, Hours = 8 },
            new FitnessClient { ClientCode = 1, Year = 2021, Month = 1, Hours = 12 },
            new FitnessClient { ClientCode = 2, Year = 2021, Month = 1, Hours = 9 },
            new FitnessClient { ClientCode = 2, Year = 2022, Month = 3, Hours = 11 },
        };

        int clientCodeToFind = 2; 

        var clientYears = fitnessClients
            .Where(c => c.ClientCode == clientCodeToFind)
            .GroupBy(c => c.Year)
            .Select(g => new { Year = g.Key, MinHours = g.Where(c => c.Hours > 0).Min(c => c.Hours), Month = g.Where(c => c.Hours > 0).First().Month })
            .OrderBy(y => y.MinHours)
            .ThenBy(y => y.Year);

        Console.WriteLine("\nЗадача 11: Сведения о клиентах фитнес-центра");
        foreach (var yearInfo in clientYears)
        {
            Console.WriteLine($"{yearInfo.MinHours} часа, Год: {yearInfo.Year}, Месяц: {yearInfo.Month}");
        }
    }
}
