using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSluzba.Database.Entity
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public DateTime? DatumRodjenja { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

      
    }
}