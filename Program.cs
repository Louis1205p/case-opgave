using System;
using System.Collections.Generic;
using System.Linq;
using Case_Opgave;

class Program
{
    static void Main()
    {
        var lærerListe = new List<Lærer>
        {
            new Lærer { Id = 1, Navn = "Niels Olsen" },
            new Lærer { Id = 2, Navn = "Henrik Paulsen" }
        };

        var fagListe = new List<Fag>
        {
            new Fag { Id = 1, Navn = "grundlæggende programmering", Lærer = lærerListe[0], Elever = new List<Elev>
            {
                new Elev { Navn = "Sebastian Tølbøl Nielsen", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Andreas Lorenzen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Casper Clemmensen", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Daniel Bjerre Jensen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Hjalte Moesgaard Leth", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Johan Milter Jakobsen", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Louis Thomas Dao Pedersen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Lukas Haugstad Frederiksen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Marcus Wahlstrøm", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Marcus Slot Rohr", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Marius Ulslev Fogelgren", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Mathias Altenburg", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Patrick Gutierrez Fogelstrøm", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Ramtin Akbari", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Simon Heilbuth", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Thobias Svarter Hammarkvist", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Yosef Kasasput", Fødselsdato = new DateTime(2007, 1, 1) },
            }},
            new Fag { Id = 2, Navn = "objektiv programmering", Lærer = lærerListe[1], Elever = new List<Elev>
            {
                new Elev { Navn = "Sebastian Tølbøl Nielsen", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Andreas Lorenzen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Casper Clemmensen", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Daniel Bjerre Jensen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Hjalte Moesgaard Leth", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Johan Milter Jakobsen", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Louis Thomas Dao Pedersen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Lukas Haugstad Frederiksen", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Marcus Wahlstrøm", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Marcus Slot Rohr", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Marius Ulslev Fogelgren", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Mathias Altenburg", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Patrick Gutierrez Fogelstrøm", Fødselsdato = new DateTime(2007, 1, 1) },
                new Elev { Navn = "Ramtin Akbari", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Simon Heilbuth", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Thobias Svarter Hammarkvist", Fødselsdato = new DateTime(2000, 1, 1) },
                new Elev { Navn = "Yosef Kasasput", Fødselsdato = new DateTime(2007, 1, 1) },
            }}
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Vælg søgningskriterie:");
            Console.WriteLine("1. Søg på Lærer");
            Console.WriteLine("2. Søg på Elev");
            Console.WriteLine("3. Søg på Fag");
            Console.WriteLine("4. Afslut");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    SøgPåLærer(lærerListe, fagListe);
                    break;
                case "2":
                    SøgPåElev(fagListe);
                    break;
                case "3":
                    SøgPåFag(fagListe);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }

            Console.WriteLine("\nØnsker du at foretage en ny søgning? (y/n)");
            if (Console.ReadLine()?.ToLower() != "y") break;
        }
    }
    static void SøgPåLærer(List<Lærer> lærerListe, List<Fag> fagListe)
    {
        Console.WriteLine("1. Niels Olsen");
        Console.WriteLine("2. Henrik Paulsen");
        Console.WriteLine("Indtast lærerens ID:");
        int id = int.Parse(Console.ReadLine());

        var lærer = lærerListe.FirstOrDefault(l => l.Id == id);
        if (lærer != null)
        {
            Console.WriteLine($"Lærer: {lærer.Navn}");
            var fagForLærer = fagListe.Where(f => f.Lærer == lærer).ToList();
            foreach (var fag in fagForLærer)
            {
                Console.WriteLine($"Fag: {fag.Navn} - Elever tilmeldt: {fag.Elever.Count}");
                foreach (var elev in fag.Elever.OrderBy(e => e.Navn))
                {
                    var alder = (DateTime.Now - elev.Fødselsdato).Days / 365;
                    if (alder < 20)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{elev.Navn} (Alder: {alder})");
                    Console.ResetColor();
                }
            }
        }
        else
        {
            Console.WriteLine("Ingen lærer fundet med det ID.");
        }
    }

    static void SøgPåElev(List<Fag> fagListe)
    {
        Console.WriteLine("Indtast elevens fulde navn:");
        string navn = Console.ReadLine();

        var elevFag = fagListe.Select(f => new { Fag = f.Navn, Lærer = f.Lærer.Navn, Elev = f.Elever.FirstOrDefault(e => e.Navn.Contains(navn)) })
                              .Where(x => x.Elev != null)
                              .ToList();

        if (elevFag.Any())
        {
            foreach (var item in elevFag)
            {
                Console.WriteLine($"Fag: {item.Fag}, Lærer: {item.Lærer}");
            }
        }
        else
        {
            Console.WriteLine("Ingen elev fundet med dette navn.");
        }
    }

    static void SøgPåFag(List<Fag> fagListe)
    {
        Console.WriteLine("1. Objektiv prg");
        Console.WriteLine("2. Grundlæggende prg");
        Console.WriteLine("Indtast fagets ID:");
        int id = int.Parse(Console.ReadLine());

        var fag = fagListe.FirstOrDefault(f => f.Id == id);
        if (fag != null)
        {
            Console.WriteLine($"Fag: {fag.Navn} - Lærer: {fag.Lærer.Navn}");
            Console.WriteLine($"Elever tilmeldt: {fag.Elever.Count}");
            foreach (var elev in fag.Elever.OrderBy(e => e.Navn))
            {
                var alder = (DateTime.Now - elev.Fødselsdato).Days / 365;
                if (alder < 20)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{elev.Navn} (Alder: {alder})");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("Ingen fag fundet med det ID.");
        }
    }
}
