using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string c, int s1, int s2) : base(c, s1, s2, s1, s2)
        {

        }

        public int GetArea()
        {
            return Side1Length * Side2Length;
        }
    }
}
