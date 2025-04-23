using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cv11.EFCore
{
    internal class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

    }
}
