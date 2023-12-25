using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Parameters
{
    public class Position2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Position2D()
        {
            X = 0;
            Y = 0;
        }

        public Position2D(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
