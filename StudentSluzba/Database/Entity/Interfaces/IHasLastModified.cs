using System;

namespace StudentSluzba.Database.Entity.Interfaces
{
    /// <summary>
    /// Use this interface in entity where you want to have last modified date field
    /// </summary>
    public interface IHasLastModified
    {
        DateTime? DatumUpisa { get; set; }
    }
}