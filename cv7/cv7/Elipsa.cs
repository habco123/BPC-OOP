using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Elipsa : Object2D
    {
        private double radiusA;
        private double radiusB;

        public double RadiusA
        {
            get { return radiusA; }
            set
            {
                radiusA = value;
                this.Area = Plocha();
            }
        }

        public double RadiusB
        {
            get { return radiusB; }
            set
            {
                radiusB = value;
                this.Area = Plocha();
            }
        }

        public Elipsa(double radiusA, double radiusB)
        {
            this.radiusA = radiusA;
            this.radiusB = radiusB;
            this.Area = Plocha();
        }

        public override double Plocha()
        {
            return Math.PI * radiusA * radiusB;
        }
        public override string ToString()
        {
            return String.Format("{0} s plochou: {1:F4}", this.GetType().Name, this.Area);
        }

    }
}
