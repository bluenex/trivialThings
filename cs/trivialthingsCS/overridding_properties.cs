using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trivialthingsCS
{
    abstract class Shape
    {
        public abstract double Area
        {
            get;
            set;
        }
    }

    class Square : Shape
    {
        public double side;

        // Constructor:
        public Square(double s)
        {
            side = s;
        }

        // The Area property
        public override double Area
        {
            get
            {
                return side * side;
            }
            set
            {
                // Given the area, compute the side
                side = Math.Sqrt(value);
            }
        }
    }

    class Cube : Shape
    {
        public double side;

        // Constructor:
        public Cube(double s)
        {
            side = s;
        }

        // The Area property
        public override double Area
        {
            get
            {
                return 6 * side * side;
            }
            set
            {
                // Given the area, compute the side
                side = Math.Sqrt(value / 6);
            }
        }
    }
}
