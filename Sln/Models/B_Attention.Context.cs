﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sln.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadSistema : DbContext
    {
        public EntidadSistema()
            : base("name=EntidadSistema")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tratamiento> Tratamientoes { get; set; }
        public virtual DbSet<Actividad> Actividads { get; set; }
        public virtual DbSet<Resultado> Resultadoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioTratamiento> UsuarioTratamientoes { get; set; }
        public virtual DbSet<VResultado> VResultadoes { get; set; }
    }
}
