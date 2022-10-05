using Geometry.Shapes;
using Geometry.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Geometry
{
    public class Cuboid : Shape3D
    {

        private Vector3 _center;
        private Vector3 _size;
        private ShapeType _shape;

        public override ShapeType Shape => _shape;
        public override Vector3 Center => _center;
        public override float Area => 2 * (_size.X * _size.Y + _size.Y * _size.Z + _size.Z * _size.X);
        public override float Volume => _size.Y * _size.X * _size.Z;

        public override string ToString() => $"{(IsCube() ? "Cube" : "Cuboid")} @({_center.X:f2}, {_center.Y:f2}): w = {_size.X:f2}, h = {_size.Y:f2}, l = {_size.Z:f2}";

        public bool IsCube() => _size.X == _size.Y && _size.Y == _size.Z;

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
            _shape = IsCube() ? ShapeType.Cube : ShapeType.Cuboid;
        }

        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _size = new Vector3(width, width, width);
            _shape = ShapeType.Cube;
        }       

    }
}
