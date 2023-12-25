using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Entities
{
    public class Line2D
    {
        public Point2D StartPoint { get; set; }
        public Point2D EndPoint { get; set; }

        public float GetProjectionX()
        {
            return Math.Abs(StartPoint.Position.X - EndPoint.Position.X);
        }
        public float GetProjectionY()
        {
            return Math.Abs(StartPoint.Position.Y - EndPoint.Position.Y);
        }
        public float GetLength()
        {
            return (float)Math.Sqrt(Math.Pow(GetProjectionX(), 2) + Math.Pow(GetProjectionY(), 2));
        }
    }
}
