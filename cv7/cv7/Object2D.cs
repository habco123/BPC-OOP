using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal abstract class Object2D : I2D, IComparable<Object2D>
    {
        public abstract double Plocha();

        protected double Area {  get; set; }

        public int CompareTo(Object2D obj)
        {
            if (obj == null) return 1;

            return this.Area.CompareTo(obj.Area);
        }

    }
}
