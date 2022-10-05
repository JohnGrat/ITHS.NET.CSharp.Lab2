// See https://aka.ms/new-console-template for more information

using Geometry;
using Geometry.Shapes;

BaseShape[] shapes = new BaseShape[20];

shapes = shapes.Select(x => x = BaseShape.GenerateShape()).ToArray();

Shape3D[] shape3D = shapes.OfType<Shape3D>().ToArray();
var maxShape3D = shape3D.MaxBy(x => x.Volume);

float triangleCrc = shapes.Where(x => x.GetType() == typeof(Triangle)).Cast<Triangle>().Select(x => x.Circumference).ToArray().Sum();
float avgArea = shapes.Select(x => x.Area).Average();
var avgShape = shapes.GroupBy(x => x.Shape).OrderByDescending(x => x.Count()).First();


Console.ForegroundColor = ConsoleColor.White;
foreach (var shape in shapes)
{
    Console.WriteLine(shape.ToString());
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Average Area:{avgArea:f2}");
Console.WriteLine($"Total Triangle Circumference:{triangleCrc:f2}");
Console.WriteLine($"3D Shape with largest volume is {maxShape3D.ToString()} and has volume: {maxShape3D.Volume:f2}");
Console.WriteLine($"There most common shape is {avgShape.Key} and there are {avgShape.Count()} ");
Console.ReadKey(true);

