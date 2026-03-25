namespace SmartHomeLegacy;

public class Heater
{
    public string RoomName { get; set; }

    public Heater(string roomName)
    {
        RoomName = roomName;
    }

    public void TurnOn()
    {
        Console.WriteLine($"[Heizung] in {RoomName} eingeschaltet. (Zieltemperatur: 22°C)");
    }

    public void TurnOff()
    {
        Console.WriteLine($"[Heizung] in {RoomName} ausgeschaltet.");
    }
}