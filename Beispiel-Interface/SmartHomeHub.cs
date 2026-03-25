namespace SmartHomeLegacy;

public class SmartHomeHub
{
    // Für jeden Gerätetyp wird eine eigene Liste benötigt.
    public List<Lamp> Lamps { get; set; } = new List<Lamp>();
    public List<Heater> Heaters { get; set; } = new List<Heater>();
    public List<Blinds> Blinds { get; set; } = new List<Blinds>();

    public void TurnOnEverything()
    {
        // Redundanter Code. Für jede neue Liste muss eine neue Schleife geschrieben werden.
        foreach (var lamp in Lamps)
        {
            lamp.TurnOn();
        }

        foreach (var heater in Heaters)
        {
            heater.TurnOn();
        }

        foreach (var blind in Blinds)
        {
            blind.TurnOn();
        }
    }

    public void TurnOffEverything()
    {
        foreach (var lamp in Lamps)
        {
            lamp.TurnOff();
        }

        foreach (var heater in Heaters)
        {
            heater.TurnOff();
        }

        foreach (var blind in Blinds)
        {
            blind.TurnOff();
        }
}