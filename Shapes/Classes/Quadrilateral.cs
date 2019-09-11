using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public abstract class Quadrilateral : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }

        public Quadrilateral(string c, int s1, int s2, int s3, int s4) : base(c)
        {
            if (s1 < 1)
            { throw (new IntException("")); }
            if (s2 < 1)
            { throw (new IntException("")); }
            if (s3 < 1)
            { throw (new IntException("")); }
            if (s4 < 1)
            { throw (new IntException("")); }

            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
            Side4Length = s4;
            Colour = c;
        }

        public int GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }
}
