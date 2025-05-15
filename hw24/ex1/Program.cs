using hw24;

class Program
{
    static void Main(string[] args)
    {
        
    }

    static void MaxShapes(ICalculable[] shapes)
    {
        double[] areas = new double[shapes.Length];
        double[] volumes = new double[shapes.Length];

        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurfaceArea();
            volumes[i] = shapes[i].CalculateVolume();
        }
        
        Console.WriteLine($"Largest surface area is the {shapes[areas.ToList().IndexOf(Double.MaxValue)].Name} with {areas.Max()}");
        Console.WriteLine($"Largest volume is the {shapes[volumes.ToList().IndexOf(Double.MaxValue)].Name} with {volumes.Max()}]");
    }
}