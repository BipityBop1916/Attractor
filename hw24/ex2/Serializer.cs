using System.Security.Cryptography;

namespace hw24;
using System.Text.Json;

public class Serializer
{
    public static void JsonAppend(CalculatedShape shape, string filename )
    {
        CalculatedShape[] shapes;
        
        if (File.Exists(filename) && new FileInfo(filename).Length > 0)
        {
            string json = File.ReadAllText(filename);
            shapes = JsonSerializer.Deserialize<CalculatedShape[]>(json) ?? Array.Empty<CalculatedShape>();
        }
        else
        {
            shapes = Array.Empty<CalculatedShape>();
        }
        
        var newShapes = shapes.Append(shape).ToArray();
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(filename, JsonSerializer.Serialize(newShapes, options));
    }
}

public class CalculatedShape
{
    public string Name { get; set; }
    public double Volume { get; set; }
    public double SurfaceArea  { get; set; }
}