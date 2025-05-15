using hw24;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        string[] shapes = { "sphere", "pyramid", "cuboid", "cylinder", "cone", "exit" };
        ICalculable shape = new Sphere();
        bool valid = true;

        while (true)
        {
            while (true)
            {
                Console.WriteLine("Enter shape: (sphere, pyramid, cuboid, cylinder, cone) or exit");
                input = Console.ReadLine();

                if (!shapes.Contains(input))
                {
                    Console.WriteLine("Invalid shape");
                }
                else
                {
                    break;
                }
            }

            switch (input)
            {
                case "sphere":
                    Sphere sphere = new Sphere();

                    try
                    {
                        Console.WriteLine("Enter radius: ");
                        sphere.Radius = double.Parse(Console.ReadLine());
                        sphere.Name = "Sphere";
                        shape = sphere;
                    }
                    catch
                    {
                        valid = false;
                        Console.WriteLine("Invalid input");
                    }

                    break;

                case "pyramid":
                    Pyramid pyramid = new Pyramid();

                    try
                    {
                        Console.WriteLine("Enter base length: ");
                        pyramid.BaseLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter base width: ");
                        pyramid.BaseWidth = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height: ");
                        pyramid.Height = double.Parse(Console.ReadLine());
                        pyramid.Name = "Pyramid";
                        shape = pyramid;
                    }
                    catch
                    {
                        valid = false;
                        Console.WriteLine("Invalid input");
                    }

                    break;

                case "cuboid":
                    Cuboid cuboid = new Cuboid();

                    try
                    {
                        Console.WriteLine("Enter length: ");
                        cuboid.Length = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter width: ");
                        cuboid.Width = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height: ");
                        cuboid.Height = double.Parse(Console.ReadLine());
                        cuboid.Name = "Cuboid";
                        shape = cuboid;
                    }
                    catch
                    {
                        valid = false;
                        Console.WriteLine("Invalid input");
                    }

                    break;

                case "cylinder":
                    Cylinder cylinder = new Cylinder();

                    try
                    {
                        Console.WriteLine("Enter radius: ");
                        cylinder.Radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height : ");
                        cylinder.Height = double.Parse(Console.ReadLine());
                        cylinder.Name = "Cylinder";
                        shape = cylinder;
                    }
                    catch
                    {
                        valid = false;
                        Console.WriteLine("Invalid input");
                    }

                    break;

                case "cone":
                    Cone cone = new Cone();

                    try
                    {
                        Console.WriteLine("Enter radius: ");
                        cone.Radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height: ");
                        cone.Height = double.Parse(Console.ReadLine());
                        cone.Name = "Cone";
                        shape = cone;
                    }
                    catch
                    {
                        valid = false;
                        Console.WriteLine("Invalid input");
                    }


                    break;
                
                case "exit":
                    goto Exit;
            }

            if (valid)
            {
                Console.WriteLine("Shape | Volume | Area");
                Console.WriteLine("------+--------+------");
                Console.WriteLine($"{shape.Name} | {shape.CalculateVolume()} | {shape.CalculateSurfaceArea()}");
                Serializer.JsonAppend(new CalculatedShape{ Name = shape.Name, Volume = shape.CalculateVolume(), SurfaceArea = shape.CalculateSurfaceArea()}, "../../../data/info.json");
            }
        }

        Exit: ;
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