using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ClassLibrary
{
    struct DataItem
    {
        public Vector2 Vector { get; set; }
        public Complex Complex { get; set; }

        public DataItem(Vector2 vector, Complex complex)
        {
            Vector = vector;
            Complex = complex;
        }

        public override string ToString()
        {
            return "Vector: " + Vector.X.ToString() + " " + Vector.Y.ToString() + " " +
                   "Complex: " + Complex.ToString();
        }

        public string ToString(string format)
        {
            return "Vector: " + Vector.X.ToString(format) + " " + Vector.Y.ToString(format) + " " +
                   "Complex: " + Complex.ToString(format);
        }

    }
}
