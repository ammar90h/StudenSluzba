using StudentSluzba.Database.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSluzba.Database.Entity
{
    public class UpisGodine : IHasLastModified
    {
        public int UpisGodineId { get; set; }

        public DateTime? DatumUpisa { get; set; }
        public int GodinaStudija { get; set; }


        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int AkademskaGodinaId { get; set; }
        public virtual AkademskaGodina AkademskaGodina { get; set; }
    }

}