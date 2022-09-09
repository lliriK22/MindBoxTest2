using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Triangle : Shape
    {
        public Triangle(double[] _side_size, string _name_shape) : base(_side_size, _name_shape)
        {
        }

        public override double countS()
        {
            double p = (side_size[0] + side_size[1] + side_size[2]) / 2;
            return Math.Sqrt(p * (p - side_size[0]) * (p - side_size[1]) * (p - side_size[2]));
        }
    }
}
