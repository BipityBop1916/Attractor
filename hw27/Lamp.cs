namespace hw27;

public class Lamp
{
    public bool TurnedOn { get; set; }

    public string GetLampState() => TurnedOn ? "ON" : "OFF";
}

public class Cat
{
    public string GetCatState() => "CAT";
}

public class Man
{
    public string GetManState() => "MAN";
}