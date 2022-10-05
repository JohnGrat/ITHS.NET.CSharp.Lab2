// See https://aka.ms/new-console-template for more information

using Geometry;
using Geometry.Shapes;
using System.Drawing;
using System.Numerics;
using static Geometry.Types.Type;
using Rectangle = Geometry.Rectangle;

//Console.WriteLine((new Circle(new Vector2(3f, 2f), 5)).Circumference);
//Console.WriteLine((new Circle(new Vector2(3f, 2f), 5)).Area);

//Console.WriteLine((new Cuboid(new Vector3 (4 , 5 ,6 ), new Vector3(4, 5, 6)).Area));
//Console.WriteLine((new Cuboid(new Vector3 (4, 5, 6), new Vector3(4, 5, 6)).Volume));
//Console.WriteLine((new Cuboid(new Vector3 (4, 5, 6), new Vector3(4, 5, 6)).Center));


//Console.WriteLine((new Rectangle(new Vector2(3f, 2f), new Vector2(3f, 2f))).Area);
//Console.WriteLine((new Rectangle(new Vector2(3f, 2f), new Vector2(3f, 2f))).Circumference);


//Console.WriteLine((new Sphere(new Vector3(3f, 2f, 5f), 5)).Area);
//Console.WriteLine((new Sphere(new Vector3(3f, 2f, 5f), 5)).Volume);

//Console.WriteLine((new Triangle(new Vector2(1f, 8f), new Vector2(3f, 9f), new Vector2(7f, 9f))).Area);
//Console.WriteLine((new Triangle(new Vector2(1f, 8f), new Vector2(3f, 9f), new Vector2(7f, 9f))).Circumference);

BaseShape[] shapes = new BaseShape[20];

shapes = shapes.Select(x => x = BaseShape.GenerateShape()).ToArray();

Shape3D[] shape3D = shapes.Where(x => x.GetType().BaseType == typeof(Shape3D)).Cast<Shape3D>().ToArray();
float maxVolume = shape3D.MaxBy(x => x.Volume)!.Volume;
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
Console.WriteLine($"3D Shape with largest volume is: {maxVolume:f2}");
Console.WriteLine($"There most common shape is {avgShape.Key} and there are {avgShape.Count()} ");
Console.ReadKey(true);

