﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Heritage.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Bd_Web_ASPEntities : DbContext
    {
        public Bd_Web_ASPEntities()
            : base("name=Bd_Web_ASPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AYANTDROIT> AYANTDROITs { get; set; }
        public virtual DbSet<BIEN> BIENS { get; set; }
        public virtual DbSet<ECOLE> ECOLEs { get; set; }
        public virtual DbSet<HERITAGE> HERITAGEs { get; set; }
        public virtual DbSet<HERITIER> HERITIERs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<REGLE> REGLEs { get; set; }
        public virtual DbSet<SOURCE> SOURCEs { get; set; }
        public virtual DbSet<UTILISATEUR> UTILISATEURs { get; set; }
    }
}
