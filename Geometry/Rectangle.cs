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

        public override float Circumference => 2 * (_size.X + _size.Y);

        public override float Area => _size.Y * _size.X;

        public override Vector3 Center => _center;

        public override string ToString()
        {
            return $"{(IsSquare() ? "Cube" : "Cuboid")} {_center.X}, {_center.Y}): w = {_size.X}, h = {_size.Y}";
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
    }
}
