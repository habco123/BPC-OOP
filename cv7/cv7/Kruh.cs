using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Kruh : Object2D
    {
        private double radius; 
        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Area = Plocha();
            }
        }

        public Kruh(double radius)
        {
            this.radius = radius;
            this.Area = this.Plocha();
        }

        public override double Plocha()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return String.Format("{0} s plochou: {1:F4}", this.GetType().Name, this.Area);
        }
    }
}
