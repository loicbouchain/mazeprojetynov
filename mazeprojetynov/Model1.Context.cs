﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mazeprojetynov
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ynovprojetEntities : DbContext
    {
        public ynovprojetEntities()
            : base("name=ynovprojetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<casemap> casemap { get; set; }
        public virtual DbSet<map> map { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}
