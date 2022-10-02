using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Geometry.Shapes;

namespace Geometry
{
    public class Circle : Shape2D
    {
        private Vector3 _center;
        private float _radius;

        public override float Circumference => (float)(2 * _radius * _radius * Math.PI);
        public override Vector3 Center => _center;
        public override float Area => (float)((_radius + _radius) * Math.PI);
        public override string ToString() => $"circle @({_center.X}, {_center.Y}): r = {_radius}";

        public Circle(Vector2 center, float radius)
        {
            _center = new(center, 0);
            _radius = radius;
        }
    }
}
