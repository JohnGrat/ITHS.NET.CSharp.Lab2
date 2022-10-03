// See https://aka.ms/new-console-template for more information

using Geometry;
using System.Numerics;



Vector2 vector = new(5 , 5);

Console.WriteLine((new Circle(vector, 2).Circumference));
Console.WriteLine((new Rectangle(new Vector2(4 , 4), 2 )).ToString());


Console.WriteLine(Vector2.Distance(new Vector2(8, 8) , new Vector2(12, 12)));
Console.WriteLine(MathF.Sqrt(MathF.Pow(12 - 8, 2) + MathF.Pow(8 - 12, 2)));

Console.WriteLine((new Triangle(new Vector2(2, 6), new Vector2(6, 5), new Vector2(12, 6)).Area));



