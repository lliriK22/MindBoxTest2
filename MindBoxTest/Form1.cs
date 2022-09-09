using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindBoxTest
{
    public partial class Form1 : Form
    {
        private Shape shape;
        private string name_shape;
        private List<NumericUpDown> numeric_list;
        public Form1()
        {
            InitializeComponent();
            numeric_list = new List<NumericUpDown>();
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            double[] nums_side = new double[numeric_list.Count];

            for (int i = 0; i < nums_side.Length; i++)
            {
                nums_side[i] = (int)(numeric_list[i].Value);
            }

            switch(name_shape)
            {
                case "Circle":
                    shape = new Circle(nums_side, name_shape);
                    break;
                case "Triangle":
                    shape = new Triangle(nums_side, name_shape);
                    break;
                case "Square":
                    shape = new Square(nums_side, name_shape);
                    break;
            }

            ResultLabel.Text = shape.countS().ToString();
        }

        private void TriangleBtn_CheckedChanged(object sender, EventArgs e)
        {
            clearRadioBtn();
            createNumInput(3, "Triangle");
        }

        private void CircleBtn_CheckedChanged(object sender, EventArgs e)
        {
            clearRadioBtn();
            createNumInput(1, "Circle");
        }

        private void SquareBtn_CheckedChanged(object sender, EventArgs e)
        {
            clearRadioBtn();
            createNumInput(1, "Square");
        }

        private void clearRadioBtn()
        {
            foreach (var obj in numeric_list)
            {
                this.Controls.Remove(obj);
            }

            numeric_list.Clear();
        }

        private void createNumInput(int count, string name)
        {
            for(int i = 0; i < count; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Width = 120;
                num.Height = 25;
                num.Name = name;
                num.Location = new Point(10, 115 + (25 * (i + 1)));
                numeric_list.Add(num);
                this.Controls.Add(num);
            }

            name_shape = name;
        }
    }
}
