using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public abstract class Shape
    {
        public double[] side_size;
        public string name_shape;
        public Shape(double[] _side_size, string _name_shape)
        {
            side_size = _side_size;
            name_shape = _name_shape;
        }
        public abstract double countS();//массив, каждое значение которого, является длина ребра или радиус и тп..
    }
}
