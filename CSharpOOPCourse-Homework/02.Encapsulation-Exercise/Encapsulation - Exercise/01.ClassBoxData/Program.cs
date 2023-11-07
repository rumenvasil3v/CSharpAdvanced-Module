using _01.ClassBoxData.Models;

double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

try
{
    Box box = new Box(length, width, height);

    double surfaceArea = box.SurfaceArea();
    Console.WriteLine($"Surface Area - {surfaceArea:F2}");

    double lateralSurfaceArea = box.LateralSurfaceArea();
    Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");

    double volume = box.Volume();
    Console.WriteLine($"Volume - {volume:F2}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}