using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class Square : Quadrilateral
    {
        public Square(string c, int s1) : base(c, s1, s1, s1, s1)
        {

        }

        public int GetArea()
        {
            return Side1Length * Side1Length;
        }
    }
}