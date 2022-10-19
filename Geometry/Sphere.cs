using Geometry.Shapes;
using Geometry.Types;
using System.Numerics;

namespace Geometry
{
    public class Sphere : Shape3D
    {
        private Vector3 _center;
        private float _radius;

        public override ShapeType Shape => ShapeType.Sphere;
        public override Vector3 Center => _center;
        public override float Area => (float)(4 * Math.PI * _radius * _radius);
        public override float Volume => (float)(4.0 / 3 * Math.PI * _radius * _radius * _radius);
        public override string ToString() => $"Sphere @({_center.X:f2}, {_center.Y:f2}, {_center.Z:f2}): r = {_radius:f2}";

        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }
    }
}
