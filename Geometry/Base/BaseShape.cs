using System.Diagnostics.Metrics;
using System;
using System.Numerics;
using System.Linq.Expressions;

namespace Geometry.Shapes
{
    public abstract class BaseShape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static BaseShape GenerateShape()
        {
            Random random = new Random();
            int i = random.Next(0, 6);

            Vector2 center2D = GenerateRandomVector2();
            Vector3 center3D = GenerateRandomVector3();

            return i switch
            {
                0 => new Circle(center2D, random.Next()),
                1 => new Cuboid(center3D, random.Next()), //Cube
                2 => new Cuboid(center3D, GenerateRandomVector3()),
                3 => new Rectangle(center2D, GenerateRandomVector2()),
                4 => new Rectangle(center2D, random.Next()), //Square
                5 => new Sphere(center3D, random.Next()),
                6 => new Triangle(GenerateRandomVector2(), GenerateRandomVector2(), GenerateRandomVector2()),
            };
        }

        private static Vector2 GenerateRandomVector2()
        {
            Random random = new Random();
            return new Vector2(random.Next(), random.Next());
        }

        private static Vector3 GenerateRandomVector3()
        {
            Random random = new Random();
            return new Vector3(random.Next(), random.Next(), random.Next());
        }

    }



//Lägg till metod för att generera random shapes
//När ni är klara med alla klasser ska ni lägga till en publik statisk metod
//GenerateShape i basklassen Shape.Denna metod ska slumpa ett tal 0-5 (VG: 0-6) 
//för att instantiera en av 6 (VG: 7) figurer: circle, rectangle, square, (VG: triangle), 
//cuboid, cube, sphere; och returnera i form av en Shape.
//De olika figurernas värden ska också slumpas.GenerateShape kommer alltså
//behöva anropa konstruktorn för de olika klasserna med randomvärden på alla
//parameterar.
}