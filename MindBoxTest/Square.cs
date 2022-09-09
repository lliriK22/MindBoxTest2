using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Square : Shape
    {
        public Square(double[] _side_size, string _name_shape) : base(_side_size, _name_shape)
        {
        }

        public override double countS()
        {
            return Math.Pow(side_size[0], 2);
        }
    }
}
