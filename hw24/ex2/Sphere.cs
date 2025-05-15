namespace hw24;

public struct Sphere : ICalculable
{
    public string Name {get;set;}
    public double Radius {get;set;}

    public Sphere(double radius)
    {
        Radius = radius;
        Name = "Sphere";
    }

    public double CalculateVolume()
    {
        return Math.PI * Radius * Radius * Radius * 4 / 3;
    }

    public double CalculateSurfaceArea()
    {
        return 4 * Math.PI * Radius * Radius;
    }
}

public struct Pyramid : ICalculable
{
    public string Name {get;set;}
    public double BaseLength {get;set;}
    public double BaseWidth {get;set;}
    public double Height {get;set;}

    public Pyramid(double baseLength, double baseWidth, double height)
    {
        BaseLength = baseLength;
        BaseWidth = baseWidth;
        Height = height;
        Name = "Pyramid";
    }

    public double CalculateVolume()
    {
        return BaseLength * BaseWidth * Height / 3;
    }

    public double CalculateSurfaceArea()
    {
        return BaseLength * BaseWidth + BaseLength * Math.Sqrt(Math.Pow(BaseWidth / 2, 2) + Math.Pow(Height, 2)) + BaseWidth * Math.Sqrt(Math.Pow(BaseLength, 2) + Math.Pow(Height, 2));
    }
}

public struct Cuboid : ICalculable
{
    public string Name { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Cuboid(double length, double width, double height)
    {
        Name = "Cuboid";
        Length = length;
        Width = width;
        Height = height;
    }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }

    public double CalculateSurfaceArea()
    {
        return 2 * Length * Width + 2 * Width * Height + 2 * Length * Height;
    }
}


public struct Cylinder : ICalculable
{
    public string Name { get; set; }
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cylinder(double radius, double height)
    {
        Name = "Cylinder";
        Radius = radius;
        Height = height;
    }

    public double CalculateVolume()
    {
        return Math.PI * Radius * Radius * Height;
    }

    public double CalculateSurfaceArea()
    {
        return 2 * Math.PI * Radius * Radius + 2 * Math.PI * Radius * Height;
    }
}

public struct Cone : ICalculable
{
    public string Name { get; set; }
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cone(double radius, double height)
    {
        Name = "Cone";
        Radius = radius;
        Height = height;
    }

    public double CalculateVolume()
    {
        return Math.PI * Radius * Radius * Height / 3;
    }

    public double CalculateSurfaceArea()
    {
        return Math.PI * Radius * (Radius + Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2)));
    }
}
