using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Geometry.Shapes;
using Geometry.Types;


namespace Geometry
{
    public class Rectangle : Shape2D
    {

        private Vector3 _center;
        private Vector2 _size;
        private ShapeType _shape;

        public override ShapeType Shape => _shape;

        public override float Circumference => 2 * (_size.X + _size.Y);

        public override float Area => _size.Y * _size.X;

        public override Vector3 Center => _center;

        public override string ToString()
        {
            return $"{(IsSquare() ? "Rectangle" : "Square")} {_center.X:f2}, {_center.Y:f2}): w = {_size.X:f2}, h = {_size.Y:f2}";
        }

        public bool IsSquare() => _size.X == _size.Y;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new Vector3(center, 0);
            _size = size;
            _shape = IsSquare() ? ShapeType.Rectangle : ShapeType.Square;
        }

        public Rectangle(Vector2 center, float width)
        {
            _center = new Vector3(center, 0);
            _size = new Vector2(width, width);
            _shape = ShapeType.Square;
        }
    }
}
