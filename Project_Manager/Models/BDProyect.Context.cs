﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Manager.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_APManagerEntities : DbContext
    {
        public BD_APManagerEntities()
            : base("name=BD_APManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAdministrador> tblAdministrador { get; set; }
        public virtual DbSet<tblAsignacion> tblAsignacion { get; set; }
        public virtual DbSet<tblCliente> tblCliente { get; set; }
        public virtual DbSet<tblCuenta> tblCuenta { get; set; }
        public virtual DbSet<tblDocumentacion> tblDocumentacion { get; set; }
        public virtual DbSet<tblEmpleado> tblEmpleado { get; set; }
        public virtual DbSet<tblProblema> tblProblema { get; set; }
        public virtual DbSet<tblProyectos> tblProyectos { get; set; }
        public virtual DbSet<tblRol> tblRol { get; set; }
        public virtual DbSet<tblTarjeta> tblTarjeta { get; set; }
    }
}
