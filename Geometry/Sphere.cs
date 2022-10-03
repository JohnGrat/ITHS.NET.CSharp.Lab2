using Geometry.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Sphere : Shape3D
    {
        private Vector3 _center;
        private float _radius;

        public override Vector3 Center => _center;
        public override float Area => MathF.PI * (MathF.Pow(_radius, 2));
        public override float Volume => _radius * _radius * _radius;

        public override string ToString() => $"sphere @({_center.X}, {_center.Y}, {_center.Z}): r = {_radius}";


        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }

    }
}
