using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cv11.EFCore
{
    internal class Predmet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Zkratka { get; set; }
        public string Nazev { get; set; }



        public ICollection<StudentPredmet> StudentPredmety { get; set; }
        public ICollection<Hodnoceni> Hodnoceni { get; set; }
    }
}
