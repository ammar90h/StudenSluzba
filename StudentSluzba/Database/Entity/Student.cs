using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSluzba.Database.Entity
{
    public class Student
    {
        public int StudentId { get; set; }

        public string BrojIndeksa { get; set; }

        public Smjer Smjer { get; set; }
        public int SmjerId { get; set; }

    }
}