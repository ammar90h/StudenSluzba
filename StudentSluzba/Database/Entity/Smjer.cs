using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSluzba.Database.Entity
{
    public class Smjer
    {
        public int SmjerId { get; set; }

        public string Naziv { get; set; }

        public Fakultet Fakultet { get; set; }
        public int FakultetId { get; set; }
    }
}