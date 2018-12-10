namespace StudentSluzba.Migrations
{
    using StudentSluzba.Database.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSluzba.Database.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentSluzba.Database.DataContext";

        }

        protected override void Seed(StudentSluzba.Database.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Seed employees
            context.Korisnici.AddOrUpdate(item => item.KorisnikId,
                new Korisnik { KorisnikId = 1, Ime = "Ammar", Prezime = "Hakanovic", KorisnickoIme = "gunner", Lozinka = "1234" });

            context.Student.AddOrUpdate(item => item.StudentId,
                    new Student { StudentId = 1, BrojIndeksa = "123b", SmjerId = 1 });

            context.Fakultet.AddOrUpdate(item => item.FakultetId,
                new Fakultet { FakultetId = 1, Naziv = "Ekonomski Fakultet" });

            context.Smjer.AddOrUpdate(item => item.SmjerId,
                new Smjer { SmjerId = 1, Naziv = "Mendzment Preduzeca", FakultetId = 1 });

            context.AkademskaGodina.AddOrUpdate(item => item.AkademskaGodinaId,
                new AkademskaGodina { AkademskaGodinaId = 1, Opis = "2018/2019" });

            context.UpisGodine.AddOrUpdate(item => item.UpisGodineId,
                new UpisGodine { UpisGodineId = 1, AkademskaGodinaId = 1, StudentId = 1, GodinaStudija = 1 });
        }

    }
}
