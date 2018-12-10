using StudentSluzba.Database.Entity;
using StudentSluzba.Database.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace StudentSluzba.Database
{
    public class DataContext : DbContext
    {
        public DataContext() :
            base ("SluzbaDb")
        {
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<AkademskaGodina> AkademskaGodina { get; set; }
        public DbSet<Fakultet> Fakultet { get; set; }
        public DbSet<Smjer> Smjer { get; set; }
        public DbSet<UpisGodine> UpisGodine { get; set; }
        public DbSet<Student> Student { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //one to many
            modelBuilder.Entity<Smjer>().HasRequired(x => x.Fakultet).WithMany().HasForeignKey(x => x.FakultetId);
            modelBuilder.Entity<UpisGodine>().HasRequired(x => x.Student).WithMany().HasForeignKey(x => x.StudentId);
            modelBuilder.Entity<UpisGodine>().HasRequired(x => x.AkademskaGodina).WithMany().HasForeignKey(x => x.AkademskaGodinaId);
        }

        public override int SaveChanges()
        {
            DateTime now = DateTime.Now;
            foreach (ObjectStateEntry entry in (this as IObjectContextAdapter).ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                if (!entry.IsRelationship)
                {
                    IHasLastModified lastModified = entry.Entity as IHasLastModified;
                    if (lastModified != null)
                        lastModified.DatumUpisa = now;
                }
            }
            return base.SaveChanges();
        }
    }
}