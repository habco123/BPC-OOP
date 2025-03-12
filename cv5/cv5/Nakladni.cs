using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Nakladni : Auto
    {
        private double prepravovanyNaklad;
        public double MaxNaklad;
        public double PrepravovanyNaklad
        {
            get
            {
                return prepravovanyNaklad;
            }
            set
            {
                if(value > MaxNaklad)
                {
                    throw new Exception("Naklad prekrocil limit");
                }
                prepravovanyNaklad = value;
            }
        }

        public Nakladni(TypPaliva palivo, double velikostNadrze,  double maxVelikostNaklad)
        {
            Palivo = palivo;
            VelikostNadrze = velikostNadrze;
            MaxNaklad = maxVelikostNaklad;
            PrepravovanyNaklad = 0;
        }
        
        public void setNaklad(double cislo)
        {
            prepravovanyNaklad = cislo;
        }


        public override string ToString()
        {
            return String.Format("V aute je: {0}kg nakladu, stav paliva: {1}, typ paliva {2},frekvencia: {3}", prepravovanyNaklad, StavNadrze, Palivo, getFrekvencia());
        }

    }
}
