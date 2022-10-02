// See https://aka.ms/new-console-template for more information

using Geometry;
using System.Numerics;



Vector2 vector = new(5 , 5);

Console.WriteLine((new Circle(vector, 2).Circumference));
Console.WriteLine((new Rectangle(new Vector2(4 , 4), 2f )).Circumference);