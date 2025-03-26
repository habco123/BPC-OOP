using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Trojuholnik : Object2D
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                sideA = value;
                this.Area = Plocha();
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                sideB = value;
                this.Area = Plocha();
            }
        }
        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                sideC = value;
                this.Area = Plocha();
            }
        }

        public Trojuholnik(double sizeA, double sizeB, double sizeC)
        {
            this.SideA = sizeA;
            this.SideB = sizeB;
            this.SideC = sizeC;
            this.Area = Plocha();
        }

        public override double Plocha()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override string ToString()
        {
            return String.Format("{0} s plochou: {1:F4}", this.GetType().Name, this.Area);
        }
    }
}
