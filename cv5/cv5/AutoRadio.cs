using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Autoradio
    {
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();
        public double NaladenyKmitocet {  get; set; }
        public bool Radiozapnute {  get; set; }


        public void NastavPredvolbu(int cislo, double frekvencia)
        {
            predvolby[cislo] = frekvencia;
        }

        public void PreladNaPredvolbu(int cislo)
        {
            NaladenyKmitocet = predvolby[cislo];
        }
    }
}
