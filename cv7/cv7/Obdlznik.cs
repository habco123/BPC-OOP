using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Obdlznik : Object2D
    {
        public double length;
        public double width;

        public double Length
        {
            get {return length;}
            set
            {
                length = value;
                this.Area = Plocha();
            }
        }

        public Obdlznik(double length, double width)
        {
            this.length = length;
            this.width = width;
            this.Area = Plocha();
        }

        public override double Plocha()
        {
            return length * width;
        }

        public override string ToString()
        {
            return String.Format("{0} s plochou: {1:F4}", this.GetType().Name, this.Area);
        }

    }
}
