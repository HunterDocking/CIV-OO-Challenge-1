using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string c, float s1, float s2) : base(c, s1, s2, (float)Math.Sqrt(s1 * s1 + s2 * s2))
        {

        }

        public float GetArea()
        {
            return (float)(0.5 * Side1Length * Side2Length);
        }
    }
}
