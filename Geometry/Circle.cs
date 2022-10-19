using System.Numerics;
using Geometry.Shapes;
using Geometry.Types;

namespace Geometry
{
    public class Circle : Shape2D
    {
        private Vector3 _center;
        private float _radius;
        
        public override ShapeType Shape => ShapeType.Circle;
        public override float Circumference => (float)(2 *  _radius * Math.PI);
        public override Vector3 Center => _center;
        public override float Area => (float)((_radius * _radius) * Math.PI);
        public override string ToString() => $"Circle @({_center.X:f2}, {_center.Y:f2}): r = {_radius:f2}";

        public Circle(Vector2 center, float radius) 
        {
            _center = new(center, 0);
            _radius = radius;
        }
    }
}
