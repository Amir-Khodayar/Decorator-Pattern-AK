namespace SmartHomeLegacy;

public class Lamp
{
    public string RoomName { get; set; }

    public Lamp(string roomName)
    {
        RoomName = roomName;
    }

    public void TurnOn()
    {
        Console.WriteLine($"[Lampe] in {RoomName} eingeschaltet.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"[Lampe] in {RoomName} ausgeschaltet.");
    }
}
}