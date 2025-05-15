namespace hw24;

public interface ICalculable
{
    public string Name { get; }
    
    public double CalculateVolume();
    
    public double CalculateSurfaceArea();
}