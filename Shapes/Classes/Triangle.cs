using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public abstract class Triangle : Shape
    {
        public float Side1Length { get; set; }
        public float Side2Length { get; set; }
        public float Side3Length { get; set; }

        public Triangle(string c, float s1, float s2, float s3) : base(c)
        {
            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
            Colour = c;
        }

        public float GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }
    }
}
