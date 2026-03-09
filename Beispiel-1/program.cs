using System;
using DecoratorPatternDemo.Components;
using DecoratorPatternDemo.Decorators;
using DecoratorPatternDemo.Interfaces;

class Program
{
    static void Main()
    {
        Console.WriteLine("Willkommen zum Kaffee-Bestellsystem!");
        ICoffee coffee = new PlainCoffee();

        bool ordering = true;
        while (ordering)
        {
            Console.WriteLine("\nAktuelle Bestellung: " + coffee.GetDescription());
            Console.WriteLine("Aktueller Preis: " + coffee.GetCost().ToString("F2") + " Euro");
            Console.WriteLine("\nMöchten Sie etwas hinzufügen?");
            Console.WriteLine("1. Milch (+0,50 Euro)");
            Console.WriteLine("2. Zucker (+0,20 Euro)");
            Console.WriteLine("3. Bestellung abschließen");
            Console.Write("Auswahl: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    coffee = new MilkDecorator(coffee);
                    Console.WriteLine("Milch wurde hinzugefügt.");
                    break;
                case "2":
                    coffee = new SugarDecorator(coffee);
                    Console.WriteLine("Zucker wurde hinzugefügt.");
                    break;
                case "3":
                    ordering = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl, bitte versuchen Sie es erneut.");
                    break;
            }
        }

        Console.WriteLine("\n--- Ihre endgültige Bestellung ---");
        Console.WriteLine("Bestellung: " + coffee.GetDescription());
        Console.WriteLine("Gesamtpreis: " + coffee.GetCost().ToString("F2") + " Euro");
        Console.WriteLine("Vielen Dank für Ihre Bestellung!");
    }
}