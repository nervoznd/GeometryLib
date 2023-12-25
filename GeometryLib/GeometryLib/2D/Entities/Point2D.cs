using GeometryLib.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Entities
{
    public class Point2D
    {
        public Position2D Position { get; }

        public Point2D()
        {
            Position = new Position2D();
        }
        public Point2D(Position2D position)
        {
            Position = position;
        }
        public Point2D(float x, float y)
        {
            Position = new Position2D(x, y);
        }

    }
}
