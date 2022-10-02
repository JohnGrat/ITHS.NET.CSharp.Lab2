using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    public abstract class Shape2D : BaseShape
    {
        public abstract float Circumference { get; }
    }
}
