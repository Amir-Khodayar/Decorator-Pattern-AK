using System;
namespace SmartHomeLegacy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Smart Home System ===\n");
 
        var hub = new SmartHomeHub();
 
        // Geräte zum Hub hinzufügen
        hub.Lamps.Add(new Lamp("Wohnzimmer"));
        hub.Lamps.Add(new Lamp("Küche"));
       
        hub.Heaters.Add(new Heater("Badezimmer"));
        hub.Heaters.Add(new Heater("Schlafzimmer"));
       
        hub.Blinds.Add(new Blinds("Wohnzimmer"));
 
        // System steuern
        Console.WriteLine("--> Szenario: Haus verlassen");
        hub.TurnOffEverything();
 
        Console.WriteLine("\n--> Szenario: Nach Hause kommen");
        hub.TurnOnEverything();
 
        Console.ReadLine();
    }
}

}