using System.Numerics;

namespace Geometry.Shapes
{
    public abstract class BaseShape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }
}