using Microsoft.EntityFrameworkCore;
using cv11.EFCore;

namespace cv11
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Vyukacontext())
            {
                context.Database.Migrate();

                InitializeDatabaseWithSampleData(context);

                GetPredmetyWithStudentCount(context);

                var predmetId = "MAT01";
                var studentId = 2;

                var studentiPredmetu = StudentiPredmetu(context, predmetId);
                Console.WriteLine($"Studenti v předmětu {predmetId}:");
                foreach (var student in studentiPredmetu)
                {
                    Console.WriteLine($"- {student.Jmeno} {student.Prijmeni}");
                }

                var predmetyStudenta = PredmetyStudenta(context, studentId);
                Console.WriteLine($"Předměty studenta {studentId}:");
                foreach (var predmet in predmetyStudenta)
                {
                    Console.WriteLine($"- {predmet.Zkratka}");
                }

                GetPredmetyWithAverageGrade(context);
            }
        }

        static void InitializeDatabaseWithSampleData(Vyukacontext context)
        {
            context.Database.EnsureCreated();


            if (!context.Students.Any(s => s.StudentId == 1))
                context.Students.Add(new Student { StudentId = 1, Jmeno = "Eva", Prijmeni = "Nováková", DatumNarozeni = new DateTime(2000, 5, 12) });

            if (!context.Students.Any(s => s.StudentId == 2))
                context.Students.Add(new Student { StudentId = 2, Jmeno = "Jan", Prijmeni = "Horák", DatumNarozeni = new DateTime(1999, 8, 24) });

            if (!context.Students.Any(s => s.StudentId == 3))
                context.Students.Add(new Student { StudentId = 3, Jmeno = "Jan", Prijmeni = "Urban", DatumNarozeni = new DateTime(1989, 12, 2) });


            if (!context.Predmety.Any(p => p.Zkratka == "MAT01"))
                context.Predmety.Add(new Predmet { Zkratka = "MAT01", Nazev = "Matematika" });

            if (!context.Predmety.Any(p => p.Zkratka == "FYZ01"))
                context.Predmety.Add(new Predmet { Zkratka = "FYZ01", Nazev = "Fyzika" });

            

            if (!context.StudentPredmet.Any(sp => sp.StudentId == 1 && sp.Zkratka == "MAT01"))
                context.StudentPredmet.Add(new StudentPredmet { StudentId = 1, Zkratka = "MAT01" });

            if (!context.StudentPredmet.Any(sp => sp.StudentId == 2 && sp.Zkratka == "FYZ01"))
                context.StudentPredmet.Add(new StudentPredmet { StudentId = 2, Zkratka = "FYZ01" });

            if (!context.StudentPredmet.Any(sp => sp.StudentId == 2 && sp.Zkratka == "MAT01"))
                context.StudentPredmet.Add(new StudentPredmet { StudentId = 2, Zkratka = "MAT01" });

            if (!context.StudentPredmet.Any(sp => sp.StudentId == 3 && sp.Zkratka == "FYZ01"))
                context.StudentPredmet.Add(new StudentPredmet { StudentId = 3, Zkratka = "FYZ01" });


            if (!context.Hodnotenie.Any(h => h.StudentId == 1 && h.ZkratkaPredmet == "MAT01"))
                context.Hodnotenie.Add(new Hodnoceni { StudentId = 1, ZkratkaPredmet = "MAT01", Datum = DateTime.Today, Znamka = 1.5 });

            if (!context.Hodnotenie.Any(h => h.StudentId == 2 && h.ZkratkaPredmet == "FYZ01"))
                context.Hodnotenie.Add(new Hodnoceni { StudentId = 2, ZkratkaPredmet = "FYZ01", Datum = DateTime.Today, Znamka = 2.0 });

            if (!context.Hodnotenie.Any(h => h.StudentId == 2 && h.ZkratkaPredmet == "MAT01"))
                context.Hodnotenie.Add(new Hodnoceni { StudentId = 2, ZkratkaPredmet = "MAT01", Datum = DateTime.Today, Znamka = 1.8 });

            if (!context.Hodnotenie.Any(h => h.StudentId == 3 && h.ZkratkaPredmet == "FYZ01"))
                context.Hodnotenie.Add(new Hodnoceni { StudentId = 3, ZkratkaPredmet = "FYZ01", Datum = DateTime.Today, Znamka = 2.3 });

            context.SaveChanges();
        }

            static void GetPredmetyWithAverageGrade(Vyukacontext context)
        {
            var predmetyPrumery = context.Hodnotenie
                .GroupBy(h => h.ZkratkaPredmet)
                .Select(g => new
                {
                    ZkratkaPredmetu = g.Key,
                    PrumernaZnamka = g.Average(h => h.Znamka)
                })
                .ToList();

            foreach (var predmet in predmetyPrumery)
            {
                Console.WriteLine($"Předmět: {predmet.ZkratkaPredmetu}, Průměrná známka: {predmet.PrumernaZnamka:F2}");
            }
        }


            static IEnumerable<Student> StudentiPredmetu(Vyukacontext context, string predmetId)
        {
            return context.StudentPredmet
                .Where(sp => sp.Zkratka == predmetId)
                .Join(context.Students, sp => sp.StudentId, s => s.StudentId, (sp, s) => s)
                .ToList();
        }

        static IEnumerable<Predmet> PredmetyStudenta(Vyukacontext context, int studentId)
        {
            return context.StudentPredmet
                .Where(sp => sp.StudentId == studentId)
                .Join(context.Predmety, sp => sp.Zkratka, p => p.Zkratka, (sp, p) => p)
                .ToList();
        }

        static void GetPredmetyWithStudentCount(Vyukacontext context)
        {
            var predmety = context.StudentPredmet
                .GroupBy(sp => sp.Zkratka)  
                .Select(g => new
                {
                    Predmet = g.Key,  
                    PocetStudentu = g.Count()  
                })
                .OrderByDescending(p => p.PocetStudentu)  
                .ToList();  

            foreach (var predmet in predmety)
            {
                Console.WriteLine($"Předmět: {predmet.Predmet}, Počet studentů: {predmet.PocetStudentu}");
            }
        }

    }
}

