//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblAdministrador
    {
        public int IDAdmin { get; set; }
        public string NombreAdmin { get; set; }
        public string ApellidoAdmin { get; set; }
        public int FKRol { get; set; }
        public int FKCuenta { get; set; }
    
        public virtual tblCuenta tblCuenta { get; set; }
        public virtual tblRol tblRol { get; set; }
    }
}
