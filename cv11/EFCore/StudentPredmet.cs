using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cv11.EFCore
{
    internal class StudentPredmet
    {
        public int StudentId { get; set; }
        public string Zkratka {  get; set; }

        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
