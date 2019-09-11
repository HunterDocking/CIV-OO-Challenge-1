using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public abstract class Shape
    {
        public string Colour;

        public Shape(string c)
        {
            Colour = c;
        }
    }
    public class IntException : Exception
    {
        public IntException(string message) : base("Int is less than 1")
        {

        }
    }
}