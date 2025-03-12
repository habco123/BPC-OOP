using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Osobni : Auto
    {
        private int prepravovaneOsoby;
        public int MaxOsob { get; private set; }
        public int PrepravovaneOsoby
        {
            get
            {
                return prepravovaneOsoby;
            }

            set
            {
                if (value > MaxOsob)
                {
                    throw new Exception("Max limit osob auta prekroceny");
                }
                prepravovaneOsoby = value; 
            }
        }

        public Osobni(TypPaliva palivo, double velikostNadrze, int MaxOsob)
        {
            Palivo = palivo;
            VelikostNadrze = velikostNadrze;
            this.MaxOsob = MaxOsob;
            PrepravovaneOsoby = 0;
        }

        public void setPocetOsob(int cislo)
        {
            if(cislo+prepravovaneOsoby > MaxOsob)
            {
                throw new Exception("Neni miesto!");
            }
            prepravovaneOsoby = prepravovaneOsoby + cislo;
        }



        public override string ToString()
        {
            return String.Format("V aute je: {0} osob, stav paliva: {1}, typ paliva {2}, frekvencia: {3}", prepravovaneOsoby, StavNadrze, Palivo, getFrekvencia());
        }


    }
}
