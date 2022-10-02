using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Geometry.Shapes;

namespace Geometry
{
    public class Rectangle : Shape2D
    {

        private Vector3 _center;
        private Vector2 _size;

        public override float Circumference => 2 * (_center.Length() + _size.Length());

        public override float Area => _size.Y * _size.X;

        public override Vector3 Center => _center;

        public override string ToString()
        {
            return IsSquare() ? "rectangle" : "square" + $" {_center.X}, {_center.Y}): w = {_size.X}, h = {_size.Y}";
        }

        public bool IsSquare() => _size.X == _size.Y;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new Vector3(center, 0);
            _size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            _center = new Vector3(center, 0);
            _size = new Vector2(width, width);
        }

        //Rectangle(Shape2D)
        //Denna klass ska ha en konstruktor som tar parametrar: Vector2 center, Vector2
        //size(dvs.höjd/bredd), samt en alternativ konstruktor: Vector2 center, float width
        //(som sätter både höjd och bredd till samma värde).
        //Den ska även implementera en property IsSquare som returnerar true om höjd
        //och bredd är lika(annars false).
        //ToString() => “rectangle @(3.0, 4.0): w = 4.0, h = 5.0” (square om w == h). 
    }
}
