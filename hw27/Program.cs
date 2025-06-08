namespace hw27;

public delegate string Status();


class Program
{
    static void Main(string[] args)
    {
        Lamp lamp = new Lamp();
        Cat cat = new Cat();
        Man man = new Man();

        Status reader = lamp.GetLampState;
        reader += cat.GetCatState;
        reader += man.GetManState;
        
        ReadState(reader);
    }

    public static void ReadState(Status status)
    {
        foreach (Delegate d in status.GetInvocationList())
        {
            string result = (string)d.DynamicInvoke();
            Console.WriteLine(result);
        }
    }
}