﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlkemyLabs2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlkemyLabs2Entities : DbContext
    {
        public AlkemyLabs2Entities()
            : base("name=AlkemyLabs2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<inscription> inscription { get; set; }
        public virtual DbSet<matter> matter { get; set; }
        public virtual DbSet<module> module { get; set; }
        public virtual DbSet<operation> operation { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<rol_operation> rol_operation { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<teacher> teacher { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}