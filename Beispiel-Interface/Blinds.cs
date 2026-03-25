namespace SmartHomeLegacy;

public class Blinds
{
    public string RoomName { get; set; }

    public Blinds(string roomName)
    {
        RoomName = roomName;
    }

    public void TurnOn()
    {
        Console.WriteLine($"[Rollladen] in {RoomName} hochgefahren.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"[Rollladen] in {RoomName} heruntergefahren.");
    }
}