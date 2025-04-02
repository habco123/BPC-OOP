using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cv8
{
    internal class ArchivTeplot
    {
        private SortedDictionary<int, RocniTeplota> _archiv = new SortedDictionary<int, RocniTeplota>();

        public void Load(string cesta)
        {
            var lines = File.ReadAllLines(cesta);
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                int rok = int.Parse(parts[0].Trim());

                var teploty = parts[1].Split(';')
                    .Select(t => double.Parse(t.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture))
                    .ToList();

                _archiv[rok] = new RocniTeplota(rok, teploty);
            }
        }


        public void Save(string cesta)
        {
            using (var writer = new StreamWriter(cesta))
            {
                foreach (var rocniTeplota in _archiv.Values)
                {
                    string line = $"{rocniTeplota.Rok}: {string.Join("; ", rocniTeplota.MesicniTeploty)}";
                    writer.WriteLine(line);
                }
            }
        }

        public void Kalibrace(double konstanta)
        {
            foreach (var rocniTeplota in _archiv.Values)
            {
                for (int i = 0; i < rocniTeplota.MesicniTeploty.Count; i++)
                {
                    rocniTeplota.MesicniTeploty[i] = Math.Round(rocniTeplota.MesicniTeploty[i] + konstanta, 2);
                }
            }
        }

        public RocniTeplota Vyhledej(int rok)
        {
            if (_archiv.ContainsKey(rok))
            {
                RocniTeplota rocniTeplota = _archiv[rok];

                Console.WriteLine($"Teploty pro rok {rocniTeplota.Rok}:");
                Console.WriteLine(string.Join(", ", rocniTeplota.MesicniTeploty.Select(t => t.ToString("F2"))));

                return rocniTeplota;
            }
            else
            {
                Console.WriteLine($"Rok {rok} nebyl nalezen v archivu.");
                return null;
            }
        }

        public void TiskTeplot()
        {
            foreach (var rocniTeplota in _archiv.Values)
            {
                string teplotyStr = string.Join("; ", rocniTeplota.MesicniTeploty);
                Console.WriteLine($"{rocniTeplota.Rok}: {teplotyStr}");
            }
        }

        public void TiskPrumernychRocnichTeplot()
        {
            foreach (var rocniTeplota in _archiv.Values)
            {
                Console.WriteLine($"{rocniTeplota.Rok}, {rocniTeplota.PrumRocniTeplota:F2}");
            }
        }

        public void TiskPrumernychMesicnichTeplot()
        {
            List<double> prumerneTeploty = new List<double>();

            for (int mesic = 0; mesic < 12; mesic++)
            {
                double sumaTeplot = 0;
                int pocetRoku = 0;

                foreach (var rocniTeplota in _archiv.Values)
                {
                    sumaTeplot += rocniTeplota.MesicniTeploty[mesic];
                    pocetRoku++;
                }
                if (pocetRoku > 0)
                {
                    double prumernaTeplota = sumaTeplot / pocetRoku;
                    prumerneTeploty.Add(prumernaTeplota);
                }
            }

            Console.WriteLine("prům: " + string.Join(", ", prumerneTeploty.Select(t => t.ToString("F2"))));
        }
    }
}
