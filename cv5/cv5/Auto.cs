using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Auto
    {
        public enum TypPaliva
        {
            benzin,
            nafta
        }

        public double VelikostNadrze { get; protected set; }
        public double StavNadrze { get; private set; }
        public TypPaliva Palivo { get; protected set; }

        public Autoradio autoradio = new Autoradio();

        public Auto()
        {
            StavNadrze = 0.0;
        }

        public void Natankuj(TypPaliva palivo, double mnozstvoPaliva)
        {
            if(Palivo != palivo)
            {
                throw new Exception("Nespravny typ paliva");
            }

            if(mnozstvoPaliva+StavNadrze > VelikostNadrze)
            {
                throw new Exception("Vela Paliva");
            }

            StavNadrze += mnozstvoPaliva;
        }

        public double getFrekvencia()
        {
            return autoradio.NaladenyKmitocet;
        }

        public void setPredvolba(int cislo, double frekvencia)
        {
            autoradio.NastavPredvolbu(cislo, frekvencia);
        }

        public bool RadioOn()
        {
            return autoradio.Radiozapnute;
        }

        public void RadionSet(bool onOff)
        {
            autoradio.Radiozapnute = onOff;
        }

        public void setPreset(int cislo)
        {
            autoradio.PreladNaPredvolbu(cislo);
        }
    }
}