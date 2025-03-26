using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Stvorec : Object2D
    {
        private double size;
        public double Size
        {
            get { return size; }
            set
            {
                size = value;
                this.Area = Plocha();
            }
        }

        public Stvorec(double size)
        {
            this.size = size;
            this.Area = Plocha();
        }

        public override double Plocha()
        {
            return size * size  ;
        }

        public override string ToString()
        {
            return String.Format("{0} s plochou: {1:F4}", this.GetType().Name, this.Area);
        }

    }
}
