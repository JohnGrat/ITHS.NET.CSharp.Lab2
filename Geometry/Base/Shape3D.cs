using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    public abstract class Shape3D : BaseShape
    {
        public abstract float Volume { get; }
    }
}
