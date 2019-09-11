using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string c, float s1) : base(c, s1, s1, s1)
        {

        }

        public float GetArea()
        {
            return (float)((Math.Sqrt(3) / 4) * (Side1Length * Side1Length));
        }
    }
}
